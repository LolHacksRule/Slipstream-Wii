﻿namespace SlipstreamWii
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openMKWFilesToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            extractFileToolStripMenuItem = new ToolStripMenuItem();
            buildFileToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            decodebmgToolStripMenuItem = new ToolStripMenuItem();
            encodebmgToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            simpleSamplingToolStripMenuItem = new ToolStripMenuItem();
            complexSamplingToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            setTargetLanguageToolStripMenuItem = new ToolStripMenuItem();
            targetLanguageBox = new ToolStripTextBox();
            targetCharBox = new ComboBox();
            label1 = new Label();
            createSampleBtn = new Button();
            toolTip1 = new ToolTip(components);
            createFilesBtn = new Button();
            globalProgress = new ProgressBar();
            progressLabel = new Label();
            vehicleGeneratorList = new CheckedListBox();
            label2 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(32, 32, 32);
            menuStrip1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ForeColor = Color.FromArgb(192, 192, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, optionsToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(336, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openMKWFilesToolStripMenuItem, toolStripSeparator2, extractFileToolStripMenuItem, buildFileToolStripMenuItem, toolStripSeparator1, decodebmgToolStripMenuItem, encodebmgToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openMKWFilesToolStripMenuItem
            // 
            openMKWFilesToolStripMenuItem.Name = "openMKWFilesToolStripMenuItem";
            openMKWFilesToolStripMenuItem.Size = new Size(211, 22);
            openMKWFilesToolStripMenuItem.Text = "Set MKW Files Folder Path";
            openMKWFilesToolStripMenuItem.Click += openMKWFilesToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(208, 6);
            // 
            // extractFileToolStripMenuItem
            // 
            extractFileToolStripMenuItem.Name = "extractFileToolStripMenuItem";
            extractFileToolStripMenuItem.Size = new Size(211, 22);
            extractFileToolStripMenuItem.Text = "Extract File (.szs/.brres)";
            extractFileToolStripMenuItem.Click += extractFileToolStripMenuItem_Click;
            // 
            // buildFileToolStripMenuItem
            // 
            buildFileToolStripMenuItem.Name = "buildFileToolStripMenuItem";
            buildFileToolStripMenuItem.Size = new Size(211, 22);
            buildFileToolStripMenuItem.Text = "Build File (.szs/.brres)";
            buildFileToolStripMenuItem.Click += buildFileToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(208, 6);
            // 
            // decodebmgToolStripMenuItem
            // 
            decodebmgToolStripMenuItem.Name = "decodebmgToolStripMenuItem";
            decodebmgToolStripMenuItem.Size = new Size(211, 22);
            decodebmgToolStripMenuItem.Text = "Decode (.bmg)";
            decodebmgToolStripMenuItem.Click += decodeBmgToolStripMenuItem_Click;
            // 
            // encodebmgToolStripMenuItem
            // 
            encodebmgToolStripMenuItem.Name = "encodebmgToolStripMenuItem";
            encodebmgToolStripMenuItem.Size = new Size(211, 22);
            encodebmgToolStripMenuItem.Text = "Encode (.bmg)";
            encodebmgToolStripMenuItem.Click += encodeBmgToolStripMenuItem_Click;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { simpleSamplingToolStripMenuItem, complexSamplingToolStripMenuItem, toolStripSeparator3, setTargetLanguageToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(61, 20);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // simpleSamplingToolStripMenuItem
            // 
            simpleSamplingToolStripMenuItem.Name = "simpleSamplingToolStripMenuItem";
            simpleSamplingToolStripMenuItem.Size = new Size(195, 22);
            simpleSamplingToolStripMenuItem.Text = "Simple Sampling";
            simpleSamplingToolStripMenuItem.Click += changeSamplingToolStripMenuItem_Click;
            // 
            // complexSamplingToolStripMenuItem
            // 
            complexSamplingToolStripMenuItem.Name = "complexSamplingToolStripMenuItem";
            complexSamplingToolStripMenuItem.Size = new Size(195, 22);
            complexSamplingToolStripMenuItem.Text = "Complex Sampling";
            complexSamplingToolStripMenuItem.Click += changeSamplingToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(192, 6);
            // 
            // setTargetLanguageToolStripMenuItem
            // 
            setTargetLanguageToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { targetLanguageBox });
            setTargetLanguageToolStripMenuItem.Name = "setTargetLanguageToolStripMenuItem";
            setTargetLanguageToolStripMenuItem.Size = new Size(195, 22);
            setTargetLanguageToolStripMenuItem.Text = "Set UI Target Language";
            // 
            // targetLanguageBox
            // 
            targetLanguageBox.Name = "targetLanguageBox";
            targetLanguageBox.Size = new Size(30, 23);
            targetLanguageBox.Text = "U";
            // 
            // targetCharBox
            // 
            targetCharBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            targetCharBox.FormattingEnabled = true;
            targetCharBox.Location = new Point(119, 40);
            targetCharBox.Margin = new Padding(3, 2, 3, 2);
            targetCharBox.Name = "targetCharBox";
            targetCharBox.Size = new Size(205, 23);
            targetCharBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.FromArgb(192, 192, 0);
            label1.Location = new Point(10, 42);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 3;
            label1.Text = "Target Character";
            // 
            // createSampleBtn
            // 
            createSampleBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            createSampleBtn.BackColor = Color.FromArgb(32, 32, 32);
            createSampleBtn.ForeColor = Color.FromArgb(192, 192, 0);
            createSampleBtn.Location = new Point(10, 65);
            createSampleBtn.Margin = new Padding(3, 2, 3, 2);
            createSampleBtn.Name = "createSampleBtn";
            createSampleBtn.Size = new Size(313, 28);
            createSampleBtn.TabIndex = 4;
            createSampleBtn.Text = "Create Sample SZS";
            toolTip1.SetToolTip(createSampleBtn, "Use a sample file to replace\r\na target character's models.");
            createSampleBtn.UseVisualStyleBackColor = false;
            createSampleBtn.Click += createSampleBtn_Click;
            // 
            // createFilesBtn
            // 
            createFilesBtn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            createFilesBtn.BackColor = Color.FromArgb(32, 32, 32);
            createFilesBtn.ForeColor = Color.FromArgb(192, 192, 0);
            createFilesBtn.Location = new Point(10, 98);
            createFilesBtn.Margin = new Padding(3, 2, 3, 2);
            createFilesBtn.Name = "createFilesBtn";
            createFilesBtn.Size = new Size(313, 28);
            createFilesBtn.TabIndex = 7;
            createFilesBtn.Text = "Create Files From Sample";
            toolTip1.SetToolTip(createFilesBtn, "Use a sample file to replace\r\na target character's models.");
            createFilesBtn.UseVisualStyleBackColor = false;
            createFilesBtn.Click += createFilesBtn_Click;
            // 
            // globalProgress
            // 
            globalProgress.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            globalProgress.Location = new Point(10, 342);
            globalProgress.Margin = new Padding(3, 2, 3, 2);
            globalProgress.Name = "globalProgress";
            globalProgress.Size = new Size(313, 22);
            globalProgress.TabIndex = 5;
            // 
            // progressLabel
            // 
            progressLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressLabel.BackColor = Color.Transparent;
            progressLabel.ForeColor = Color.FromArgb(192, 192, 0);
            progressLabel.Location = new Point(10, 324);
            progressLabel.MinimumSize = new Size(313, 0);
            progressLabel.Name = "progressLabel";
            progressLabel.Size = new Size(313, 15);
            progressLabel.TabIndex = 6;
            progressLabel.Text = "Progress Bar Text";
            progressLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // vehicleGeneratorList
            // 
            vehicleGeneratorList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            vehicleGeneratorList.BackColor = Color.FromArgb(32, 32, 32);
            vehicleGeneratorList.CheckOnClick = true;
            vehicleGeneratorList.ForeColor = Color.FromArgb(192, 192, 0);
            vehicleGeneratorList.FormattingEnabled = true;
            vehicleGeneratorList.Location = new Point(10, 149);
            vehicleGeneratorList.Margin = new Padding(3, 2, 3, 2);
            vehicleGeneratorList.Name = "vehicleGeneratorList";
            vehicleGeneratorList.Size = new Size(314, 148);
            vehicleGeneratorList.TabIndex = 8;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.FromArgb(192, 192, 0);
            label2.Location = new Point(10, 129);
            label2.MinimumSize = new Size(313, 0);
            label2.Name = "label2";
            label2.Size = new Size(313, 15);
            label2.TabIndex = 9;
            label2.Text = "Settings";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(336, 384);
            Controls.Add(label2);
            Controls.Add(vehicleGeneratorList);
            Controls.Add(createFilesBtn);
            Controls.Add(progressLabel);
            Controls.Add(globalProgress);
            Controls.Add(createSampleBtn);
            Controls.Add(label1);
            Controls.Add(targetCharBox);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(352, 385);
            Name = "Form1";
            Text = "Slipstream Wii";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ComboBox targetCharBox;
        private ToolStripMenuItem openMKWFilesToolStripMenuItem;
        private Label label1;
        private Button createSampleBtn;
        private ToolTip toolTip1;
        private ProgressBar globalProgress;
        private Label progressLabel;
        private Button createFilesBtn;
        private ToolStripMenuItem extractFileToolStripMenuItem;
        private ToolStripMenuItem buildFileToolStripMenuItem;
        private CheckedListBox vehicleGeneratorList;
        private Label label2;
        private ToolStripMenuItem sampleHDModelFromToolStripMenuItem;
        private ToolStripMenuItem kartToolStripMenuItem;
        private ToolStripMenuItem bikeToolStripMenuItem;
        private ToolStripMenuItem sportBikeToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem complexSamplesToolStripMenuItem;
        private ToolStripMenuItem allToolStripMenuItem;
        private ToolStripMenuItem simpleSamplingToolStripMenuItem;
        private ToolStripMenuItem complexSamplingToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem decodebmgToolStripMenuItem;
        private ToolStripMenuItem encodebmgToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem setTargetLanguageToolStripMenuItem;
        private ToolStripTextBox targetLanguageBox;
        private ToolStripMenuItem vehicleListToolStripMenuItem;
    }
}