using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Sky
{
    public class CloudRenderer
    {
        Model mesh;
        Effect effectLight, effectPostprocess;
        GraphicsDevice device;
        ContentManager content;
        RenderTarget2D lightingTarget, blurHTarget, blurVTarget;
        Texture2D distortion;
        VertexBuffer fullscreenQuad;
        int targetResolution;


        public CloudRenderer(GraphicsDevice dev, IServiceProvider services)
        {
            device = dev;

            content = new ContentManager(services);
            content.RootDirectory = "./SkyContent";
            mesh = content.Load<Model>("sphere");
            effectLight = content.Load<Effect>("cloudLight");
            effectPostprocess = content.Load<Effect>("cloudPostprocess");
            distortion = content.Load<Texture2D>("noise");

            targetResolution = 512;
            lightingTarget = new RenderTarget2D(device, targetResolution, targetResolution, false, SurfaceFormat.Color, DepthFormat.Depth24);
            blurHTarget = new RenderTarget2D(device, targetResolution, targetResolution, false, SurfaceFormat.Color, DepthFormat.Depth24);
            blurVTarget = new RenderTarget2D(device, targetResolution, targetResolution, false, SurfaceFormat.Color, DepthFormat.Depth24);

            VertexPositionColor [] verts = new VertexPositionColor[] {
                new VertexPositionColor(new Vector3(-1,-1, 0), Color.White),
                new VertexPositionColor(new Vector3( 1,-1, 0), Color.White),
                new VertexPositionColor(new Vector3(-1, 1, 0), Color.White),
                new VertexPositionColor(new Vector3( 1, 1, 0), Color.White)
            };

            fullscreenQuad = new VertexBuffer(device, VertexPositionColor.VertexDeclaration, 4, BufferUsage.WriteOnly);
            fullscreenQuad.SetData(verts);
        }


        public void Render(Cloud cloud, Matrix view, Matrix proj, Vector3 sunDir)
        {
            device.SetRenderTarget(lightingTarget);
            device.Clear(Color.Transparent);
            foreach (var sphere in cloud.Spheres)
            {
                Matrix world = Matrix.CreateScale(sphere.radius) * Matrix.CreateTranslation(sphere.position);
                effectLight.Parameters["worldViewProj"].SetValue(world * view * proj);
                effectLight.Parameters["worldView"].SetValue(world);
                effectLight.Parameters["sunDir"].SetValue(sunDir);

                mesh.Meshes[0].MeshParts[0].Effect = effectLight;
                mesh.Meshes[0].Draw();
            }
            device.BlendState = BlendState.AlphaBlend;

            device.SetRenderTarget(blurVTarget);
            device.Clear(Color.Transparent);
            effectPostprocess.Parameters["cloudLight"].SetValue(lightingTarget);
            effectPostprocess.Parameters["offset"].SetValue(1.0f / (float)targetResolution);
            effectPostprocess.CurrentTechnique.Passes[0].Apply();
            device.SetVertexBuffer(fullscreenQuad);
            device.DrawPrimitives(PrimitiveType.TriangleStrip, 0, 2);

            device.SetRenderTarget(blurHTarget);
            device.Clear(Color.Transparent);
            effectPostprocess.Parameters["cloudLight"].SetValue(blurVTarget);
            effectPostprocess.Parameters["offset"].SetValue(1.0f / (float)targetResolution);
            effectPostprocess.CurrentTechnique.Passes[1].Apply();
            device.SetVertexBuffer(fullscreenQuad);
            device.DrawPrimitives(PrimitiveType.TriangleStrip, 0, 2);

            device.SetRenderTarget(null);
            effectPostprocess.Parameters["cloudLight"].SetValue(blurHTarget);
            effectPostprocess.Parameters["offset"].SetValue(1.0f / (float)targetResolution);
            effectPostprocess.Parameters["distortion"].SetValue(distortion);
            effectPostprocess.CurrentTechnique.Passes[2].Apply();
            device.SetVertexBuffer(fullscreenQuad);
            device.DrawPrimitives(PrimitiveType.TriangleStrip, 0, 2);

            device.BlendState = BlendState.Opaque;
        }

    }
}
