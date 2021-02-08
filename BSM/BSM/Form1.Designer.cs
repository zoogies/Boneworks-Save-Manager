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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.btnOptions = new System.Windows.Forms.Button();
            this.tbCustomName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreateProfile = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.SavesTxt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boneworks Save Manager";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(5, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Path to BONEWORKS save data:";
            // 
            // tbPath
            // 
            this.tbPath.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbPath.ForeColor = System.Drawing.Color.Yellow;
            this.tbPath.Location = new System.Drawing.Point(8, 124);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(356, 20);
            this.tbPath.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(370, 122);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(57, 23);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.updateTip.SetToolTip(this.btnUpdate, "Will update BSM\'s saved path to your currently entered path");
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnPathHelp
            // 
            this.btnPathHelp.Location = new System.Drawing.Point(433, 122);
            this.btnPathHelp.Name = "btnPathHelp";
            this.btnPathHelp.Size = new System.Drawing.Size(22, 23);
            this.btnPathHelp.TabIndex = 4;
            this.btnPathHelp.Text = "?";
            this.btnPathHelp.UseVisualStyleBackColor = true;
            this.btnPathHelp.Click += new System.EventHandler(this.BtnPathHelp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(5, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Save profile to load or save:";
            // 
            // cbxProfile
            // 
            this.cbxProfile.BackColor = System.Drawing.SystemColors.MenuText;
            this.cbxProfile.FormattingEnabled = true;
            this.cbxProfile.Location = new System.Drawing.Point(8, 166);
            this.cbxProfile.Name = "cbxProfile";
            this.cbxProfile.Size = new System.Drawing.Size(141, 21);
            this.cbxProfile.TabIndex = 6;
            // 
            // btnLoadProfile
            // 
            this.btnLoadProfile.Location = new System.Drawing.Point(155, 164);
            this.btnLoadProfile.Name = "btnLoadProfile";
            this.btnLoadProfile.Size = new System.Drawing.Size(88, 23);
            this.btnLoadProfile.TabIndex = 7;
            this.btnLoadProfile.Text = "Load Profile";
            this.loadTip.SetToolTip(this.btnLoadProfile, "Will load your selected profile into boneworks, overwriting boneworks data");
            this.btnLoadProfile.UseVisualStyleBackColor = true;
            this.btnLoadProfile.Click += new System.EventHandler(this.BtnLoadProfile_Click);
            // 
            // btnSaveToProfile
            // 
            this.btnSaveToProfile.Location = new System.Drawing.Point(249, 164);
            this.btnSaveToProfile.Name = "btnSaveToProfile";
            this.btnSaveToProfile.Size = new System.Drawing.Size(97, 23);
            this.btnSaveToProfile.TabIndex = 8;
            this.btnSaveToProfile.Text = "Save To Profile";
            this.saveTip.SetToolTip(this.btnSaveToProfile, "Will download boneworks save data to this profile, overwriting it");
            this.btnSaveToProfile.UseVisualStyleBackColor = true;
            this.btnSaveToProfile.Click += new System.EventHandler(this.BtnSaveToProfile_Click);
            // 
            // btnProfileHelp
            // 
            this.btnProfileHelp.Location = new System.Drawing.Point(433, 164);
            this.btnProfileHelp.Name = "btnProfileHelp";
            this.btnProfileHelp.Size = new System.Drawing.Size(22, 23);
            this.btnProfileHelp.TabIndex = 10;
            this.btnProfileHelp.Text = "?";
            this.btnProfileHelp.UseVisualStyleBackColor = true;
            this.btnProfileHelp.Click += new System.EventHandler(this.BtnProfileHelp_Click);
            // 
            // btnBrowseBoneworks
            // 
            this.btnBrowseBoneworks.Location = new System.Drawing.Point(8, 272);
            this.btnBrowseBoneworks.Name = "btnBrowseBoneworks";
            this.btnBrowseBoneworks.Size = new System.Drawing.Size(165, 23);
            this.btnBrowseBoneworks.TabIndex = 12;
            this.btnBrowseBoneworks.Text = "Browse BONEWORKS Data";
            this.browseBoneworksTip.SetToolTip(this.btnBrowseBoneworks, "Will open your saved boneworks path in file explorer");
            this.btnBrowseBoneworks.UseVisualStyleBackColor = true;
            this.btnBrowseBoneworks.Click += new System.EventHandler(this.BtnBrowseBoneworks_Click);
            // 
            // btnBrowseBSM
            // 
            this.btnBrowseBSM.Location = new System.Drawing.Point(179, 272);
            this.btnBrowseBSM.Name = "btnBrowseBSM";
            this.btnBrowseBSM.Size = new System.Drawing.Size(137, 23);
            this.btnBrowseBSM.TabIndex = 13;
            this.btnBrowseBSM.Text = "Browse BSM Data";
            this.browseBSMTip.SetToolTip(this.btnBrowseBSM, "Will open BSM\'s data folder in file explorer");
            this.btnBrowseBSM.UseVisualStyleBackColor = true;
            this.btnBrowseBSM.Click += new System.EventHandler(this.BtnBrowseBSM_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "BSM v1.2 Ryan Zmuda 2021";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(297, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Click here if you\'re having issues";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // btnBrowseHelp
            // 
            this.btnBrowseHelp.Location = new System.Drawing.Point(322, 272);
            this.btnBrowseHelp.Name = "btnBrowseHelp";
            this.btnBrowseHelp.Size = new System.Drawing.Size(32, 23);
            this.btnBrowseHelp.TabIndex = 16;
            this.btnBrowseHelp.Text = "?";
            this.btnBrowseHelp.UseVisualStyleBackColor = true;
            this.btnBrowseHelp.Click += new System.EventHandler(this.BtnBrowseHelp_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.Location = new System.Drawing.Point(360, 272);
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(95, 23);
            this.btnOptions.TabIndex = 17;
            this.btnOptions.Text = "Options";
            this.btnOptions.UseVisualStyleBackColor = true;
            this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
            // 
            // tbCustomName
            // 
            this.tbCustomName.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbCustomName.Location = new System.Drawing.Point(8, 241);
            this.tbCustomName.Name = "tbCustomName";
            this.tbCustomName.Size = new System.Drawing.Size(235, 20);
            this.tbCustomName.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(8, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Name of profile you want to create:";
            // 
            // btnCreateProfile
            // 
            this.btnCreateProfile.Location = new System.Drawing.Point(253, 240);
            this.btnCreateProfile.Name = "btnCreateProfile";
            this.btnCreateProfile.Size = new System.Drawing.Size(202, 21);
            this.btnCreateProfile.TabIndex = 20;
            this.btnCreateProfile.Text = "Create new profile";
            this.btnCreateProfile.UseVisualStyleBackColor = true;
            this.btnCreateProfile.Click += new System.EventHandler(this.btnCreateProfile_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(143, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Profile Creation:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(352, 164);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(166, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(140, 36);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(319, 45);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(140, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(8, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(39, 39);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 26;
            this.pictureBox4.TabStop = false;
            // 
            // SavesTxt
            // 
            this.SavesTxt.AutoSize = true;
            this.SavesTxt.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SavesTxt.ForeColor = System.Drawing.Color.Yellow;
            this.SavesTxt.Location = new System.Drawing.Point(45, 49);
            this.SavesTxt.Name = "SavesTxt";
            this.SavesTxt.Size = new System.Drawing.Size(65, 25);
            this.SavesTxt.TabIndex = 27;
            this.SavesTxt.Text = "Saves";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(202, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Mods";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Yellow;
            this.label9.Location = new System.Drawing.Point(347, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 25);
            this.label9.TabIndex = 29;
            this.label9.Text = "Settings";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(467, 329);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.SavesTxt);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCreateProfile);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbCustomName);
            this.Controls.Add(this.btnOptions);
            this.Controls.Add(this.btnBrowseHelp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBrowseBSM);
            this.Controls.Add(this.btnBrowseBoneworks);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
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
        private System.Windows.Forms.Button btnOptions;
        private System.Windows.Forms.TextBox tbCustomName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreateProfile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label SavesTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

