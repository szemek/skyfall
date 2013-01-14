namespace Skyfall
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.renderParams = new System.Windows.Forms.TabPage();
            this.sunGroupBox = new System.Windows.Forms.GroupBox();
            this.phiTrackBar = new System.Windows.Forms.TrackBar();
            this.phiLabel = new System.Windows.Forms.Label();
            this.thetaTrackBar = new System.Windows.Forms.TrackBar();
            this.thetaLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarContrast = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarZoom = new System.Windows.Forms.TrackBar();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.skyParams = new System.Windows.Forms.TabPage();
            this.rendererControl = new WinFormsGraphicsDevice.RendererControl();
            this.turbidityLabel = new System.Windows.Forms.Label();
            this.turbidityTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.renderParams.SuspendLayout();
            this.sunGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phiTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thetaTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).BeginInit();
            this.skyParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turbidityTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.rendererControl);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(883, 511);
            this.splitContainer1.SplitterDistance = 634;
            this.splitContainer1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.renderParams);
            this.tabControl1.Controls.Add(this.skyParams);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(252, 511);
            this.tabControl1.TabIndex = 1;
            // 
            // renderParams
            // 
            this.renderParams.Controls.Add(this.sunGroupBox);
            this.renderParams.Controls.Add(this.label2);
            this.renderParams.Controls.Add(this.trackBarContrast);
            this.renderParams.Controls.Add(this.label1);
            this.renderParams.Controls.Add(this.trackBarZoom);
            this.renderParams.Controls.Add(this.checkBox4);
            this.renderParams.Controls.Add(this.checkBox3);
            this.renderParams.Controls.Add(this.checkBox2);
            this.renderParams.Controls.Add(this.checkBox1);
            this.renderParams.Location = new System.Drawing.Point(4, 25);
            this.renderParams.Name = "renderParams";
            this.renderParams.Padding = new System.Windows.Forms.Padding(3);
            this.renderParams.Size = new System.Drawing.Size(244, 482);
            this.renderParams.TabIndex = 0;
            this.renderParams.Text = "Renderer Parameters";
            this.renderParams.UseVisualStyleBackColor = true;
            // 
            // sunGroupBox
            // 
            this.sunGroupBox.Controls.Add(this.phiTrackBar);
            this.sunGroupBox.Controls.Add(this.phiLabel);
            this.sunGroupBox.Controls.Add(this.thetaTrackBar);
            this.sunGroupBox.Controls.Add(this.thetaLabel);
            this.sunGroupBox.Location = new System.Drawing.Point(24, 254);
            this.sunGroupBox.Name = "sunGroupBox";
            this.sunGroupBox.Size = new System.Drawing.Size(200, 190);
            this.sunGroupBox.TabIndex = 12;
            this.sunGroupBox.TabStop = false;
            this.sunGroupBox.Text = "Sun";
            // 
            // phiTrackBar
            // 
            this.phiTrackBar.Location = new System.Drawing.Point(43, 60);
            this.phiTrackBar.Maximum = 100;
            this.phiTrackBar.Name = "phiTrackBar";
            this.phiTrackBar.Size = new System.Drawing.Size(148, 45);
            this.phiTrackBar.TabIndex = 13;
            this.phiTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.phiTrackBar.Value = 62;
            this.phiTrackBar.Scroll += new System.EventHandler(this.phiTrackBar_Scroll);
            // 
            // phiLabel
            // 
            this.phiLabel.AutoSize = true;
            this.phiLabel.Location = new System.Drawing.Point(10, 60);
            this.phiLabel.Name = "phiLabel";
            this.phiLabel.Size = new System.Drawing.Size(21, 13);
            this.phiLabel.TabIndex = 12;
            this.phiLabel.Text = "phi";
            // 
            // thetaTrackBar
            // 
            this.thetaTrackBar.Location = new System.Drawing.Point(43, 28);
            this.thetaTrackBar.Maximum = 100;
            this.thetaTrackBar.Name = "thetaTrackBar";
            this.thetaTrackBar.Size = new System.Drawing.Size(148, 45);
            this.thetaTrackBar.TabIndex = 11;
            this.thetaTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.thetaTrackBar.Value = 35;
            this.thetaTrackBar.Scroll += new System.EventHandler(this.thetaTrackBar_Scroll);
            // 
            // thetaLabel
            // 
            this.thetaLabel.AutoSize = true;
            this.thetaLabel.Location = new System.Drawing.Point(6, 28);
            this.thetaLabel.Name = "thetaLabel";
            this.thetaLabel.Size = new System.Drawing.Size(31, 13);
            this.thetaLabel.TabIndex = 9;
            this.thetaLabel.Text = "theta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contrast";
            // 
            // trackBarContrast
            // 
            this.trackBarContrast.Location = new System.Drawing.Point(61, 220);
            this.trackBarContrast.Maximum = 1000;
            this.trackBarContrast.Minimum = 20;
            this.trackBarContrast.Name = "trackBarContrast";
            this.trackBarContrast.Size = new System.Drawing.Size(148, 45);
            this.trackBarContrast.TabIndex = 6;
            this.trackBarContrast.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarContrast.Value = 100;
            this.trackBarContrast.Scroll += new System.EventHandler(this.trackBarContrast_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Zoom";
            // 
            // trackBarZoom
            // 
            this.trackBarZoom.Location = new System.Drawing.Point(61, 28);
            this.trackBarZoom.Maximum = 30;
            this.trackBarZoom.Minimum = -10;
            this.trackBarZoom.Name = "trackBarZoom";
            this.trackBarZoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarZoom.Size = new System.Drawing.Size(104, 45);
            this.trackBarZoom.TabIndex = 4;
            this.trackBarZoom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarZoom.Value = 10;
            this.trackBarZoom.Scroll += new System.EventHandler(this.trackBarZoom_Scroll);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(24, 163);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(110, 17);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Use specular light";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(24, 140);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(101, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Use diffuse light";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(24, 117);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(116, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Show vessel graph";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(24, 80);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(120, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Show bounding box";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // skyParams
            // 
            this.skyParams.Controls.Add(this.turbidityTrackBar);
            this.skyParams.Controls.Add(this.turbidityLabel);
            this.skyParams.Location = new System.Drawing.Point(4, 25);
            this.skyParams.Name = "skyParams";
            this.skyParams.Padding = new System.Windows.Forms.Padding(3);
            this.skyParams.Size = new System.Drawing.Size(244, 482);
            this.skyParams.TabIndex = 1;
            this.skyParams.Text = "Sky Parameters";
            this.skyParams.UseVisualStyleBackColor = true;
            // 
            // rendererControl
            // 
            this.rendererControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rendererControl.Location = new System.Drawing.Point(0, 0);
            this.rendererControl.Name = "rendererControl";
            this.rendererControl.Size = new System.Drawing.Size(634, 511);
            this.rendererControl.TabIndex = 0;
            this.rendererControl.Text = "rendererControl";
            // 
            // turbidityLabel
            // 
            this.turbidityLabel.AutoSize = true;
            this.turbidityLabel.Location = new System.Drawing.Point(26, 25);
            this.turbidityLabel.Name = "turbidityLabel";
            this.turbidityLabel.Size = new System.Drawing.Size(43, 13);
            this.turbidityLabel.TabIndex = 14;
            this.turbidityLabel.Text = "turbidity";
            // 
            // turbidityTrackBar
            // 
            this.turbidityTrackBar.Location = new System.Drawing.Point(92, 25);
            this.turbidityTrackBar.Name = "turbidityTrackBar";
            this.turbidityTrackBar.Size = new System.Drawing.Size(104, 45);
            this.turbidityTrackBar.TabIndex = 15;
            this.turbidityTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.turbidityTrackBar.Scroll += new System.EventHandler(this.turbidityTrackBar_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 511);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Skyfall";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.renderParams.ResumeLayout(false);
            this.renderParams.PerformLayout();
            this.sunGroupBox.ResumeLayout(false);
            this.sunGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phiTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thetaTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarContrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).EndInit();
            this.skyParams.ResumeLayout(false);
            this.skyParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.turbidityTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WinFormsGraphicsDevice.RendererControl rendererControl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage skyParams;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage renderParams;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarContrast;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarZoom;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox sunGroupBox;
        private System.Windows.Forms.TrackBar phiTrackBar;
        private System.Windows.Forms.Label phiLabel;
        private System.Windows.Forms.TrackBar thetaTrackBar;
        private System.Windows.Forms.Label thetaLabel;
        private System.Windows.Forms.TrackBar turbidityTrackBar;
        private System.Windows.Forms.Label turbidityLabel;

    }
}

