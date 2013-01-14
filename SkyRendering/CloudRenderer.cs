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
        BasicEffect effect;
        GraphicsDevice device;
        ContentManager content;

        public CloudRenderer(GraphicsDevice dev, IServiceProvider services)
        {
            device = dev;

            content = new ContentManager(services);
            content.RootDirectory = "./SkyContent";
            mesh = content.Load<Model>("sphere");
            effect = new BasicEffect(dev);
        }


        public void Render(Cloud cloud, Matrix view, Matrix proj)
        {
            foreach (var sphere in cloud.Spheres)
            {
                effect.World =
                    Matrix.CreateScale(sphere.radius) *
                    Matrix.CreateTranslation(sphere.position);
                effect.View = view;
                effect.Projection = proj;
                effect.DiffuseColor = new Vector3(0.0f, 0.8f, 0.0f);

                mesh.Meshes[0].MeshParts[0].Effect = effect;
                mesh.Meshes[0].Draw();
            }
        }

    }
}
