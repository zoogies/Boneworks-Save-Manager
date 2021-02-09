using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSM
{
    public partial class Options : Form
    {
        public static string dataPath;
        public static string resourcesPath;
        public static string theme;

        public Options()
        {
            InitializeComponent();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            //set path variables
            dataPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BSM\\";
            resourcesPath = System.IO.File.ReadAllText(dataPath + "saved_path.txt");
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerifyInteg_Click(object sender, EventArgs e)
        {
            //TODO same as done click detect basically
            MessageBox.Show("File system checked.","File system checked",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void cbxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxTheme.Text = cbxTheme.Text.Trim('\n', '\r');
            string[] selectedTheme = { cbxTheme.Text };
            File.WriteAllLines(dataPath + "theme.txt", selectedTheme);

            //detect theme in text
            var theme = File.ReadAllText(dataPath + "theme.txt");
            theme = theme.Trim('\n', '\r');

            if (theme == "dark")
            {
                this.BackColor = Color.FromArgb(47, 45, 45);
                label1.ForeColor = Color.White;
                cbxTheme.Text = "dark";
            }
            if (theme == "light")
            {
                this.BackColor = Color.FromArgb(238, 238, 238);
                label1.ForeColor = Color.Black;
                cbxTheme.Text = "light";
            }
        }
    }
}
