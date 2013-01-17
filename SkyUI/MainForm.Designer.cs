
﻿namespace Skyfall
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
            this.FOVLabel = new System.Windows.Forms.Label();
            this.FOVTrackBar = new System.Windows.Forms.TrackBar();
            this.boundingBoxCheckBox = new System.Windows.Forms.CheckBox();
            this.skyParams = new System.Windows.Forms.TabPage();
            this.exposureTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.sunGroupBox = new System.Windows.Forms.GroupBox();
            this.moveTrackBar = new System.Windows.Forms.TrackBar();
            this.moveLabel = new System.Windows.Forms.Label();
            this.phiTrackBar = new System.Windows.Forms.TrackBar();
            this.phiLabel = new System.Windows.Forms.Label();
            this.thetaTrackBar = new System.Windows.Forms.TrackBar();
            this.thetaLabel = new System.Windows.Forms.Label();
            this.turbidityTrackBar = new System.Windows.Forms.TrackBar();
            this.turbidityLabel = new System.Windows.Forms.Label();
            this.cloudsShadingParams = new System.Windows.Forms.TabPage();
            this.hardnessTB = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.amplitudeTB = new System.Windows.Forms.TrackBar();
            this.frequencyTB = new System.Windows.Forms.TrackBar();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.distortionBypassCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.directionalExpTB = new System.Windows.Forms.TrackBar();
            this.label13 = new System.Windows.Forms.Label();
            this.constantTB = new System.Windows.Forms.TrackBar();
            this.directionalMaxTB = new System.Windows.Forms.TrackBar();
            this.directionalMinTB = new System.Windows.Forms.TrackBar();
            this.scatteredMaxTB = new System.Windows.Forms.TrackBar();
            this.scatteredMinTB = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cloudsLabel = new System.Windows.Forms.Label();
            this.cloudsTrackBar = new System.Windows.Forms.TrackBar();
            this.rendererControl = new WinFormsGraphicsDevice.RendererControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.renderParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FOVTrackBar)).BeginInit();
            this.skyParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exposureTrackBar)).BeginInit();
            this.sunGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phiTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thetaTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbidityTrackBar)).BeginInit();
            this.cloudsShadingParams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hardnessTB)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyTB)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.directionalExpTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.constantTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionalMaxTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionalMinTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scatteredMaxTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scatteredMinTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudsTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
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
            this.splitContainer1.Size = new System.Drawing.Size(897, 565);
            this.splitContainer1.SplitterDistance = 594;
            this.splitContainer1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.renderParams);
            this.tabControl1.Controls.Add(this.skyParams);
            this.tabControl1.Controls.Add(this.cloudsShadingParams);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(293, 511);
            this.tabControl1.TabIndex = 1;
            // 
            // renderParams
            // 
            this.renderParams.Controls.Add(this.cloudsTrackBar);
            this.renderParams.Controls.Add(this.cloudsLabel);
            this.renderParams.Controls.Add(this.FOVLabel);
            this.renderParams.Controls.Add(this.FOVTrackBar);
            this.renderParams.Controls.Add(this.boundingBoxCheckBox);
            this.renderParams.Location = new System.Drawing.Point(4, 25);
            this.renderParams.Name = "renderParams";
            this.renderParams.Padding = new System.Windows.Forms.Padding(3);
            this.renderParams.Size = new System.Drawing.Size(285, 482);
            this.renderParams.TabIndex = 0;
            this.renderParams.Text = "Renderer Parameters";
            this.renderParams.UseVisualStyleBackColor = true;
            // 
            // FOVLabel
            // 
            this.FOVLabel.AutoSize = true;
            this.FOVLabel.Location = new System.Drawing.Point(21, 29);
            this.FOVLabel.Name = "FOVLabel";
            this.FOVLabel.Size = new System.Drawing.Size(28, 13);
            this.FOVLabel.TabIndex = 5;
            this.FOVLabel.Text = "FOV";
            // 
            // FOVTrackBar
            // 
            this.FOVTrackBar.Location = new System.Drawing.Point(61, 28);
            this.FOVTrackBar.Maximum = 300;
            this.FOVTrackBar.Name = "FOVTrackBar";
            this.FOVTrackBar.Size = new System.Drawing.Size(104, 45);
            this.FOVTrackBar.TabIndex = 4;
            this.FOVTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.FOVTrackBar.Value = 100;
            this.FOVTrackBar.Scroll += new System.EventHandler(this.FOVTrackBar_Scroll);
            // 
            // boundingBoxCheckBox
            // 
            this.boundingBoxCheckBox.AutoSize = true;
            this.boundingBoxCheckBox.Location = new System.Drawing.Point(24, 80);
            this.boundingBoxCheckBox.Name = "boundingBoxCheckBox";
            this.boundingBoxCheckBox.Size = new System.Drawing.Size(120, 17);
            this.boundingBoxCheckBox.TabIndex = 0;
            this.boundingBoxCheckBox.Text = "Show bounding box";
            this.boundingBoxCheckBox.UseVisualStyleBackColor = true;
            this.boundingBoxCheckBox.CheckedChanged += new System.EventHandler(this.boundingBoxCheckBox_CheckedChanged);
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
            this.skyParams.Size = new System.Drawing.Size(285, 482);
            this.skyParams.TabIndex = 1;
            this.skyParams.Text = "Sky Dome";
            this.skyParams.UseVisualStyleBackColor = true;
            // 
            // exposureTrackBar
            // 
            this.exposureTrackBar.Location = new System.Drawing.Point(73, 262);
            this.exposureTrackBar.Maximum = 500;
            this.exposureTrackBar.Name = "exposureTrackBar";
            this.exposureTrackBar.Size = new System.Drawing.Size(144, 45);
            this.exposureTrackBar.TabIndex = 17;
            this.exposureTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.exposureTrackBar.Value = 70;
            this.exposureTrackBar.Scroll += new System.EventHandler(this.exposureTrackBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 262);
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
            this.sunGroupBox.Size = new System.Drawing.Size(200, 153);
            this.sunGroupBox.TabIndex = 12;
            this.sunGroupBox.TabStop = false;
            this.sunGroupBox.Text = "Sun";
            // 
            // moveTrackBar
            // 
            this.moveTrackBar.Location = new System.Drawing.Point(49, 108);
            this.moveTrackBar.Maximum = 99;
            this.moveTrackBar.Minimum = 1;
            this.moveTrackBar.Name = "moveTrackBar";
            this.moveTrackBar.Size = new System.Drawing.Size(104, 45);
            this.moveTrackBar.TabIndex = 15;
            this.moveTrackBar.TickFrequency = 10;
            this.moveTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.moveTrackBar.Value = 1;
            this.moveTrackBar.Scroll += new System.EventHandler(this.moveTrackBar_Scroll);
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
            this.turbidityTrackBar.Location = new System.Drawing.Point(73, 230);
            this.turbidityTrackBar.Maximum = 800;
            this.turbidityTrackBar.Name = "turbidityTrackBar";
            this.turbidityTrackBar.Size = new System.Drawing.Size(144, 45);
            this.turbidityTrackBar.TabIndex = 15;
            this.turbidityTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.turbidityTrackBar.Value = 320;
            this.turbidityTrackBar.Scroll += new System.EventHandler(this.turbidityTrackBar_Scroll);
            // 
            // turbidityLabel
            // 
            this.turbidityLabel.AutoSize = true;
            this.turbidityLabel.Location = new System.Drawing.Point(20, 230);
            this.turbidityLabel.Name = "turbidityLabel";
            this.turbidityLabel.Size = new System.Drawing.Size(47, 13);
            this.turbidityLabel.TabIndex = 14;
            this.turbidityLabel.Text = "Turbidity";
            // 
            // cloudsShadingParams
            // 
            this.cloudsShadingParams.Controls.Add(this.hardnessTB);
            this.cloudsShadingParams.Controls.Add(this.label12);
            this.cloudsShadingParams.Controls.Add(this.groupBox2);
            this.cloudsShadingParams.Controls.Add(this.groupBox1);
            this.cloudsShadingParams.Location = new System.Drawing.Point(4, 25);
            this.cloudsShadingParams.Name = "cloudsShadingParams";
            this.cloudsShadingParams.Size = new System.Drawing.Size(285, 482);
            this.cloudsShadingParams.TabIndex = 2;
            this.cloudsShadingParams.Text = "Clouds Shading";
            this.cloudsShadingParams.UseVisualStyleBackColor = true;
            // 
            // hardnessTB
            // 
            this.hardnessTB.Location = new System.Drawing.Point(79, 399);
            this.hardnessTB.Maximum = 500;
            this.hardnessTB.Name = "hardnessTB";
            this.hardnessTB.Size = new System.Drawing.Size(140, 45);
            this.hardnessTB.TabIndex = 11;
            this.hardnessTB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.hardnessTB.Value = 50;
            this.hardnessTB.Scroll += new System.EventHandler(this.hardnessTB_Scroll);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(24, 399);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Hardness";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.amplitudeTB);
            this.groupBox2.Controls.Add(this.frequencyTB);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.distortionBypassCheckbox);
            this.groupBox2.Location = new System.Drawing.Point(14, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 107);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Distortion";
            // 
            // amplitudeTB
            // 
            this.amplitudeTB.Location = new System.Drawing.Point(65, 75);
            this.amplitudeTB.Maximum = 200;
            this.amplitudeTB.Name = "amplitudeTB";
            this.amplitudeTB.Size = new System.Drawing.Size(140, 45);
            this.amplitudeTB.TabIndex = 10;
            this.amplitudeTB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.amplitudeTB.Value = 25;
            this.amplitudeTB.Scroll += new System.EventHandler(this.amplitudeTB_Scroll);
            // 
            // frequencyTB
            // 
            this.frequencyTB.Location = new System.Drawing.Point(65, 49);
            this.frequencyTB.Maximum = 100;
            this.frequencyTB.Name = "frequencyTB";
            this.frequencyTB.Size = new System.Drawing.Size(140, 45);
            this.frequencyTB.TabIndex = 9;
            this.frequencyTB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.frequencyTB.Value = 15;
            this.frequencyTB.Scroll += new System.EventHandler(this.frequencyTB_Scroll);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Amplitude";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Frequency";
            // 
            // distortionBypassCheckbox
            // 
            this.distortionBypassCheckbox.AutoSize = true;
            this.distortionBypassCheckbox.Location = new System.Drawing.Point(14, 20);
            this.distortionBypassCheckbox.Name = "distortionBypassCheckbox";
            this.distortionBypassCheckbox.Size = new System.Drawing.Size(60, 17);
            this.distortionBypassCheckbox.TabIndex = 0;
            this.distortionBypassCheckbox.Text = "Bypass";
            this.distortionBypassCheckbox.UseVisualStyleBackColor = true;
            this.distortionBypassCheckbox.CheckedChanged += new System.EventHandler(this.distortionBypassCheckbox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.directionalExpTB);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.constantTB);
            this.groupBox1.Controls.Add(this.directionalMaxTB);
            this.groupBox1.Controls.Add(this.directionalMinTB);
            this.groupBox1.Controls.Add(this.scatteredMaxTB);
            this.groupBox1.Controls.Add(this.scatteredMinTB);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(14, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lighting";
            // 
            // directionalExpTB
            // 
            this.directionalExpTB.Location = new System.Drawing.Point(67, 160);
            this.directionalExpTB.Maximum = 100;
            this.directionalExpTB.Name = "directionalExpTB";
            this.directionalExpTB.Size = new System.Drawing.Size(140, 45);
            this.directionalExpTB.TabIndex = 13;
            this.directionalExpTB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.directionalExpTB.Value = 30;
            this.directionalExpTB.Scroll += new System.EventHandler(this.directionalExpTB_Scroll);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 160);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "exponent";
            // 
            // constantTB
            // 
            this.constantTB.Location = new System.Drawing.Point(65, 206);
            this.constantTB.Maximum = 100;
            this.constantTB.Name = "constantTB";
            this.constantTB.Size = new System.Drawing.Size(140, 45);
            this.constantTB.TabIndex = 11;
            this.constantTB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.constantTB.Value = 7;
            this.constantTB.Scroll += new System.EventHandler(this.constantTB_Scroll);
            // 
            // directionalMaxTB
            // 
            this.directionalMaxTB.Location = new System.Drawing.Point(66, 135);
            this.directionalMaxTB.Maximum = 100;
            this.directionalMaxTB.Name = "directionalMaxTB";
            this.directionalMaxTB.Size = new System.Drawing.Size(140, 45);
            this.directionalMaxTB.TabIndex = 10;
            this.directionalMaxTB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.directionalMaxTB.Value = 75;
            this.directionalMaxTB.Scroll += new System.EventHandler(this.directionalMaxTB_Scroll);
            // 
            // directionalMinTB
            // 
            this.directionalMinTB.Location = new System.Drawing.Point(66, 112);
            this.directionalMinTB.Maximum = 100;
            this.directionalMinTB.Name = "directionalMinTB";
            this.directionalMinTB.Size = new System.Drawing.Size(140, 45);
            this.directionalMinTB.TabIndex = 9;
            this.directionalMinTB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.directionalMinTB.Value = 40;
            this.directionalMinTB.Scroll += new System.EventHandler(this.directionalMinTB_Scroll);
            // 
            // scatteredMaxTB
            // 
            this.scatteredMaxTB.Location = new System.Drawing.Point(66, 56);
            this.scatteredMaxTB.Maximum = 100;
            this.scatteredMaxTB.Name = "scatteredMaxTB";
            this.scatteredMaxTB.Size = new System.Drawing.Size(140, 45);
            this.scatteredMaxTB.TabIndex = 8;
            this.scatteredMaxTB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.scatteredMaxTB.Value = 55;
            this.scatteredMaxTB.Scroll += new System.EventHandler(this.scatteredMaxTB_Scroll);
            // 
            // scatteredMinTB
            // 
            this.scatteredMinTB.Location = new System.Drawing.Point(66, 33);
            this.scatteredMinTB.Maximum = 100;
            this.scatteredMinTB.Name = "scatteredMinTB";
            this.scatteredMinTB.Size = new System.Drawing.Size(140, 45);
            this.scatteredMinTB.TabIndex = 7;
            this.scatteredMinTB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.scatteredMinTB.Value = 15;
            this.scatteredMinTB.Scroll += new System.EventHandler(this.scatteredMinTB_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(14, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Constant";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "max";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(6, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Directional";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Scattered";
            // 
            // cloudsLabel
            // 
            this.cloudsLabel.AutoSize = true;
            this.cloudsLabel.Location = new System.Drawing.Point(24, 157);
            this.cloudsLabel.Name = "cloudsLabel";
            this.cloudsLabel.Size = new System.Drawing.Size(39, 13);
            this.cloudsLabel.TabIndex = 6;
            this.cloudsLabel.Text = "Clouds";
            // 
            // cloudsTrackBar
            // 
            this.cloudsTrackBar.Location = new System.Drawing.Point(103, 157);
            this.cloudsTrackBar.Minimum = 1;
            this.cloudsTrackBar.Name = "cloudsTrackBar";
            this.cloudsTrackBar.Size = new System.Drawing.Size(104, 45);
            this.cloudsTrackBar.TabIndex = 7;
            this.cloudsTrackBar.Value = 1;
            this.cloudsTrackBar.Scroll += new System.EventHandler(this.cloudsTrackBar_Scroll);
            // 
            // rendererControl
            // 
            this.rendererControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rendererControl.Location = new System.Drawing.Point(0, 0);
            this.rendererControl.Name = "rendererControl";
            this.rendererControl.Size = new System.Drawing.Size(594, 565);
            this.rendererControl.TabIndex = 0;
            this.rendererControl.Text = "rendererControl";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 565);
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
            ((System.ComponentModel.ISupportInitialize)(this.FOVTrackBar)).EndInit();
            this.skyParams.ResumeLayout(false);
            this.skyParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.exposureTrackBar)).EndInit();
            this.sunGroupBox.ResumeLayout(false);
            this.sunGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moveTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phiTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thetaTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turbidityTrackBar)).EndInit();
            this.cloudsShadingParams.ResumeLayout(false);
            this.cloudsShadingParams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hardnessTB)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amplitudeTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencyTB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.directionalExpTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.constantTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionalMaxTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionalMinTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scatteredMaxTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scatteredMinTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudsTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private WinFormsGraphicsDevice.RendererControl rendererControl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage skyParams;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage renderParams;
        private System.Windows.Forms.Label FOVLabel;
        private System.Windows.Forms.TrackBar FOVTrackBar;
        private System.Windows.Forms.CheckBox boundingBoxCheckBox;
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
		private System.Windows.Forms.TabPage cloudsShadingParams;
        private System.Windows.Forms.TrackBar hardnessTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TrackBar amplitudeTB;
        private System.Windows.Forms.TrackBar frequencyTB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox distortionBypassCheckbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TrackBar constantTB;
        private System.Windows.Forms.TrackBar directionalMaxTB;
        private System.Windows.Forms.TrackBar directionalMinTB;
        private System.Windows.Forms.TrackBar scatteredMaxTB;
        private System.Windows.Forms.TrackBar scatteredMinTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar directionalExpTB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TrackBar cloudsTrackBar;
        private System.Windows.Forms.Label cloudsLabel;

    }
}
