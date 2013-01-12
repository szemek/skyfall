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
    public class SkyDome
    {
        struct SkyVertex
        {
            Vector3 position;
            float phi, theta;

            public static int SizeInBytes { get { return 16; } }

            public static readonly VertexElement[] VertexElements =
                new VertexElement[] {
                    new VertexElement(0, VertexElementFormat.Vector3, VertexElementUsage.Position, 0),
                    new VertexElement(sizeof(float) * 3, VertexElementFormat.Vector2, VertexElementUsage.TextureCoordinate, 0) };

            public SkyVertex(float phi, float theta)
            {
                this.phi = phi;
                this.theta = theta;
                this.position = new Vector3((float)(Math.Cos(phi) * Math.Sin(theta)),
                    (float)Math.Cos(theta), (float)(Math.Sin(phi) * Math.Sin(theta)));
            }

            public SkyVertex(float x, float y, float z, float phi, float theta)
            {
                this.phi = phi;
                this.theta = theta;
                this.position = new Vector3(x, y, z);
            }
        }

        GraphicsDevice device;
        ContentManager Content;
        Effect effect;
        VertexDeclaration vertexDecl;
        VertexBuffer vBuffer;
        int phiSteps, thetaSteps;
        int[] triStrips;

        public SkyDome(GraphicsDevice dev, IServiceProvider services)
        {
            device = dev;

            Content = new ContentManager(services);
            Content.RootDirectory = "./SkyContent";

            effect = Content.Load<Effect>("skydome");

            genVertices(30, 10);
        }


        private void genVertices(int phiSteps, int thetaSteps)
        {
            int nVerts = phiSteps - thetaSteps + 3; // triangle fan
            triStrips = new int[thetaSteps];
            this.phiSteps = phiSteps;
            this.thetaSteps = thetaSteps;

	        int phiRes = phiSteps - thetaSteps + 1;
	        for(int i=0; i<thetaSteps; i++)
	        {
		        nVerts += 2*(phiRes+1) + 1; // triangle strip
		        phiRes++;
		        triStrips[i] = 2*(phiRes+1) - 1;
	        }

            vertexDecl = new VertexDeclaration(SkyVertex.VertexElements);
            SkyVertex[] verts = new SkyVertex[nVerts];

	        int idx = 0;

	        verts[idx++] = new SkyVertex(0, 1, 0, 0, 0); // triangle fan
	
	        int res = phiSteps - thetaSteps + 1;
            float phiStep = 2 * (float)Math.PI / (float)res;
            float thetaStep = 0.5f * (float)Math.PI / (float)thetaSteps;
	        float phi = 0;

	        for(int i=0; i<res+1; i++) // triangle fan
	        {
		        verts[idx++] = new SkyVertex(phi, thetaStep);
		
		        phi += phiStep;
	        }


	        phiRes = phiSteps - thetaSteps + 1;
	        float theta = thetaStep;
	        for(int i=0; i<thetaSteps-1; i++) // triangle strips
	        {
		        float phiDown = 0;
		        float phiUp = 0;

		        for(int j=0; j<phiRes+1; j++)
		        {
			        verts[idx++] = new SkyVertex(phiDown, theta + thetaStep);
			        verts[idx++] = new SkyVertex(phiUp, theta);

			        phiDown += 2 * (float)Math.PI / (float)(phiRes+1);
			        phiUp += 2 * (float)Math.PI / (float)phiRes;
		        }

		        verts[idx++] = new SkyVertex(2 * (float)Math.PI, theta + thetaStep);

		        theta += thetaStep;
		        phiRes++;
	        }

            vBuffer = new VertexBuffer(device, vertexDecl, nVerts, BufferUsage.WriteOnly);
            vBuffer.SetData(verts);
        }


        public void Render(Matrix world, Matrix view, Matrix proj)
        {
            effect.Parameters["World"].SetValue(world);
            effect.Parameters["View"].SetValue(view);
            effect.Parameters["Projection"].SetValue(proj);

            effect.CurrentTechnique.Passes[0].Apply();

            device.SetVertexBuffer(vBuffer);

            //device.DrawPrimitives(PrimitiveType.TriangleList, 0, phiSteps - thetaSteps + 1);

            int offset = phiSteps - thetaSteps + 3;
            for (int i = 0; i < thetaSteps - 1; i++)
            {
                //m_device->DrawPrimitive(D3DPT_TRIANGLESTRIP, offset, m_triStrips[i] - 2);
                device.DrawPrimitives(PrimitiveType.TriangleStrip, offset, triStrips[i] - 2);
                offset += triStrips[i];
            }
        }

    }
}
