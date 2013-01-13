#region File Description
//-----------------------------------------------------------------------------
// SpinningTriangleControl.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

#region Using Statements
using System;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections;
using System.ComponentModel;
using Sky;
#endregion

namespace WinFormsGraphicsDevice
{
    /// <summary>
    /// Example control inherits from GraphicsDeviceControl, which allows it to
    /// render using a GraphicsDevice. This control shows how to draw animating
    /// 3D graphics inside a WinForms application. It hooks the Application.Idle
    /// event, using this to invalidate the control, which will cause the animation
    /// to constantly redraw.
    /// </summary>
    class RendererControl : GraphicsDeviceControl
    {
        BasicEffect effect;
        Stopwatch timer;
        System.Drawing.Point mousePositionOld;
        Vector2 yawPitch;

        Color clearColor;
        Color bboxColor;
        float bboxMargin = 0.02f;

        VertexPositionColor [] bboxVertices;
        Sky.SkyDome skyDome;
        public SkyDome SkyDome { get { return skyDome; } }


        // flags
        public bool RenderBoundingBox = true;
        public bool RenderVesselGraph = true;
        public bool UseDiffuseLight = true;
        public bool UseSpecularLight = true;

        // params
        public float CameraDistance = 2.0f;
        public float Contrast = 1.0f;

        /// <summary>
        /// Initializes the control.
        /// </summary>
        protected override void Initialize()
        {
            effect = new BasicEffect(GraphicsDevice);
            effect.VertexColorEnabled = true;

            timer = Stopwatch.StartNew();

            // Hook the idle event to constantly redraw our animation.
            Application.Idle += delegate { Invalidate(); };
            this.MouseMove += new MouseEventHandler(MouseMoveHandler);

            clearColor = new Color(0.2f, 0.2f, 0.2f);
            bboxColor = Color.Red;

            bboxVertices = new VertexPositionColor[]
            {
                // bottom
                new VertexPositionColor(new Vector3(-1, -1, -1), bboxColor),
                new VertexPositionColor(new Vector3(-1, -1,  1), bboxColor),
                new VertexPositionColor(new Vector3(-1, -1, -1), bboxColor),
                new VertexPositionColor(new Vector3( 1, -1, -1), bboxColor),
                new VertexPositionColor(new Vector3( 1, -1,  1), bboxColor),
                new VertexPositionColor(new Vector3(-1, -1,  1), bboxColor),
                new VertexPositionColor(new Vector3( 1, -1,  1), bboxColor),
                new VertexPositionColor(new Vector3( 1, -1, -1), bboxColor),

                // top
                new VertexPositionColor(new Vector3(-1, 1, -1), bboxColor),
                new VertexPositionColor(new Vector3(-1, 1,  1), bboxColor),
                new VertexPositionColor(new Vector3(-1, 1, -1), bboxColor),
                new VertexPositionColor(new Vector3( 1, 1, -1), bboxColor),
                new VertexPositionColor(new Vector3( 1, 1,  1), bboxColor),
                new VertexPositionColor(new Vector3(-1, 1,  1), bboxColor),
                new VertexPositionColor(new Vector3( 1, 1,  1), bboxColor),
                new VertexPositionColor(new Vector3( 1, 1, -1), bboxColor),

                // side
                new VertexPositionColor(new Vector3(-1, -1, -1), bboxColor),
                new VertexPositionColor(new Vector3(-1,  1, -1), bboxColor),
                new VertexPositionColor(new Vector3(-1, -1,  1), bboxColor),
                new VertexPositionColor(new Vector3(-1,  1,  1), bboxColor),
                new VertexPositionColor(new Vector3( 1, -1, -1), bboxColor),
                new VertexPositionColor(new Vector3( 1,  1, -1), bboxColor),
                new VertexPositionColor(new Vector3( 1, -1,  1), bboxColor),
                new VertexPositionColor(new Vector3( 1,  1,  1), bboxColor),
            };

            for (int i = 0; i < bboxVertices.GetLength(0); i++)
            {
                bboxVertices[i].Position = bboxVertices[i].Position * (1.0f + bboxMargin);
            }

            skyDome = new SkyDome(GraphicsDevice, Services);
        }


        void MouseMoveHandler(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                yawPitch.X += (e.X - mousePositionOld.X) * 0.01f;
                yawPitch.Y -= (e.Y - mousePositionOld.Y) * 0.01f;
            }
            mousePositionOld = e.Location;
        }


        /// <summary>
        /// Draws the control.
        /// </summary>
        protected override void Draw()
        {
            GraphicsDevice.Clear(ClearOptions.Target | ClearOptions.DepthBuffer, clearColor, 1.0f, 0);

            float aspect = GraphicsDevice.Viewport.AspectRatio;

            effect.World = Matrix.Identity;
            effect.View = Matrix.CreateRotationY(yawPitch.X) * Matrix.CreateRotationX(yawPitch.Y);
            effect.Projection = Matrix.CreatePerspectiveFieldOfView(1, aspect, 0.1f, 100.0f);

            //GraphicsDevice.RasterizerState = RasterizerState.CullNone;
            skyDome.Render(effect.View, effect.Projection);

            if (RenderBoundingBox)
            {
                effect.CurrentTechnique.Passes[0].Apply();
                GraphicsDevice.DrawUserPrimitives(PrimitiveType.LineList, bboxVertices, 0, 12);
            }

            
        }

    }
}
