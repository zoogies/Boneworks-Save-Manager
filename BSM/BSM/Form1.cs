using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Resources;
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
        public static bool duplicate;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Code by Ryan Zmuda 2020
            //TODO:
            //get application icon for settings and download and apply it in filestructre

            //set data path for use in creating files if not present or first launch
            dataPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\BSM\\";

            //Create application data directories if not present as well as download required images
            ValidateFileSystem();

            //Window Settings and set startup values and images
            username = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            var iconpath = dataPath + "\\application_icon.ico";
            this.Icon = new Icon(dataPath + "\\application_icon.ico");
            cbxProfile.SelectedText = "";

            //load theme
            ThemeLoad();

            //load cbx items
            LoadCbx();

            //check if newer version is available
            using (WebClient client = new WebClient())
            {
                client.DownloadFile("https://raw.githubusercontent.com/Yoyolick/Boneworks-Save-Manager/master/BSM/resources/newest_version.txt", dataPath + "\\newest_version.txt");
            }
            string version_number = File.ReadAllText(dataPath + "\\newest_version.txt");
            if (version_number != "1.3\n")
            {
                MessageBox.Show("A newer version of BSM is available. You are currently using version " + version_number + "Please uninstall and download BSM again from the repo or Bonetome for an updated version with more features.", "Software out of date", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void PopulateSave(string selectedsavepath)
        {
            /*
             * LEGACY:
            File.Create(selectedsavepath + "\\additional_resources1.dat");
            File.Create(selectedsavepath + "\\additional_resources1.dat.bak");
            File.Create(selectedsavepath + "\\additional_resources2.dat");
            File.Create(selectedsavepath + "\\additional_resources3.dat");
            File.Create(selectedsavepath + "\\additional_resources4.dat");
            File.Create(selectedsavepath + "\\bw1_ArenaPlayer_01.dat");
            File.Create(selectedsavepath + "\\bw1_pInfo_00.dat");
            File.Create(selectedsavepath + "\\bw1_pInfo_01.dat");
            File.Create(selectedsavepath + "\\bw1_pInfo_02.dat");
            File.Create(selectedsavepath + "\\bw1_pInfo_03.dat");
            File.Create(selectedsavepath + "\\bw1_pInfo_04.dat");
            File.Create(selectedsavepath + "\\extraResources1.dat");
            File.Create(selectedsavepath + "\\extraResources2.dat");
            File.Create(selectedsavepath + "\\extraResources3.dat");
            File.Create(selectedsavepath + "\\extraResources4.dat");
            File.Create(selectedsavepath + "\\output_log.txt");
            File.Create(selectedsavepath + "\\resources1.dat");
            File.Create(selectedsavepath + "\\resources2.dat");
            File.Create(selectedsavepath + "\\resources3.dat");
            File.Create(selectedsavepath + "\\resources4.dat");
            */
            copyToProfile(dataPath + cbxProfile.Text.Replace(" ", "_"));
        }

        public void LoadCbx()
        {
            //load directories into a list to populate combo box
            cbxProfile.Items.Clear();
            foreach (string dir in Directory.GetDirectories(dataPath))
            {
                cbxProfile.Items.Add(dir.Remove(0, dataPath.Length).Replace("_"," "));
            }
        }

        public void ThemeLoad()
        {
            label1.ForeColor = Color.Yellow;
            label2.ForeColor = Color.Yellow;
            label3.ForeColor = Color.Yellow;
            //label4.ForeColor = Color.Yellow;
            //label5.ForeColor = Color.Yellow;
            label6.ForeColor = Color.Yellow;
            label7.ForeColor = Color.Yellow;
            this.BackColor = Color.FromArgb(15, 15, 15);
            tbPath.ForeColor = Color.Yellow;
        }

        private void copyToProfile(string selectedsavepath)
        {
            //MessageBox.Show(resourcesPath, "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information); debug
            //MessageBox.Show(selectedsavepath, "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information); debug

            //debug
            bool copydebug = false;

            if (copydebug == true)
                MessageBox.Show("i did it", "s", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (Directory.Exists(resourcesPath) && Directory.Exists(selectedsavepath))
            {
                //MessageBox.Show(resourcesPath, "s", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show(selectedsavepath, "s", MessageBoxButtons.OK, MessageBoxIcon.Information);

                foreach (string dirPath in Directory.GetDirectories(resourcesPath, "*",SearchOption.AllDirectories))
                    Directory.CreateDirectory(dirPath.Replace(resourcesPath, selectedsavepath));
                foreach (string newPath in Directory.GetFiles(resourcesPath, "*.*",SearchOption.AllDirectories))
                    File.Copy(newPath, newPath.Replace(resourcesPath, selectedsavepath), true);

                /*
                 * LEGACY
                if (Directory.Exists(resourcesPath + "\\additional_resources1.dat"))
                    File.Copy(resourcesPath + "\\additional_resources1.dat", selectedsavepath + "\\additional_resources1.dat", true);
                    if (copydebug == true)
                        MessageBox.Show("i did it", "s", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Directory.Exists(resourcesPath + "\\additional_resources1.dat.bak"))
                    File.Copy(resourcesPath + "\\additional_resources1.dat.bak", selectedsavepath + "\\additional_resources1.dat.bak", true);
                    if (copydebug == true)
                        MessageBox.Show("i did it", "s", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Directory.Exists(resourcesPath + "\\additional_resources2.dat"))
                    File.Copy(resourcesPath + "\\additional_resources2.dat", selectedsavepath + "\\additional_resources2.dat", true);
                    if (copydebug == true)
                        MessageBox.Show("i did it", "s", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Directory.Exists(resourcesPath + "\\additional_resources3.dat"))
                    File.Copy(resourcesPath + "\\additional_resources3.dat", selectedsavepath + "\\additional_resources3.dat", true);
                    if (copydebug == true)
                        MessageBox.Show("i did it", "s", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Directory.Exists(resourcesPath + "\\additional_resources4.dat"))
                    File.Copy(resourcesPath + "\\additional_resources4.dat", selectedsavepath + "\\additional_resources4.dat", true);
                    if (copydebug == true)
                        MessageBox.Show("i did it", "s", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Directory.Exists(resourcesPath + "\\bw1_ArenaPlayer_01.dat"))
                    File.Copy(resourcesPath + "\\bw1_ArenaPlayer_01.dat", selectedsavepath + "\\bw1_ArenaPlayer_01.dat", true);

                if (Directory.Exists(resourcesPath + "\\bw1_pInfo_00.dat"))
                    File.Copy(resourcesPath + "\\bw1_pInfo_00.dat", selectedsavepath + "\\bw1_pInfo_00.dat", true);

                if (Directory.Exists(resourcesPath + "\\bw1_pInfo_01.dat"))
                    File.Copy(resourcesPath + "\\bw1_pInfo_01.dat", selectedsavepath + "\\bw1_pInfo_01.dat", true);

                if (Directory.Exists(resourcesPath + "\\bw1_pInfo_02.dat"))
                    File.Copy(resourcesPath + "\\bw1_pInfo_02.dat", selectedsavepath + "\\bw1_pInfo_02.dat", true);

                if (Directory.Exists(resourcesPath + "\\bw1_pInfo_03.dat"))
                    File.Copy(resourcesPath + "\\bw1_pInfo_03.dat", selectedsavepath + "\\bw1_pInfo_03.dat", true);

                if (Directory.Exists(resourcesPath + "\\bw1_pInfo_04.dat"))
                    File.Copy(resourcesPath + "\\bw1_pInfo_04.dat", selectedsavepath + "\\bw1_pInfo_04.dat", true);

                if (Directory.Exists(resourcesPath + "\\extraResources1.dat"))
                    File.Copy(resourcesPath + "\\extraResources1.dat", selectedsavepath + "\\extraResources1.dat", true);

                if (Directory.Exists(resourcesPath + "\\extraResources2.dat"))
                    File.Copy(resourcesPath + "\\extraResources2.dat", selectedsavepath + "\\extraResources2.dat", true);

                if (Directory.Exists(resourcesPath + "\\extraResources3.dat"))
                    File.Copy(resourcesPath + "\\extraResources3.dat", selectedsavepath + "\\extraResources3.dat", true);

                if (Directory.Exists(resourcesPath + "\\extraResources4.dat"))
                    File.Copy(resourcesPath + "\\extraResources4.dat", selectedsavepath + "\\extraResources4.dat", true);

                if (Directory.Exists(resourcesPath + "\\output_log.txt"))
                    File.Copy(resourcesPath + "\\output_log.txt", selectedsavepath + "\\output_log.txt", true);

                if (Directory.Exists(resourcesPath + "\\resources1.dat"))
                    File.Copy(resourcesPath + "\\resources1.dat", selectedsavepath + "\\resources1.dat", true);

                if (Directory.Exists(resourcesPath + "\\resources2.dat"))
                    File.Copy(resourcesPath + "\\resources2.dat", selectedsavepath + "\\resources2.dat", true);

                if (Directory.Exists(resourcesPath + "\\resources3.dat"))
                    File.Copy(resourcesPath + "\\resources3.dat", selectedsavepath + "\\resources3.dat", true);

                if (Directory.Exists(resourcesPath + "\\resources4.dat"))
                    File.Copy(resourcesPath + "\\resources4.dat", selectedsavepath + "\\resources4.dat", true);
                */

                //MessageBox.Show("File Transfer Sucessful", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Something went wrong. Try creating a new game in boneworks and then exiting as well as backing up a save to this selected profile.", "Cant find save profile data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void copyToGame(string selectedsavepath)
        {
            if (Directory.Exists(resourcesPath) && Directory.Exists(selectedsavepath))
            {

                foreach (string dirPath in Directory.GetDirectories(selectedsavepath, "*", SearchOption.AllDirectories))
                    Directory.CreateDirectory(dirPath.Replace(selectedsavepath, resourcesPath));
                foreach (string newPath in Directory.GetFiles(selectedsavepath, "*.*", SearchOption.AllDirectories))
                    File.Copy(newPath, newPath.Replace(selectedsavepath, resourcesPath), true);

                /*
                if (Directory.Exists(selectedsavepath + "\\additional_resources1.dat"))
                    File.Copy(selectedsavepath + "\\additional_resources1.dat", resourcesPath + "\\additional_resources1.dat", true);

                if (Directory.Exists(selectedsavepath + "\\additional_resources1.dat.bak"))
                    File.Copy(selectedsavepath + "\\additional_resources1.dat.bak", resourcesPath + "\\additional_resources1.dat.bak", true);

                if (Directory.Exists(selectedsavepath + "\\additional_resources2.dat"))
                    File.Copy(selectedsavepath + "\\additional_resources2.dat", resourcesPath + "\\additional_resources2.dat", true);

                if (Directory.Exists(selectedsavepath + "\\additional_resources3.dat"))
                    File.Copy(selectedsavepath + "\\additional_resources3.dat", resourcesPath + "\\additional_resources3.dat", true);

                if (Directory.Exists(selectedsavepath + "\\additional_resources4.dat"))
                    File.Copy(selectedsavepath + "\\additional_resources4.dat", resourcesPath + "\\additional_resources4.dat", true);

                if (Directory.Exists(selectedsavepath + "\\bw1_ArenaPlayer_01.dat"))
                    File.Copy(selectedsavepath + "\\bw1_ArenaPlayer_01.dat", resourcesPath + "\\bw1_ArenaPlayer_01.dat", true);

                if (Directory.Exists(selectedsavepath + "\\bw1_pInfo_00.dat"))
                    File.Copy(selectedsavepath + "\\bw1_pInfo_00.dat", resourcesPath + "\\bw1_pInfo_00.dat", true);

                if (Directory.Exists(selectedsavepath + "\\bw1_pInfo_01.dat"))
                    File.Copy(selectedsavepath + "\\bw1_pInfo_01.dat", resourcesPath + "\\bw1_pInfo_01.dat", true);

                if (Directory.Exists(selectedsavepath + "\\bw1_pInfo_02.dat"))
                    File.Copy(selectedsavepath + "\\bw1_pInfo_02.dat", resourcesPath + "\\bw1_pInfo_02.dat", true);

                if (Directory.Exists(selectedsavepath + "\\bw1_pInfo_03.dat"))
                    File.Copy(selectedsavepath + "\\bw1_pInfo_03.dat", resourcesPath + "\\bw1_pInfo_03.dat", true);

                if (Directory.Exists(selectedsavepath + "\\bw1_pInfo_04.dat"))
                    File.Copy(selectedsavepath + "\\bw1_pInfo_04.dat", resourcesPath + "\\bw1_pInfo_04.dat", true);

                if (Directory.Exists(selectedsavepath + "\\extraResources1.dat"))
                    File.Copy(selectedsavepath + "\\extraResources1.dat", resourcesPath + "\\extraResources1.dat", true);

                if (Directory.Exists(selectedsavepath + "\\extraResources2.dat"))
                    File.Copy(selectedsavepath + "\\extraResources2.dat", resourcesPath + "\\extraResources2.dat", true);

                if (Directory.Exists(selectedsavepath + "\\extraResources3.dat"))
                    File.Copy(selectedsavepath + "\\extraResources3.dat", resourcesPath + "\\extraResources3.dat", true);

                if (Directory.Exists(selectedsavepath + "\\extraResources4.dat"))
                    File.Copy(selectedsavepath + "\\extraResources4.dat", resourcesPath + "\\extraResources4.dat", true);

                if (Directory.Exists(selectedsavepath + "\\output_log.txt"))
                    File.Copy(selectedsavepath + "\\output_log.txt", resourcesPath + "\\output_log.txt", true);

                if (Directory.Exists(selectedsavepath + "\\resources1.dat"))
                    File.Copy(selectedsavepath + "\\resources1.dat", resourcesPath + "\\resources1.dat", true);

                if (Directory.Exists(selectedsavepath + "\\resources2.dat"))
                    File.Copy(selectedsavepath + "\\resources2.dat", resourcesPath + "\\resources2.dat", true);

                if (Directory.Exists(selectedsavepath + "\\resources3.dat"))
                    File.Copy(selectedsavepath + "\\resources3.dat", resourcesPath + "\\resources3.dat", true);

                if (Directory.Exists(selectedsavepath + "\\resources4.dat"))
                    File.Copy(selectedsavepath + "\\resources4.dat", resourcesPath + "\\resources4.dat",true);
                */

                //MessageBox.Show("File Transfer Sucessful", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Something went wrong. Try creating a new game in boneworks and then exiting as well as backing up a save to this selected profile.", "Cant find save profile data", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            //file validation
            if (!File.Exists(dataPath + "\\newest_version.txt"))
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("https://raw.githubusercontent.com/Yoyolick/Boneworks-Save-Manager/master/BSM/resources/newest_version.txt", dataPath + "\\newest_version.txt");
                    builtsomething = true;
                }
            }

            if (!File.Exists(dataPath + "\\application_icon.ico"))
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("https://raw.githubusercontent.com/Yoyolick/Boneworks-Save-Manager/master/BSM/resources/application_icon.ico", dataPath + "\\application_icon.ico");
                    builtsomething = true;
                }
            }
            if (!File.Exists(dataPath + "\\splash_image.jpg"))
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("https://raw.githubusercontent.com/Yoyolick/Boneworks-Save-Manager/master/BSM/resources/splash_image.jpg", dataPath + "\\splash_image.jpg");
                    builtsomething = true;
                }
            }
            if (!File.Exists(dataPath + "\\splash_image_light.png"))
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile("https://raw.githubusercontent.com/Yoyolick/Boneworks-Save-Manager/master/BSM/resources/splash_image_light.png", dataPath + "\\splash_image_light.png");
                    builtsomething = true;
                }
            }
            if (!File.Exists(dataPath + "\\saved_path.txt"))
            {
                var savedpath = dataPath + "\\saved_path.txt";
                File.Create(savedpath).Dispose();
                builtsomething = true;
            }

            //auto assume boneworks path if not set
            resourcesPath = File.ReadAllText(dataPath + "saved_path.txt");
            tbPath.Text = resourcesPath.Trim('\n', '\r');
            if (String.IsNullOrEmpty(tbPath.Text))
            {
                username = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
                tbPath.Text = username + "\\AppData\\LocalLow\\Stress Level Zero\\BONEWORKS";
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
            resourcesPath = File.ReadAllText(dataPath + "\\saved_path.txt");
            sandboxpath = dataPath + "\\sandbox_save";
            personalpath = dataPath + "\\personal_save";
            resourcesPath = resourcesPath.Replace("\r\n", string.Empty);
        }

        private void BtnPathHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copy the path to your game save data folder here, it should look something like:\nC:\\Users\\YOUR USERNAME HERE\\AppData\\LocalLow\\Stress Level Zero\\BONEWORKS", "Help Window", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            string[] userPath = { tbPath.Text };
            File.WriteAllLines(dataPath + "saved_path.txt", userPath);
            MessageBox.Show("Updated save path to currently entered path.", "Help Window", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnProfileHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In the below section you are able to create profiles, and in this section you can select them from a drop down and either back up your game to them or load them to your game. Please read the wiki on github for more information if needed.", "Help Window", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void BtnSaveToProfile_Click(object sender, EventArgs e)
        {
            DialogResult overwrite = MessageBox.Show("Are you sure? This will overwrite the selected profile with your current game data.", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (cbxProfile.Text == "" || cbxProfile.Text == " ")
            {
                MessageBox.Show("Select a profile from the drop down menu to use this function", "Select a save profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (overwrite == DialogResult.Yes)
            {
                copyToProfile(dataPath + cbxProfile.Text.Replace(" ","_"));
            }
        }

        private void BtnLoadProfile_Click(object sender, EventArgs e)
        {
            if (cbxProfile.Text == "" || cbxProfile.Text == " ")
            {
                MessageBox.Show("Select a profile from the drop down menu to use this function", "Select a save profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DialogResult overwrite = MessageBox.Show("Are you sure? This will overwrite your game's data with the profile's save data.", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (overwrite == DialogResult.Yes)
            {
                if (Directory.Exists(resourcesPath) && Directory.Exists(dataPath + cbxProfile.Text.Replace(" ", "_")))
                {
                    copyToGame(dataPath + cbxProfile.Text.Replace(" ", "_"));
                }
                else
                {
                    MessageBox.Show("Failed to find the boneworks save data and the profile save data. Try creating a new game in boneworks and then exiting as well as backing up a save to this profile.", "Cant find save profile data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnBrowseHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These browse buttons can be used to open the location of BSM and Boneworks files. Use these if you are getting errors when backing up or loading save profiles and want to see if your file locations are correct.", "Help Window", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Yoyolick/Boneworks-Save-Manager/issues");
        }

        private void BtnBrowseBoneworks_Click(object sender, EventArgs e)
        {
            
            //TODO fix
        }

        private void BtnBrowseBSM_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", dataPath);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            Options optionsPanel = new Options();
            optionsPanel.Show();

            optionsPanel.cbxTheme.SelectedIndexChanged += this.cbxTheme_SelectedIndexChanged;
            optionsPanel.btnDone.Click += this.btnVerifyInteg_Click;
        }

        private void btnVerifyInteg_Click(object sender, EventArgs e)
        {
            ValidateFileSystem();
        }

        private void cbxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            ThemeLoad();
        }

        public void CreateProfile()
        {
            var customprofile = tbCustomName.Text;
            if (tbCustomName.Text != "" && tbCustomName.Text != " ")
            {
                for (int i = 0; i < cbxProfile.Items.Count; i++)
                {
                    if(tbCustomName.Text == cbxProfile.GetItemText(cbxProfile.Items[i]))
                    {
                        duplicate = true;
                    }
                }
                if(duplicate == false)
                {
                    Directory.CreateDirectory(dataPath + "\\" + customprofile.Replace(" ", "_"));
                    LoadCbx();

                    tbCustomName.Text = "";
                    cbxProfile.Text = customprofile;
                    PopulateSave(dataPath + "\\" + customprofile.Replace(" ", "_"));
                    MessageBox.Show("User profile " + "\"" + customprofile + "\"" + " created.", "Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            MessageBox.Show("Failed to create profile, please make sure the name is valid and not identical to another profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxProfile.Text == "")
                {
                    MessageBox.Show("Please select a profile to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                var pathtodelete = cbxProfile.Text.Replace(" ","_");
                Directory.Delete(dataPath + pathtodelete,true);
                MessageBox.Show("Deleted profile sucessfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCbx();
                cbxProfile.Text = "";

            }
            catch
            {
                var pathtodelete = cbxProfile.Text.Replace(" ", "_");
                MessageBox.Show("An error occured. Attempted to delete: " + dataPath + pathtodelete + ". Please make sure you arent trying to delete a blank profile", "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createProfileTxt_Click(object sender, EventArgs e)
        {
            CreateProfile();
        }

        private void createProfileBtn_Click(object sender, EventArgs e)
        {
            CreateProfile();
        }

        private void txtValidate_Click(object sender, EventArgs e)
        {
            ValidateFileSystem();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            ValidateFileSystem();
        }

        private void txtBrowseBsm_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", dataPath);
        }

        private void browseBsmBtn_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", dataPath);
        }

        private void txtBrowseGame_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", resourcesPath);
        }

        private void btnBrowseGame_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", resourcesPath);
        }

        private void btnGameData_Click(object sender, EventArgs e)
        {

        }

        private void txtGameData_Click(object sender, EventArgs e)
        {

        }
    }
}
