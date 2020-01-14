namespace BSM
{
    partial class Options
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
            this.btnDone = new System.Windows.Forms.Button();
            this.cbxTheme = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnVerifyInteg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(61, 68);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 0;
            this.btnDone.Text = "done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // cbxTheme
            // 
            this.cbxTheme.FormattingEnabled = true;
            this.cbxTheme.Items.AddRange(new object[] {
            "dark",
            "light"});
            this.cbxTheme.Location = new System.Drawing.Point(61, 12);
            this.cbxTheme.Name = "cbxTheme";
            this.cbxTheme.Size = new System.Drawing.Size(131, 21);
            this.cbxTheme.TabIndex = 1;
            this.cbxTheme.SelectedIndexChanged += new System.EventHandler(this.cbxTheme_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Theme:";
            // 
            // btnVerifyInteg
            // 
            this.btnVerifyInteg.Location = new System.Drawing.Point(15, 39);
            this.btnVerifyInteg.Name = "btnVerifyInteg";
            this.btnVerifyInteg.Size = new System.Drawing.Size(177, 23);
            this.btnVerifyInteg.TabIndex = 3;
            this.btnVerifyInteg.Text = "Verify Integretry of BSM Files";
            this.btnVerifyInteg.UseVisualStyleBackColor = true;
            this.btnVerifyInteg.Click += new System.EventHandler(this.btnVerifyInteg_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 97);
            this.Controls.Add(this.btnVerifyInteg);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxTheme);
            this.Controls.Add(this.btnDone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnDone;
        internal System.Windows.Forms.ComboBox cbxTheme;
        internal System.Windows.Forms.Button btnVerifyInteg;
    }
}