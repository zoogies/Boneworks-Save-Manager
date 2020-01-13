namespace BSM
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnPathHelp = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxProfile = new System.Windows.Forms.ComboBox();
            this.btnLoadProfile = new System.Windows.Forms.Button();
            this.btnSaveToProfile = new System.Windows.Forms.Button();
            this.btnProfileHelp = new System.Windows.Forms.Button();
            this.pbSplashImage = new System.Windows.Forms.PictureBox();
            this.btnBrowseBoneworks = new System.Windows.Forms.Button();
            this.btnBrowseBSM = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBrowseHelp = new System.Windows.Forms.Button();
            this.loadTip = new System.Windows.Forms.ToolTip(this.components);
            this.saveTip = new System.Windows.Forms.ToolTip(this.components);
            this.updateTip = new System.Windows.Forms.ToolTip(this.components);
            this.browseBoneworksTip = new System.Windows.Forms.ToolTip(this.components);
            this.browseBSMTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbSplashImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "BONEWORKS Save Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Path to BONEWORKS save data:";
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(12, 68);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(356, 20);
            this.tbPath.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(374, 66);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(57, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.updateTip.SetToolTip(this.btnUpdate, "Will update BSM\'s saved path to your currently entered path");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnPathHelp
            // 
            this.btnPathHelp.Location = new System.Drawing.Point(437, 66);
            this.btnPathHelp.Name = "btnPathHelp";
            this.btnPathHelp.Size = new System.Drawing.Size(22, 23);
            this.btnPathHelp.TabIndex = 4;
            this.btnPathHelp.Text = "?";
            this.btnPathHelp.UseVisualStyleBackColor = true;
            this.btnPathHelp.Click += new System.EventHandler(this.btnPathHelp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Save profile:";
            // 
            // cbxProfile
            // 
            this.cbxProfile.FormattingEnabled = true;
            this.cbxProfile.Items.AddRange(new object[] {
            "personal save",
            "sandbox save"});
            this.cbxProfile.Location = new System.Drawing.Point(12, 110);
            this.cbxProfile.Name = "cbxProfile";
            this.cbxProfile.Size = new System.Drawing.Size(108, 21);
            this.cbxProfile.TabIndex = 6;
            // 
            // btnLoadProfile
            // 
            this.btnLoadProfile.Location = new System.Drawing.Point(126, 108);
            this.btnLoadProfile.Name = "btnLoadProfile";
            this.btnLoadProfile.Size = new System.Drawing.Size(148, 23);
            this.btnLoadProfile.TabIndex = 7;
            this.btnLoadProfile.Text = "Load Profile";
            this.loadTip.SetToolTip(this.btnLoadProfile, "Will load your selected profile into boneworks, overwriting boneworks data");
            this.btnLoadProfile.UseVisualStyleBackColor = true;
            this.btnLoadProfile.Click += new System.EventHandler(this.btnLoadProfile_Click);
            // 
            // btnSaveToProfile
            // 
            this.btnSaveToProfile.Location = new System.Drawing.Point(283, 108);
            this.btnSaveToProfile.Name = "btnSaveToProfile";
            this.btnSaveToProfile.Size = new System.Drawing.Size(148, 23);
            this.btnSaveToProfile.TabIndex = 8;
            this.btnSaveToProfile.Text = "Save To Profile";
            this.saveTip.SetToolTip(this.btnSaveToProfile, "Will download boneworks save data to this profile, overwriting it");
            this.btnSaveToProfile.UseVisualStyleBackColor = true;
            this.btnSaveToProfile.Click += new System.EventHandler(this.btnSaveToProfile_Click);
            // 
            // btnProfileHelp
            // 
            this.btnProfileHelp.Location = new System.Drawing.Point(437, 108);
            this.btnProfileHelp.Name = "btnProfileHelp";
            this.btnProfileHelp.Size = new System.Drawing.Size(22, 23);
            this.btnProfileHelp.TabIndex = 10;
            this.btnProfileHelp.Text = "?";
            this.btnProfileHelp.UseVisualStyleBackColor = true;
            this.btnProfileHelp.Click += new System.EventHandler(this.btnProfileHelp_Click);
            // 
            // pbSplashImage
            // 
            this.pbSplashImage.Location = new System.Drawing.Point(12, 147);
            this.pbSplashImage.Name = "pbSplashImage";
            this.pbSplashImage.Size = new System.Drawing.Size(447, 291);
            this.pbSplashImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSplashImage.TabIndex = 11;
            this.pbSplashImage.TabStop = false;
            // 
            // btnBrowseBoneworks
            // 
            this.btnBrowseBoneworks.Location = new System.Drawing.Point(12, 445);
            this.btnBrowseBoneworks.Name = "btnBrowseBoneworks";
            this.btnBrowseBoneworks.Size = new System.Drawing.Size(200, 23);
            this.btnBrowseBoneworks.TabIndex = 12;
            this.btnBrowseBoneworks.Text = "Browse BONEWORKS Data";
            this.browseBoneworksTip.SetToolTip(this.btnBrowseBoneworks, "Will open your saved boneworks path in file explorer");
            this.btnBrowseBoneworks.UseVisualStyleBackColor = true;
            this.btnBrowseBoneworks.Click += new System.EventHandler(this.btnBrowseBoneworks_Click);
            // 
            // btnBrowseBSM
            // 
            this.btnBrowseBSM.Location = new System.Drawing.Point(256, 445);
            this.btnBrowseBSM.Name = "btnBrowseBSM";
            this.btnBrowseBSM.Size = new System.Drawing.Size(203, 23);
            this.btnBrowseBSM.TabIndex = 13;
            this.btnBrowseBSM.Text = "Browse BSM Data";
            this.browseBSMTip.SetToolTip(this.btnBrowseBSM, "Will open BSM\'s data folder in file explorer");
            this.btnBrowseBSM.UseVisualStyleBackColor = true;
            this.btnBrowseBSM.Click += new System.EventHandler(this.btnBrowseBSM_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 471);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "BSM v1.0 Ryan Zmuda 2020";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(301, 471);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Click here if youre having issues";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnBrowseHelp
            // 
            this.btnBrowseHelp.Location = new System.Drawing.Point(218, 445);
            this.btnBrowseHelp.Name = "btnBrowseHelp";
            this.btnBrowseHelp.Size = new System.Drawing.Size(32, 23);
            this.btnBrowseHelp.TabIndex = 16;
            this.btnBrowseHelp.Text = "?";
            this.btnBrowseHelp.UseVisualStyleBackColor = true;
            this.btnBrowseHelp.Click += new System.EventHandler(this.btnBrowseHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(473, 497);
            this.Controls.Add(this.btnBrowseHelp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBrowseBSM);
            this.Controls.Add(this.btnBrowseBoneworks);
            this.Controls.Add(this.pbSplashImage);
            this.Controls.Add(this.btnProfileHelp);
            this.Controls.Add(this.btnSaveToProfile);
            this.Controls.Add(this.btnLoadProfile);
            this.Controls.Add(this.cbxProfile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPathHelp);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BSM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSplashImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnPathHelp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxProfile;
        private System.Windows.Forms.Button btnLoadProfile;
        private System.Windows.Forms.Button btnSaveToProfile;
        private System.Windows.Forms.Button btnProfileHelp;
        private System.Windows.Forms.PictureBox pbSplashImage;
        private System.Windows.Forms.Button btnBrowseBoneworks;
        private System.Windows.Forms.Button btnBrowseBSM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBrowseHelp;
        private System.Windows.Forms.ToolTip loadTip;
        private System.Windows.Forms.ToolTip saveTip;
        private System.Windows.Forms.ToolTip updateTip;
        private System.Windows.Forms.ToolTip browseBoneworksTip;
        private System.Windows.Forms.ToolTip browseBSMTip;
    }
}

