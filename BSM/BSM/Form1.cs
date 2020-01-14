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
        public static string theme;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Code by Ryan Zmuda 2020

            //set data path for use in creating files if not present or first launch
            dataPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BSM\\";

            //Create application data directories if not present as well as download required images
            ValidateFileSystem();

            //Window Settings and set startup values and images
            username = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            var iconpath = dataPath + "application_icon.ico";
            this.Icon = new Icon(dataPath + "application_icon.ico");
            cbxProfile.SelectedText = "personal save";

            //load theme
            ThemeLoad();
        }

        public void ThemeLoad()
        {
            //detect theme in text
            theme = File.ReadAllText(dataPath + "theme.txt");
            theme = theme.Trim('\n', '\r');

            if (theme == "dark")
            {
                pbSplashImage.Image = Image.FromFile(dataPath + "splash_image.jpg");
                this.BackColor = Color.FromArgb(47, 45, 45);
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label3.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
            }
            if (theme == "light")
            {
                pbSplashImage.Image = Image.FromFile(dataPath + "splash_image_light.png");
                this.BackColor = Color.FromArgb(238, 238, 238);
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label3.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
            }
        }

        public void ValidateFileSystem()
        {
            //Filestructure
            //
            //BSM
            //+personal_save
            // +resources1.dat
            //+sandbox_save
            // +resources1.dat
            //+application_icon.ico
            //+saved_path.txt
            //+splash_image.jpg
            //+splash_image_light.jpg
            //+theme.txt

            //test shit debug
            var builtsomething = false;

            //directory validation
            if (!Directory.Exists(dataPath))
            {
                Directory.CreateDirectory(dataPath);
                builtsomething = true;
            }
            if (!Directory.Exists(dataPath + "\\personal_save"))
            {
                Directory.CreateDirectory(dataPath + "\\personal_save");
                builtsomething = true;
            }
            if (!Directory.Exists(dataPath + "\\sandbox_save"))
            {
                Directory.CreateDirectory(dataPath + "\\sandbox_save");
                builtsomething = true;
            }

            //file validation
            if (!File.Exists(dataPath + "\\sandbox_save\\resources1.dat"))
            {
                sandboxpath = dataPath + "\\sandbox_save\\resources1.dat";
                File.Create(sandboxpath).Dispose();
                builtsomething = true;
            }
            if (!File.Exists(dataPath + "\\personal_save\\resources1.dat"))
            {
                personalpath = dataPath + "\\personal_save\\resources1.dat";
                File.Create(personalpath).Dispose();
                builtsomething = true;
            }
            if (!File.Exists(dataPath + "\\application_icon.ico"))
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("http://www.iconj.com/ico/l/u/lufczubxnj.ico", dataPath + "\\application_icon.ico");
                    builtsomething = true;
                }
            }
            if (!File.Exists(dataPath + "\\splash_image.jpg"))
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("https://pbs.twimg.com/media/ENEpsVpWwAkpS76.jpg", dataPath + "\\splash_image.jpg");
                    builtsomething = true;
                }
            }
            if (!File.Exists(dataPath + "\\splash_image_light.png"))
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("https://steamcdn-a.akamaihd.net/steam/apps/823500/extras/logo_boneworks.png?t=1576000732", dataPath + "\\splash_image_light.png");
                    builtsomething = true;
                }
            }
            if (!File.Exists(dataPath + "\\saved_path.txt"))
            {
                var savedpath = dataPath + "\\saved_path.txt";
                File.Create(savedpath).Dispose();
                builtsomething = true;
            }
            if (!File.Exists(dataPath + "\\theme.txt"))
            {
                var themepath = dataPath + "\\theme.txt";
                File.Create(themepath).Dispose();
                builtsomething = true;
                string[] theme = {"dark"};
                File.WriteAllLines(dataPath + "theme.txt", theme);
            }

            //auto assume boneworks path if not set
            resourcesPath = File.ReadAllText(dataPath + "saved_path.txt");
            tbPath.Text = resourcesPath.Trim('\n', '\r');
            if (String.IsNullOrEmpty(tbPath.Text))
            {
                username = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                tbPath.Text = username + "\\AppData\\LocalLow\\Stress Level Zero\\BONEWORKS\\resources1.dat";
                string[] userPath = { tbPath.Text };
                File.WriteAllLines(dataPath + "saved_path.txt", userPath);
                MessageBox.Show("You have yet to set the save path to boneworks, this is the auto assumed path. Click the ? to see more information and double check this path before clicking update.", "Auto Assume Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            resourcesPath = File.ReadAllText(dataPath + "saved_path.txt");

            //check to see if updated and if so notify user
            if(builtsomething == true)
            {
                MessageBox.Show("BSM filesystem rebuilt, this could be because of an update or first time bsm launch", "Filesystem Rebuilt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //set path variables
            resourcesPath = System.IO.File.ReadAllText(dataPath + "saved_path.txt");
            sandboxpath = dataPath + "\\sandbox_save\\resources1.dat";
            personalpath = dataPath + "\\personal_save\\resources1.dat";
        }

        private void BtnPathHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copy the path to your game save data here, it should look something like:\nC:\\Users\\YOUR USER HERE\\AppData\\LocalLow\\Stress Level Zero\\BONEWORKS\\resources1.dat", "Help Window", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string[] userPath = { tbPath.Text };
            File.WriteAllLines(dataPath + "saved_path.txt", userPath);
            MessageBox.Show("Updated save path to currently entered path.", "Help Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnProfileHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There are 2 profiles, one for you to back up your personal save to, and the other is a 100% unlock save that you can load for sandbox mode. Please read the wiki on github for more information if needed.", "Help Window", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void BtnSaveToProfile_Click(object sender, EventArgs e)
        {
            DialogResult overwrite = MessageBox.Show("Are you sure? This will overwrite the selected profile with your current game data.", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cbxProfile.Text == "sandbox save")
            {
                if (overwrite == DialogResult.Yes)
                {
                    if (File.Exists(resourcesPath) && File.Exists(sandboxpath))
                    {
                        File.Copy(resourcesPath, sandboxpath, true);
                        MessageBox.Show("File Transfer Sucessful", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("File Transfer Sucessful", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnLoadProfile_Click(object sender, EventArgs e)
        {
            DialogResult overwrite = MessageBox.Show("Are you sure? This will overwrite your selected profiles data with the games save data.", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cbxProfile.Text == "sandbox save")
            {
                if (overwrite == DialogResult.Yes)
                {
                    if (File.Exists(resourcesPath) && File.Exists(sandboxpath))
                    {
                        File.Copy(sandboxpath, resourcesPath, true);
                        MessageBox.Show("File Transfer Sucessful", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("File Transfer Sucessful", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void BtnBrowseHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Both of these browse buttons can be used to verify integrity of both BSM and Boneworks files. Use these if you are getting errors when backing up or loading save profiles.", "Help Window", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Yoyolick/Boneworks-Save-Manager/issues");
        }

        private void BtnBrowseBoneworks_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "C:\\Users\\" + username + "\\AppData\\LocalLow\\Stress Level Zero\\BONEWORKS");
        }

        private void BtnBrowseBSM_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", dataPath);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Options optionsPanel = new Options();
            optionsPanel.Show();

            optionsPanel.btnDone.Click += this.Options_btnDone_Click;
        }
        
        private void Options_btnDone_Click(object sender, EventArgs e)
        {
            ThemeLoad();
        }
    }
}
