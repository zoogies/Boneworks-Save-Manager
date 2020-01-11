using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set username for use in path stuff
            var username = Environment.UserName;

            //C:\\Program Files (x86)\\Yoyolick\\Boneworks Save Manager
            //path of install when using visual studio installer
            //C:\\Users\\YOUR USER HERE\\AppData\\LocalLow\\Stress Level Zero\\BONEWORKS\\resources1.dat
            //make form non resizable
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //attempt to auto detect path to save data
            //if (System.IO.File.ReadAllLines("C:\\Program Files(x86)\\Yoyolick\\Boneworks Save Manager\\data\\saved_path.txt") == )
            //{
            //    string text = System.IO.File.WriteAllLines(@"C:\\Users\\" + username + "\\AppData\\LocalLow\\Stress Level Zero\\BONEWORKS\\resources1.dat");
            //} TODO

            //set path box to be previous entered path
            string text = System.IO.File.ReadAllText(@"C:\\Program Files (x86)\\Yoyolick\\Boneworks Save Manager\\data\\saved_path.txt");
            pathInput.Text = text;

            //turn buttons off because no save selected
            if (selectedProfile.SelectedText == "")
            {
                btnDelete.Enabled = false;
                btnBackup.Enabled = false;
                btnLoad.Enabled = false;
            }

            //set application icon
            this.Icon = new Icon("C:\\Program Files (x86)\\Yoyolick\\Boneworks Save Manager\\data\\application_icon.ico");

            //set splash image
            pictureBox1.Image = Image.FromFile("C:\\Program Files (x86)\\Yoyolick\\Boneworks Save Manager\\data\\splashimage.jpg");

            //Connects to python files for moving saves
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\\Users\\" + username + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Python 3.8 (64-bit).exe";

            var backup_current_to_100 = @"C:\\Program Files(x86)\\Yoyolick\\Boneworks Save Manager\\data\\backup_current_to_100.py";

            //args here if ever needed i dont have foresight
            //https://www.youtube.com/watch?v=g1VWGdHRkHs if youre reading this its only possible because of this video

            //psi.UseShellExecute = false; //for normal
            //psi.CreateNoWindow = true; //for normal
            psi.UseShellExecute = true; //for debug
            psi.CreateNoWindow = false; //for debug

            psi.RedirectStandardError = true;
            var errors = "";

            using(var process = Process.Start(psi))
            {
                errors = process.StandardError.ReadToEnd();
            }



        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copy the path to your game save data here, it should look something like:\nC:\\Users\\YOUR USER HERE\\AppData\\LocalLow\\Stress Level Zero\\BONEWORKS\\resources1.dat", "Help Window", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] savedPath = {pathInput.Text};
            System.IO.File.WriteAllLines(@"C:\\Program Files (x86)\\Yoyolick\\Boneworks Save Manager\\data\\saved_path.txt", savedPath);
        }

        private void selectedProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
                btnDelete.Enabled = true;
                btnBackup.Enabled = true;
                btnLoad.Enabled = true;
        }

        private void btnProfileHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("These are preset profiles, one you should back up your playthrough on and the other is a 100% unlock save for sandbox and arena", "Help Window", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
