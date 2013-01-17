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

        public float[] phis = new float[100];
        public float[] thetas = new float[100];

        public void InitializeAngles()
        {
            for (int i = 0; i < 100; i++)
            {
                phis[i] = (float) Math.PI + (i / 100.0f) * (float) Math.PI;
                thetas[i] = (float) (90.0f - 60.0f * Math.Sin((i / 100.0f) * (float) Math.PI)) * (float) Math.PI / 180.0f;
            }
        }

        public MainForm()
        {
            InitializeAngles();
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
			rendererControl.RenderBoundingBox = boundingBoxCheckBox.Checked;
            rendererControl.FOV = 0.5f + 1.5f * FOVTrackBar.Value / (float) FOVTrackBar.Maximum;

            //rendererControl.SkyDome.ThetaSun = (thetaTrackBar.Value / 100.0f) * (float)Math.PI;
            //rendererControl.SkyDome.PhiSun = (phiTrackBar.Value / 100.0f) * (float)Math.PI * 2.0f;
			rendererControl.SkyDome.ThetaSun = thetas[moveTrackBar.Value];
            rendererControl.SkyDome.PhiSun = phis[moveTrackBar.Value];
            rendererControl.SkyDome.Turbidity = 10.0f * turbidityTrackBar.Value / (float)turbidityTrackBar.Maximum;
            rendererControl.SkyDome.Exposure = 0.01f + 0.66f * exposureTrackBar.Value / (float)exposureTrackBar.Maximum;

            rendererControl.CloudRenderer.DirectionalMin = directionalMinTB.Value / (float)directionalMinTB.Maximum;
            rendererControl.CloudRenderer.DirectionalMax = directionalMaxTB.Value / (float)directionalMaxTB.Maximum;
            rendererControl.CloudRenderer.DirectionalExp = 0.2f + 1.3f * directionalExpTB.Value / (float)directionalExpTB.Maximum;
            rendererControl.CloudRenderer.ScatteredMin = scatteredMinTB.Value / (float)scatteredMinTB.Maximum;
            rendererControl.CloudRenderer.ScatteredMax = scatteredMaxTB.Value / (float)scatteredMaxTB.Maximum;
            rendererControl.CloudRenderer.Constant = constantTB.Value / (float)constantTB.Maximum;
            rendererControl.CloudRenderer.Hardness = 0.2f + 15.0f * hardnessTB.Value / (float)hardnessTB.Maximum;
            rendererControl.CloudRenderer.BypassDistortion = distortionBypassCheckbox.Checked;
            rendererControl.CloudRenderer.DistortionFreq = 0.2f + 5.0f * frequencyTB.Value / (float)frequencyTB.Maximum;
            rendererControl.CloudRenderer.DistortionAmp = 0.01f + 0.2f * amplitudeTB.Value / (float)amplitudeTB.Maximum;
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

        private void moveTrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateRenderControl();
        }
		
		private void scatteredMinTB_Scroll(object sender, EventArgs e)
        {
            UpdateRenderControl();
        }

        private void scatteredMaxTB_Scroll(object sender, EventArgs e)
        {
            UpdateRenderControl();
        }

        private void directionalMinTB_Scroll(object sender, EventArgs e)
        {
            UpdateRenderControl();
        }

        private void directionalMaxTB_Scroll(object sender, EventArgs e)
        {
            UpdateRenderControl();
        }

        private void constantTB_Scroll(object sender, EventArgs e)
        {
            UpdateRenderControl();
        }

        private void hardnessTB_Scroll(object sender, EventArgs e)
        {
            UpdateRenderControl();
        }

        private void distortionBypassCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRenderControl();
        }

        private void frequencyTB_Scroll(object sender, EventArgs e)
        {
            UpdateRenderControl();
        }

        private void amplitudeTB_Scroll(object sender, EventArgs e)
        {
            UpdateRenderControl();
        }

        private void directionalExpTB_Scroll(object sender, EventArgs e)
        {
            UpdateRenderControl();
        }

        private void boundingBoxCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            UpdateRenderControl();
        }

        private void FOVTrackBar_Scroll(object sender, EventArgs e)
        {
            UpdateRenderControl();
        }
    }
}
