namespace Launcher
{
    partial class SettingsForm
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
            this.groupScreenSettings = new System.Windows.Forms.GroupBox();
            this.comboScreenMode = new System.Windows.Forms.ComboBox();
            this.comboFPS = new System.Windows.Forms.ComboBox();
            this.boxDynamicResolution = new System.Windows.Forms.CheckBox();
            this.boxVSync = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.boxResolution = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxQualityPresets = new System.Windows.Forms.GroupBox();
            this.groupQualitySettings = new System.Windows.Forms.GroupBox();
            this.comboFoliage = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboEffects = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboTexture = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboShadow = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboPostProcessing = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboAA = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboViewDistance = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioQPLow = new System.Windows.Forms.RadioButton();
            this.radioQPMedium = new System.Windows.Forms.RadioButton();
            this.radioQPHigh = new System.Windows.Forms.RadioButton();
            this.radioQPUltra = new System.Windows.Forms.RadioButton();
            this.radioQPCustom = new System.Windows.Forms.RadioButton();
            this.groupScreenSettings.SuspendLayout();
            this.groupBoxQualityPresets.SuspendLayout();
            this.groupQualitySettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupScreenSettings
            // 
            this.groupScreenSettings.Controls.Add(this.comboScreenMode);
            this.groupScreenSettings.Controls.Add(this.comboFPS);
            this.groupScreenSettings.Controls.Add(this.boxDynamicResolution);
            this.groupScreenSettings.Controls.Add(this.boxVSync);
            this.groupScreenSettings.Controls.Add(this.label12);
            this.groupScreenSettings.Controls.Add(this.label11);
            this.groupScreenSettings.Controls.Add(this.label10);
            this.groupScreenSettings.Controls.Add(this.label9);
            this.groupScreenSettings.Controls.Add(this.boxResolution);
            this.groupScreenSettings.Controls.Add(this.label1);
            this.groupScreenSettings.Location = new System.Drawing.Point(12, 12);
            this.groupScreenSettings.Name = "groupScreenSettings";
            this.groupScreenSettings.Size = new System.Drawing.Size(305, 136);
            this.groupScreenSettings.TabIndex = 0;
            this.groupScreenSettings.TabStop = false;
            this.groupScreenSettings.Text = "Video Settings";
            // 
            // comboScreenMode
            // 
            this.comboScreenMode.FormattingEnabled = true;
            this.comboScreenMode.Items.AddRange(new object[] {
            "Fullscreen",
            "Windowed Fullscreen",
            "Windowed"});
            this.comboScreenMode.Location = new System.Drawing.Point(178, 109);
            this.comboScreenMode.Name = "comboScreenMode";
            this.comboScreenMode.Size = new System.Drawing.Size(121, 21);
            this.comboScreenMode.TabIndex = 5;
            // 
            // comboFPS
            // 
            this.comboFPS.FormattingEnabled = true;
            this.comboFPS.Items.AddRange(new object[] {
            "30",
            "60",
            "120",
            "144",
            "240"});
            this.comboFPS.Location = new System.Drawing.Point(178, 82);
            this.comboFPS.Name = "comboFPS";
            this.comboFPS.Size = new System.Drawing.Size(121, 21);
            this.comboFPS.TabIndex = 4;
            // 
            // boxDynamicResolution
            // 
            this.boxDynamicResolution.AutoSize = true;
            this.boxDynamicResolution.Location = new System.Drawing.Point(178, 61);
            this.boxDynamicResolution.Name = "boxDynamicResolution";
            this.boxDynamicResolution.Size = new System.Drawing.Size(15, 14);
            this.boxDynamicResolution.TabIndex = 3;
            this.boxDynamicResolution.UseVisualStyleBackColor = true;
            // 
            // boxVSync
            // 
            this.boxVSync.AutoSize = true;
            this.boxVSync.Location = new System.Drawing.Point(178, 41);
            this.boxVSync.Name = "boxVSync";
            this.boxVSync.Size = new System.Drawing.Size(15, 14);
            this.boxVSync.TabIndex = 2;
            this.boxVSync.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Screen Mode:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "FPS Limit:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Dynamic Resolution:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "V-Sync:";
            // 
            // boxResolution
            // 
            this.boxResolution.FormattingEnabled = true;
            this.boxResolution.Items.AddRange(new object[] {
            "800x600",
            "1024x768",
            "1280x720",
            "1920x1080"});
            this.boxResolution.Location = new System.Drawing.Point(178, 14);
            this.boxResolution.Name = "boxResolution";
            this.boxResolution.Size = new System.Drawing.Size(121, 21);
            this.boxResolution.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resolution:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 471);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(194, 471);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 38);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBoxQualityPresets
            // 
            this.groupBoxQualityPresets.Controls.Add(this.radioQPCustom);
            this.groupBoxQualityPresets.Controls.Add(this.radioQPUltra);
            this.groupBoxQualityPresets.Controls.Add(this.radioQPHigh);
            this.groupBoxQualityPresets.Controls.Add(this.radioQPMedium);
            this.groupBoxQualityPresets.Controls.Add(this.radioQPLow);
            this.groupBoxQualityPresets.Location = new System.Drawing.Point(12, 154);
            this.groupBoxQualityPresets.Name = "groupBoxQualityPresets";
            this.groupBoxQualityPresets.Size = new System.Drawing.Size(305, 100);
            this.groupBoxQualityPresets.TabIndex = 3;
            this.groupBoxQualityPresets.TabStop = false;
            this.groupBoxQualityPresets.Text = "Quality Presets";
            // 
            // groupQualitySettings
            // 
            this.groupQualitySettings.Controls.Add(this.comboFoliage);
            this.groupQualitySettings.Controls.Add(this.label3);
            this.groupQualitySettings.Controls.Add(this.comboEffects);
            this.groupQualitySettings.Controls.Add(this.label2);
            this.groupQualitySettings.Controls.Add(this.comboTexture);
            this.groupQualitySettings.Controls.Add(this.label8);
            this.groupQualitySettings.Controls.Add(this.comboShadow);
            this.groupQualitySettings.Controls.Add(this.label7);
            this.groupQualitySettings.Controls.Add(this.comboPostProcessing);
            this.groupQualitySettings.Controls.Add(this.label6);
            this.groupQualitySettings.Controls.Add(this.comboAA);
            this.groupQualitySettings.Controls.Add(this.label5);
            this.groupQualitySettings.Controls.Add(this.comboViewDistance);
            this.groupQualitySettings.Controls.Add(this.label4);
            this.groupQualitySettings.Location = new System.Drawing.Point(12, 260);
            this.groupQualitySettings.Name = "groupQualitySettings";
            this.groupQualitySettings.Size = new System.Drawing.Size(305, 205);
            this.groupQualitySettings.TabIndex = 4;
            this.groupQualitySettings.TabStop = false;
            this.groupQualitySettings.Text = "Quality Settings";
            // 
            // comboFoliage
            // 
            this.comboFoliage.FormattingEnabled = true;
            this.comboFoliage.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Ultra"});
            this.comboFoliage.Location = new System.Drawing.Point(178, 176);
            this.comboFoliage.Name = "comboFoliage";
            this.comboFoliage.Size = new System.Drawing.Size(121, 21);
            this.comboFoliage.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Foliage Quality:";
            // 
            // comboEffects
            // 
            this.comboEffects.FormattingEnabled = true;
            this.comboEffects.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Ultra"});
            this.comboEffects.Location = new System.Drawing.Point(178, 149);
            this.comboEffects.Name = "comboEffects";
            this.comboEffects.Size = new System.Drawing.Size(121, 21);
            this.comboEffects.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Effects Quality:";
            // 
            // comboTexture
            // 
            this.comboTexture.FormattingEnabled = true;
            this.comboTexture.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Ultra"});
            this.comboTexture.Location = new System.Drawing.Point(178, 122);
            this.comboTexture.Name = "comboTexture";
            this.comboTexture.Size = new System.Drawing.Size(121, 21);
            this.comboTexture.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Texture Quality:";
            // 
            // comboShadow
            // 
            this.comboShadow.FormattingEnabled = true;
            this.comboShadow.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Ultra"});
            this.comboShadow.Location = new System.Drawing.Point(178, 95);
            this.comboShadow.Name = "comboShadow";
            this.comboShadow.Size = new System.Drawing.Size(121, 21);
            this.comboShadow.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Shadow Quality:";
            // 
            // comboPostProcessing
            // 
            this.comboPostProcessing.FormattingEnabled = true;
            this.comboPostProcessing.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Ultra"});
            this.comboPostProcessing.Location = new System.Drawing.Point(178, 68);
            this.comboPostProcessing.Name = "comboPostProcessing";
            this.comboPostProcessing.Size = new System.Drawing.Size(121, 21);
            this.comboPostProcessing.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Post-Processing:";
            // 
            // comboAA
            // 
            this.comboAA.FormattingEnabled = true;
            this.comboAA.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Ultra"});
            this.comboAA.Location = new System.Drawing.Point(178, 41);
            this.comboAA.Name = "comboAA";
            this.comboAA.Size = new System.Drawing.Size(121, 21);
            this.comboAA.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Anti-Aliasing:";
            // 
            // comboViewDistance
            // 
            this.comboViewDistance.FormattingEnabled = true;
            this.comboViewDistance.Items.AddRange(new object[] {
            "Near",
            "Medium",
            "Far",
            "Epic"});
            this.comboViewDistance.Location = new System.Drawing.Point(178, 14);
            this.comboViewDistance.Name = "comboViewDistance";
            this.comboViewDistance.Size = new System.Drawing.Size(121, 21);
            this.comboViewDistance.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "View Distance:";
            // 
            // radioQPLow
            // 
            this.radioQPLow.AutoSize = true;
            this.radioQPLow.Location = new System.Drawing.Point(6, 20);
            this.radioQPLow.Name = "radioQPLow";
            this.radioQPLow.Size = new System.Drawing.Size(91, 17);
            this.radioQPLow.TabIndex = 6;
            this.radioQPLow.TabStop = true;
            this.radioQPLow.Text = "Low Quality";
            this.radioQPLow.UseVisualStyleBackColor = true;
            // 
            // radioQPMedium
            // 
            this.radioQPMedium.AutoSize = true;
            this.radioQPMedium.Location = new System.Drawing.Point(6, 43);
            this.radioQPMedium.Name = "radioQPMedium";
            this.radioQPMedium.Size = new System.Drawing.Size(113, 17);
            this.radioQPMedium.TabIndex = 7;
            this.radioQPMedium.TabStop = true;
            this.radioQPMedium.Text = "Medium Quality";
            this.radioQPMedium.UseVisualStyleBackColor = true;
            // 
            // radioQPHigh
            // 
            this.radioQPHigh.AutoSize = true;
            this.radioQPHigh.Location = new System.Drawing.Point(6, 66);
            this.radioQPHigh.Name = "radioQPHigh";
            this.radioQPHigh.Size = new System.Drawing.Size(94, 17);
            this.radioQPHigh.TabIndex = 8;
            this.radioQPHigh.TabStop = true;
            this.radioQPHigh.Text = "High Quality";
            this.radioQPHigh.UseVisualStyleBackColor = true;
            // 
            // radioQPUltra
            // 
            this.radioQPUltra.AutoSize = true;
            this.radioQPUltra.Location = new System.Drawing.Point(178, 20);
            this.radioQPUltra.Name = "radioQPUltra";
            this.radioQPUltra.Size = new System.Drawing.Size(96, 17);
            this.radioQPUltra.TabIndex = 9;
            this.radioQPUltra.TabStop = true;
            this.radioQPUltra.Text = "Ultra Quality";
            this.radioQPUltra.UseVisualStyleBackColor = true;
            // 
            // radioQPCustom
            // 
            this.radioQPCustom.AutoSize = true;
            this.radioQPCustom.Location = new System.Drawing.Point(178, 43);
            this.radioQPCustom.Name = "radioQPCustom";
            this.radioQPCustom.Size = new System.Drawing.Size(113, 17);
            this.radioQPCustom.TabIndex = 10;
            this.radioQPCustom.TabStop = true;
            this.radioQPCustom.Text = "Custom Quality";
            this.radioQPCustom.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 522);
            this.Controls.Add(this.groupQualitySettings);
            this.Controls.Add(this.groupBoxQualityPresets);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupScreenSettings);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupScreenSettings.ResumeLayout(false);
            this.groupScreenSettings.PerformLayout();
            this.groupBoxQualityPresets.ResumeLayout(false);
            this.groupBoxQualityPresets.PerformLayout();
            this.groupQualitySettings.ResumeLayout(false);
            this.groupQualitySettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupScreenSettings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxResolution;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox boxDynamicResolution;
        private System.Windows.Forms.CheckBox boxVSync;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboScreenMode;
        private System.Windows.Forms.ComboBox comboFPS;
        private System.Windows.Forms.GroupBox groupBoxQualityPresets;
        private System.Windows.Forms.GroupBox groupQualitySettings;
        private System.Windows.Forms.ComboBox comboFoliage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboEffects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboTexture;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboShadow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboPostProcessing;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboAA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboViewDistance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioQPMedium;
        private System.Windows.Forms.RadioButton radioQPLow;
        private System.Windows.Forms.RadioButton radioQPCustom;
        private System.Windows.Forms.RadioButton radioQPUltra;
        private System.Windows.Forms.RadioButton radioQPHigh;
    }
}