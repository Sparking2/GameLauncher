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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boxResolution = new System.Windows.Forms.ComboBox();
            this.EnableMotionBlur = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EnableAmbientOcclusion = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EnableAmbientOcclusion);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.EnableMotionBlur);
            this.groupBox1.Controls.Add(this.boxResolution);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(305, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video Settings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resolution:";
            // 
            // boxResolution
            // 
            this.boxResolution.FormattingEnabled = true;
            this.boxResolution.Items.AddRange(new object[] {
            "800x600",
            "1024x768",
            "1280x720",
            "1920x1080"});
            this.boxResolution.Location = new System.Drawing.Point(178, 32);
            this.boxResolution.Name = "boxResolution";
            this.boxResolution.Size = new System.Drawing.Size(121, 21);
            this.boxResolution.TabIndex = 1;
            // 
            // EnableMotionBlur
            // 
            this.EnableMotionBlur.AutoSize = true;
            this.EnableMotionBlur.Location = new System.Drawing.Point(178, 60);
            this.EnableMotionBlur.Name = "EnableMotionBlur";
            this.EnableMotionBlur.Size = new System.Drawing.Size(15, 14);
            this.EnableMotionBlur.TabIndex = 2;
            this.EnableMotionBlur.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enable Motion Blur:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enable Ambient Occlusion:";
            // 
            // EnableAmbientOcclusion
            // 
            this.EnableAmbientOcclusion.AutoSize = true;
            this.EnableAmbientOcclusion.Location = new System.Drawing.Point(178, 83);
            this.EnableAmbientOcclusion.Name = "EnableAmbientOcclusion";
            this.EnableAmbientOcclusion.Size = new System.Drawing.Size(15, 14);
            this.EnableAmbientOcclusion.TabIndex = 5;
            this.EnableAmbientOcclusion.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(13, 132);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 38);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(194, 132);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 38);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 180);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox boxResolution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox EnableMotionBlur;
        private System.Windows.Forms.CheckBox EnableAmbientOcclusion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}