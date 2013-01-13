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

        public float Turbidity  = 3.0f;
        public float ThetaSun = 1.1f;
        public float PhiSun = 3.9f;


        public SkyDome(GraphicsDevice dev, IServiceProvider services)
        {
            device = dev;

            Content = new ContentManager(services);
            Content.RootDirectory = "./SkyContent";

            effect = Content.Load<Effect>("skydome");

            genVertices(30, 15);
        }


        private void genVertices(int phiSteps, int thetaSteps)
        {
            int nVerts = 3 * (phiSteps - thetaSteps + 1); // triangle fan
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
	
	        int res = phiSteps - thetaSteps + 1;
            float phiStep = 2 * (float)Math.PI / (float)res;
            float thetaStep = 0.5f * (float)Math.PI / (float)thetaSteps;
	        float phi = 0;

	        for(int i=0; i<res; i++) // triangle fan
	        {
                verts[idx++] = new SkyVertex(0, 1, 0, phi, 0); // triangle fan
		        verts[idx++] = new SkyVertex(phi, thetaStep);
                verts[idx++] = new SkyVertex(phi + phiStep, thetaStep);
		
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


        void setParameters()
        {
            float[] coeffY = new float[5];
            float[] coeffx = new float[5];
            float[] coeffy = new float[5];

	        coeffY[0] =  0.1787f * Turbidity - 1.4630f;
	        coeffY[1] = -0.3554f * Turbidity + 0.4275f;
	        coeffY[2] = -0.0227f * Turbidity + 5.3251f;
	        coeffY[3] =  0.1206f * Turbidity - 2.5771f;
	        coeffY[4] = -0.0670f * Turbidity + 0.3703f;

	        coeffx[0] = -0.0193f * Turbidity - 0.2592f;
	        coeffx[1] = -0.0665f * Turbidity + 0.0008f;
	        coeffx[2] = -0.0004f * Turbidity + 0.2125f;
	        coeffx[3] = -0.0641f * Turbidity - 0.8989f;
	        coeffx[4] = -0.0033f * Turbidity + 0.0452f;

	        coeffy[0] = -0.0167f * Turbidity - 0.2608f;
	        coeffy[1] = -0.0950f * Turbidity + 0.0092f;
	        coeffy[2] = -0.0079f * Turbidity + 0.2102f;
	        coeffy[3] = -0.0441f * Turbidity - 1.6537f;
	        coeffy[4] = -0.0109f * Turbidity + 0.0529f;

            effect.Parameters["coeffx"].SetValue(coeffx);
            effect.Parameters["coeffy"].SetValue(coeffy);
            effect.Parameters["coeffY"].SetValue(coeffY);


	        float chi = (4/9.0f - Turbidity/120.0f) * ((float)Math.PI - 2 * ThetaSun);
	        float zenithY = (4.0453f * Turbidity - 4.9710f) * (float)Math.Tan(chi) - 0.2155f * Turbidity + 2.4192f;

            float thetaS2 = ThetaSun * ThetaSun;
            float thetaS3 = thetaS2 * ThetaSun;
	        float T2 = Turbidity * Turbidity;

            float zenithx = T2 * (0.00166f * thetaS3 - 0.00375f * thetaS2 + 0.00209f * ThetaSun) +
                Turbidity * (-0.02903f * thetaS3 + 0.06377f * thetaS2 - 0.03202f * ThetaSun + 0.00394f) +
                              (0.11693f * thetaS3 - 0.21196f * thetaS2 + 0.06052f * ThetaSun + 0.25886f);

            float zenithy = T2 * (0.00275f * thetaS3 - 0.00610f * thetaS2 + 0.00317f * ThetaSun) +
                Turbidity * (-0.04214f * thetaS3 + 0.08970f * thetaS2 - 0.04153f * ThetaSun + 0.00516f) +
                              (0.15346f * thetaS3 - 0.26756f * thetaS2 + 0.06670f * ThetaSun + 0.26688f);

            effect.Parameters["zenithx"].SetValue(zenithx);
            effect.Parameters["zenithy"].SetValue(zenithy);
            effect.Parameters["zenithY"].SetValue(zenithY);

            effect.Parameters["thetaS"].SetValue(ThetaSun);
	        effect.Parameters["phiS"].SetValue(PhiSun);
	        effect.Parameters["turbidity"].SetValue(Turbidity);

            Matrix xyztorgb = new Matrix(); // adobe rgb 1998
            xyztorgb.M11 = 3.240479f;  xyztorgb.M21 = -1.53715f;  xyztorgb.M31 = -0.49853f;
            xyztorgb.M12 = -0.969256f; xyztorgb.M22 = 1.875991f;  xyztorgb.M32 = 0.041556f;
            xyztorgb.M13 = 0.055648f;  xyztorgb.M23 = -0.204043f; xyztorgb.M33 = 1.057311f;
            effect.Parameters["XYZtoRGB"].SetValue(xyztorgb);
        }



        public void Render(Matrix view, Matrix proj)
        {
            device.DepthStencilState = DepthStencilState.DepthRead;

            setParameters();
            Matrix world = Matrix.CreateTranslation(0, -0.3f, 0);
            effect.Parameters["viewProj"].SetValue(world * view * proj);

            effect.CurrentTechnique.Passes[0].Apply();

            device.SetVertexBuffer(vBuffer);

            device.DrawPrimitives(PrimitiveType.TriangleList, 0, phiSteps - thetaSteps + 1);

            int offset = 3 * (phiSteps - thetaSteps + 1);
            for (int i = 0; i < thetaSteps - 1; i++)
            {
                device.DrawPrimitives(PrimitiveType.TriangleStrip, offset, triStrips[i] - 2);
                offset += triStrips[i];
            }

            device.DepthStencilState = DepthStencilState.Default;
        }

    }
}
