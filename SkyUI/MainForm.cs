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


namespace Skyfall
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
            rendererControl.RenderBoundingBox = checkBox1.Checked;
            rendererControl.FOV = 0.5f + 1.5f * trackBarZoom.Value / (float) trackBarZoom.Maximum;
            rendererControl.SkyDome.ThetaSun = (thetaTrackBar.Value / 100.0f) * (float)Math.PI;
            rendererControl.SkyDome.PhiSun = (phiTrackBar.Value / 100.0f) * (float)Math.PI * 2.0f;
            rendererControl.SkyDome.Turbidity = 10.0f * turbidityTrackBar.Value / (float)turbidityTrackBar.Maximum;
            rendererControl.SkyDome.Exposure = 0.01f + 1.99f * exposureTrackBar.Value / (float)exposureTrackBar.Maximum;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
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

        private void thetaTrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateRenderControl();
        }

        private void phiTrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateRenderControl();
        }

        private void turbidityTrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateRenderControl();
        }

        private void exposureTrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateRenderControl();
        }
    }
}
