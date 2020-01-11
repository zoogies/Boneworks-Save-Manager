using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSM
{
    public partial class Form1 : Form
    {

        public static string dataPath;
        public static string resourcesPath;
        public static string username;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Code by Ryan Zmuda
            //Reference:
            //Application data path: C:\Users\swoos\Documents\BSM

            //set paths
            dataPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BSM\\";
            resourcesPath = System.IO.File.ReadAllText(dataPath + "saved_path.txt");

            //Window Settings and set startup values and images
            username = Environment.UserName;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = new Icon(dataPath + "application_icon.ico");
            cbxProfile.SelectedText = "personal save";
            pbSplashImage.Image = Image.FromFile(dataPath + "splash_image.jpg");
            tbPath.Text = resourcesPath.Trim('\n','\r');
            if (String.IsNullOrEmpty(tbPath.Text))
            {
                tbPath.Text = "C:\\Users\\" + username + "\\AppData\\LocalLow\\Stress Level Zero\\BONEWORKS\\resources1.dat";
                MessageBox.Show("You have yet to set the save path to boneworks, this is the auto assumed path. Click the ? to see more information and double check this path before clicking update.", "Auto Assume Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPathHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copy the path to your game save data here, it should look something like:\nC:\\Users\\YOUR USER HERE\\AppData\\LocalLow\\Stress Level Zero\\BONEWORKS\\resources1.dat", "Help Window", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] userPath = {tbPath.Text};
            System.IO.File.WriteAllLines(dataPath + "saved_path.txt", userPath);
            MessageBox.Show("Updated save path to currently entered path.", "Help Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnProfileHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are 2 profiles, one for you to back up your personal save to, and the other is a 100% unlock save that you can load for sandbox mode. Please read the wiki on github for more information if needed.", "Help Window", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnSaveToProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure? This will overwrite the selected profile with your current game data.", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void btnLoadProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure? This will overwrite your game data with the selected profiles data. Make sure you have backed up your game first.", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }
    }
}
