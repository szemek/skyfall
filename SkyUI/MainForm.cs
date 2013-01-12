using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using WinFormsGraphicsDevice;
using Microsoft.Xna.Framework.Content;
using Sky;


namespace Tumor
{
    public partial class MainForm : Form
    {
        [DllImport("Kernel32.dll")]
        static extern Boolean AllocConsole();

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!AllocConsole())
                MessageBox.Show("AllocConsole failed.");
            else
            {
                Console.CursorVisible = false;
                Console.SetWindowPosition(0, 0);
                Console.SetBufferSize(120, 300);
            }

            UpdateRenderControl();
        }

        private void UpdateRenderControl()
        {
            rendererControl.RenderVesselGraph = checkBox2.Checked;
            rendererControl.UseDiffuseLight = checkBox3.Checked;
            rendererControl.UseSpecularLight = checkBox4.Checked;
            rendererControl.RenderBoundingBox = checkBox1.Checked;
            rendererControl.CameraDistance = trackBarZoom.Value * 0.1f;
            rendererControl.Contrast = trackBarContrast.Value * 0.01f;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox3.Enabled = checkBox4.Enabled = checkBox2.Checked;
            UpdateRenderControl();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRenderControl();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRenderControl();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRenderControl();
        }

        private void trackBarZoom_Scroll(object sender, EventArgs e)
        {
            UpdateRenderControl();
        }

        private void trackBarContrast_Scroll(object sender, EventArgs e)
        {
            UpdateRenderControl();
        }
    }
}
