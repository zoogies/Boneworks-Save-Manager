using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
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
        public static string sandboxpath;
        public static string personalpath;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Code by Ryan Zmuda 2020
            //Reference:
            //Application data path: C:\Users\swoos\Documents\BSM
            //TODO create backups of save data in each directory and create directories and create images on launch

            //set data path for use in creating files if not present or first launch
            dataPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BSM\\";

            //Create application data directories if not present as well as download required images
            if (!Directory.Exists(dataPath))
            {
                MessageBox.Show("BSM directory not detected (this occurs on first run). Attempting to download neccesary files.", "Application Directory Missing", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Directory.CreateDirectory(dataPath);
                Directory.CreateDirectory(dataPath + "\\personal_save");
                Directory.CreateDirectory(dataPath + "\\sandbox_save");
                File.Create(dataPath + "saved_path.txt").Dispose();
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("http://www.iconj.com/ico/l/u/lufczubxnj.ico", dataPath + "\\application_icon.ico");
                }
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("https://camo.githubusercontent.com/d327cb4332077b1999e18c1cc8d049529d2883e8/68747470733a2f2f7777772e6765656b792d676164676574732e636f6d2f77702d636f6e74656e742f75706c6f6164732f323031392f31312f426f6e65776f726b732d56522d47616d652e6a7067", dataPath + "\\splash_image.jpg");
                }
                resourcesPath = File.ReadAllText(dataPath + "saved_path.txt");
                tbPath.Text = resourcesPath.Trim('\n', '\r');
                if (String.IsNullOrEmpty(tbPath.Text))
                {
                    username = Environment.UserName;
                    tbPath.Text = "C:\\Users\\" + username + "\\AppData\\LocalLow\\Stress Level Zero\\BONEWORKS\\resources1.dat";
                    string[] userPath = { tbPath.Text };
                    File.WriteAllLines(dataPath + "saved_path.txt", userPath);
                    MessageBox.Show("You have yet to set the save path to boneworks, this is the auto assumed path. Click the ? to see more information and double check this path before clicking update.", "Auto Assume Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                resourcesPath = File.ReadAllText(dataPath + "saved_path.txt");
                sandboxpath = dataPath + "\\sandbox_save\\resources1.dat";
                personalpath = dataPath + "\\personal_save\\resources1.dat";
                File.Copy(resourcesPath, sandboxpath, true);
                File.Copy(resourcesPath, personalpath, true);
                MessageBox.Show("Created BSM directory and downloaded neccessary images and files.", "Application Directory Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //create other paths
            resourcesPath = System.IO.File.ReadAllText(dataPath + "saved_path.txt");
            sandboxpath = dataPath + "\\sandbox_save\\resources1.dat";
            personalpath = dataPath + "\\personal_save\\resources1.dat";

            //Window Settings and set startup values and images
            username = Environment.UserName;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Icon = new Icon(dataPath + "application_icon.ico");
            cbxProfile.SelectedText = "personal save";
            pbSplashImage.Image = Image.FromFile(dataPath + "splash_image.jpg");
            tbPath.Text = resourcesPath.Trim('\n', '\r');
            if (String.IsNullOrEmpty(tbPath.Text))
            {
                tbPath.Text = "C:\\Users\\" + username + "\\AppData\\LocalLow\\Stress Level Zero\\BONEWORKS\\resources1.dat";
                string[] userPath = { tbPath.Text };
                File.WriteAllLines(dataPath + "saved_path.txt", userPath);
                MessageBox.Show("You have yet to set the save path to boneworks, this is the auto assumed path. Click the ? to see more information and double check this path before clicking update.", "Auto Assume Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPathHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copy the path to your game save data here, it should look something like:\nC:\\Users\\YOUR USER HERE\\AppData\\LocalLow\\Stress Level Zero\\BONEWORKS\\resources1.dat", "Help Window", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] userPath = { tbPath.Text };
            File.WriteAllLines(dataPath + "saved_path.txt", userPath);
            MessageBox.Show("Updated save path to currently entered path.", "Help Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnProfileHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are 2 profiles, one for you to back up your personal save to, and the other is a 100% unlock save that you can load for sandbox mode. Please read the wiki on github for more information if needed.", "Help Window", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnSaveToProfile_Click(object sender, EventArgs e)
        {
            DialogResult overwrite = MessageBox.Show("Are you sure? This will overwrite the selected profile with your current game data.", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cbxProfile.Text == "sandbox save")
            {
                if (overwrite == DialogResult.Yes)
                {
                    if (File.Exists(resourcesPath) && File.Exists(sandboxpath))
                    {
                        File.Copy(resourcesPath, sandboxpath, true);
                    }
                    else if (!File.Exists(resourcesPath))
                    {
                        MessageBox.Show("Your boneworks does not seem to have a resources1 file present. Try launching the game to create it and then attempt again.", "Cant find save file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!File.Exists(sandboxpath))
                    {
                        MessageBox.Show("Failed to find selected profiles save backup. It may not exist or there may have been an installation program. Try backing up save data to this profile if you believe this is a mistake.", "Cant find save profile data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Failed to find the boneworks save data and the profile save data. Try creating a new game in boneworks and then exiting as well as backing up a save to this profile.", "Cant find save profile data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if(cbxProfile.Text == "personal save")
            {
                if (overwrite == DialogResult.Yes)
                {
                    if (File.Exists(resourcesPath) && File.Exists(personalpath))
                    {
                        File.Copy(resourcesPath, personalpath, true);
                    }
                    else if (!File.Exists(resourcesPath))
                    {
                        MessageBox.Show("Your boneworks does not seem to have a resources1 file present. Try launching the game to create it and then attempt again.", "Cant find save file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!File.Exists(personalpath))
                    {
                        MessageBox.Show("Failed to find selected profiles save backup. It may not exist or there may have been an installation program. Try backing up save data to this profile if you believe this is a mistake.", "Cant find save profile data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Failed to find the boneworks save data and the profile save data. Try creating a new game in boneworks and then exiting as well as backing up a save to this profile.", "Cant find save profile data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnLoadProfile_Click(object sender, EventArgs e)
        {
            DialogResult overwrite = MessageBox.Show("Are you sure? This will overwrite your selected profiles data with the games save data.", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cbxProfile.Text == "sandbox save")
            {
                if (overwrite == DialogResult.Yes)
                {
                    if (File.Exists(resourcesPath) && File.Exists(sandboxpath))
                    {
                        File.Copy(sandboxpath, resourcesPath, true);
                    }
                    else if (!File.Exists(resourcesPath))
                    {
                        MessageBox.Show("Your boneworks does not seem to have a resources1 file present. Try launching the game to create it and then attempt again.", "Cant find save file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!File.Exists(sandboxpath))
                    {
                        MessageBox.Show("Failed to find selected profiles save backup. It may not exist or there may have been an installation program. Try backing up save data to this profile if you believe this is a mistake.", "Cant find save profile data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Failed to find the boneworks save data and the profile save data. Try creating a new game in boneworks and then exiting as well as backing up a save to this profile.", "Cant find save profile data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            if (cbxProfile.Text == "personal save")
            {
                if (overwrite == DialogResult.Yes)
                {
                    if (File.Exists(resourcesPath) && File.Exists(personalpath))
                    {
                        File.Copy(personalpath, resourcesPath, true);
                    }
                    else if (!File.Exists(resourcesPath))
                    {
                        MessageBox.Show("Your boneworks does not seem to have a resources1 file present. Try launching the game to create it and then attempt again.", "Cant find save file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (!File.Exists(personalpath))
                    {
                        MessageBox.Show("Failed to find selected profiles save backup. It may not exist or there may have been an installation program. Try backing up save data to this profile if you believe this is a mistake.", "Cant find save profile data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Failed to find the boneworks save data and the profile save data. Try creating a new game in boneworks and then exiting as well as backing up a save to this profile.", "Cant find save profile data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnBrowseHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Both of these browse buttons can be used to verify integrity of both BSM and Boneworks files. Use these if you are getting errors when backing up or loading save profiles.", "Help Window", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Yoyolick/Boneworks-Save-Manager/issues");
        }

        private void btnBrowseBoneworks_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "C:\\Users\\" + username + "\\AppData\\LocalLow\\Stress Level Zero\\BONEWORKS");
        }

        private void btnBrowseBSM_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", dataPath);
        }
    }
}
