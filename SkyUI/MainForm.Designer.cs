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
            this.rendererControl = new WinFormsGraphicsDevice.RendererControl();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.renderParams = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarZoom = new System.Windows.Forms.TrackBar();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.skyParams = new System.Windows.Forms.TabPage();
            this.exposureTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.sunGroupBox = new System.Windows.Forms.GroupBox();
            this.phiTrackBar = new System.Windows.Forms.TrackBar();
            this.phiLabel = new System.Windows.Forms.Label();
            this.thetaTrackBar = new System.Windows.Forms.TrackBar();
            this.thetaLabel = new System.Windows.Forms.Label();
            this.turbidityTrackBar = new System.Windows.Forms.TrackBar();
            this.turbidityLabel = new System.Windows.Forms.Label();
            this.moveLabel = new System.Windows.Forms.Label();
            this.moveTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.renderParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).BeginInit();
            this.skyParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exposureTrackBar)).BeginInit();
            this.sunGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phiTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thetaTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbidityTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveTrackBar)).BeginInit();
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
            this.splitContainer1.Size = new System.Drawing.Size(989, 565);
            this.splitContainer1.SplitterDistance = 710;
            this.splitContainer1.TabIndex = 2;
            // 
            // rendererControl
            // 
            this.rendererControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rendererControl.Location = new System.Drawing.Point(0, 0);
            this.rendererControl.Name = "rendererControl";
            this.rendererControl.Size = new System.Drawing.Size(710, 565);
            this.rendererControl.TabIndex = 0;
            this.rendererControl.Text = "rendererControl";
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
            this.renderParams.Controls.Add(this.label1);
            this.renderParams.Controls.Add(this.trackBarZoom);
            this.renderParams.Controls.Add(this.checkBox1);
            this.renderParams.Location = new System.Drawing.Point(4, 25);
            this.renderParams.Name = "renderParams";
            this.renderParams.Padding = new System.Windows.Forms.Padding(3);
            this.renderParams.Size = new System.Drawing.Size(244, 482);
            this.renderParams.TabIndex = 0;
            this.renderParams.Text = "Renderer Parameters";
            this.renderParams.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "FOV";
            // 
            // trackBarZoom
            // 
            this.trackBarZoom.Location = new System.Drawing.Point(61, 28);
            this.trackBarZoom.Maximum = 300;
            this.trackBarZoom.Name = "trackBarZoom";
            this.trackBarZoom.Size = new System.Drawing.Size(104, 45);
            this.trackBarZoom.TabIndex = 4;
            this.trackBarZoom.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarZoom.Value = 100;
            this.trackBarZoom.Scroll += new System.EventHandler(this.trackBarZoom_Scroll);
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
            this.skyParams.Controls.Add(this.exposureTrackBar);
            this.skyParams.Controls.Add(this.label2);
            this.skyParams.Controls.Add(this.sunGroupBox);
            this.skyParams.Controls.Add(this.turbidityTrackBar);
            this.skyParams.Controls.Add(this.turbidityLabel);
            this.skyParams.Location = new System.Drawing.Point(4, 25);
            this.skyParams.Name = "skyParams";
            this.skyParams.Padding = new System.Windows.Forms.Padding(3);
            this.skyParams.Size = new System.Drawing.Size(244, 482);
            this.skyParams.TabIndex = 1;
            this.skyParams.Text = "Sky Dome";
            this.skyParams.UseVisualStyleBackColor = true;
            // 
            // exposureTrackBar
            // 
            this.exposureTrackBar.Location = new System.Drawing.Point(73, 240);
            this.exposureTrackBar.Maximum = 500;
            this.exposureTrackBar.Name = "exposureTrackBar";
            this.exposureTrackBar.Size = new System.Drawing.Size(144, 45);
            this.exposureTrackBar.TabIndex = 17;
            this.exposureTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.exposureTrackBar.Value = 20;
            this.exposureTrackBar.Scroll += new System.EventHandler(this.exposureTrackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Exposure";
            // 
            // sunGroupBox
            // 
            this.sunGroupBox.Controls.Add(this.moveTrackBar);
            this.sunGroupBox.Controls.Add(this.moveLabel);
            this.sunGroupBox.Controls.Add(this.phiTrackBar);
            this.sunGroupBox.Controls.Add(this.phiLabel);
            this.sunGroupBox.Controls.Add(this.thetaTrackBar);
            this.sunGroupBox.Controls.Add(this.thetaLabel);
            this.sunGroupBox.Location = new System.Drawing.Point(26, 50);
            this.sunGroupBox.Name = "sunGroupBox";
            this.sunGroupBox.Size = new System.Drawing.Size(200, 136);
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
            this.phiLabel.Size = new System.Drawing.Size(22, 13);
            this.phiLabel.TabIndex = 12;
            this.phiLabel.Text = "Phi";
            // 
            // thetaTrackBar
            // 
            this.thetaTrackBar.Location = new System.Drawing.Point(43, 28);
            this.thetaTrackBar.Maximum = 100;
            this.thetaTrackBar.Name = "thetaTrackBar";
            this.thetaTrackBar.Size = new System.Drawing.Size(148, 45);
            this.thetaTrackBar.TabIndex = 11;
            this.thetaTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.thetaTrackBar.Value = 30;
            this.thetaTrackBar.Scroll += new System.EventHandler(this.thetaTrackBar_Scroll);
            // 
            // thetaLabel
            // 
            this.thetaLabel.AutoSize = true;
            this.thetaLabel.Location = new System.Drawing.Point(6, 28);
            this.thetaLabel.Name = "thetaLabel";
            this.thetaLabel.Size = new System.Drawing.Size(35, 13);
            this.thetaLabel.TabIndex = 9;
            this.thetaLabel.Text = "Theta";
            // 
            // turbidityTrackBar
            // 
            this.turbidityTrackBar.Location = new System.Drawing.Point(73, 208);
            this.turbidityTrackBar.Maximum = 800;
            this.turbidityTrackBar.Name = "turbidityTrackBar";
            this.turbidityTrackBar.Size = new System.Drawing.Size(144, 45);
            this.turbidityTrackBar.TabIndex = 15;
            this.turbidityTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.turbidityTrackBar.Value = 290;
            this.turbidityTrackBar.Scroll += new System.EventHandler(this.turbidityTrackBar_Scroll);
            // 
            // turbidityLabel
            // 
            this.turbidityLabel.AutoSize = true;
            this.turbidityLabel.Location = new System.Drawing.Point(20, 208);
            this.turbidityLabel.Name = "turbidityLabel";
            this.turbidityLabel.Size = new System.Drawing.Size(47, 13);
            this.turbidityLabel.TabIndex = 14;
            this.turbidityLabel.Text = "Turbidity";
            // 
            // moveLabel
            // 
            this.moveLabel.AutoSize = true;
            this.moveLabel.Location = new System.Drawing.Point(10, 108);
            this.moveLabel.Name = "moveLabel";
            this.moveLabel.Size = new System.Drawing.Size(33, 13);
            this.moveLabel.TabIndex = 14;
            this.moveLabel.Text = "move";
            // 
            // moveTrackBar
            // 
            this.moveTrackBar.Location = new System.Drawing.Point(87, 91);
            this.moveTrackBar.Maximum = 99;
            this.moveTrackBar.Name = "moveTrackBar";
            this.moveTrackBar.Size = new System.Drawing.Size(104, 45);
            this.moveTrackBar.TabIndex = 15;
            this.moveTrackBar.TickFrequency = 10;
            this.moveTrackBar.Scroll += new System.EventHandler(this.moveTrackBar_Scroll);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 565);
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
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZoom)).EndInit();
            this.skyParams.ResumeLayout(false);
            this.skyParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exposureTrackBar)).EndInit();
            this.sunGroupBox.ResumeLayout(false);
            this.sunGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phiTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thetaTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbidityTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moveTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WinFormsGraphicsDevice.RendererControl rendererControl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage skyParams;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage renderParams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarZoom;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox sunGroupBox;
        private System.Windows.Forms.TrackBar phiTrackBar;
        private System.Windows.Forms.Label phiLabel;
        private System.Windows.Forms.TrackBar thetaTrackBar;
        private System.Windows.Forms.Label thetaLabel;
        private System.Windows.Forms.TrackBar turbidityTrackBar;
        private System.Windows.Forms.Label turbidityLabel;
        private System.Windows.Forms.TrackBar exposureTrackBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar moveTrackBar;
        private System.Windows.Forms.Label moveLabel;

    }
}

