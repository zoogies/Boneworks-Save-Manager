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
            var devpath = @"C:\Users\swoos\source\repos\Boneworks-Save-Manager\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\data";
            var finaldatapath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Boneworks Save Manager";

            //C:\\Users\\YOUR USER HERE\\AppData\\LocalLow\\Stress Level Zero\\BONEWORKS\\resources1.dat

            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //attempt to auto detect path to save data
            //if (System.IO.File.ReadAllLines("C:\\Program Files(x86)\\Yoyolick\\Boneworks Save Manager\\data\\saved_path.txt") == )
            //{
            //    string text = System.IO.File.WriteAllLines(@"C:\\Users\\" + username + "\\AppData\\LocalLow\\Stress Level Zero\\BONEWORKS\\resources1.dat");
            //} TODO

            string text = System.IO.File.ReadAllText(devpath + "saved_path.txt"); //TODO replace with finaldatapath
            pathInput.Text = text;//set path box to be previous entered path

            if (selectedProfile.SelectedText == "")
            {
                btnDelete.Enabled = false;
                btnBackup.Enabled = false;
                btnLoad.Enabled = false;
            }//turn buttons off because no save selected

            //set application icon
            this.Icon = new Icon(devpath + "application_icon.ico"); //todo replace with final path

            //set splash image
            pictureBox1.Image = Image.FromFile(devpath + "splashimage.jpg"); //todo replace with final path
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copy the path to your game save data here, it should look something like:\nC:\\Users\\YOUR USER HERE\\AppData\\LocalLow\\Stress Level Zero\\BONEWORKS\\resources1.dat", "Help Window", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnUpdate_Click(string devpath,object sender, EventArgs e)
        {
            string[] savedPath = {pathInput.Text};
            //TODO swap these for final build
            System.IO.File.WriteAllLines(devpath + "saved_path.txt", savedPath);
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
            //TODO
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if(selectedProfile.SelectedText == "100% unlock save")
            {
                //TODO
            }
            if (selectedProfile.SelectedText == "Personal Save")
            {
                //TODO
            }
        }

        private void btnBackup_Click(string username,string devpath, object sender, EventArgs e)
        {
            if (selectedProfile.SelectedText == "100% unlock save")
            {
                //Connects to python files for moving saves
                var psi = new ProcessStartInfo();
                psi.FileName = @"C:\\Users\\" + username + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Python 3.8 (64-bit).exe";

                //var backup_current_to_100 = @"C:\\Program Files(x86)\\Yoyolick\\Boneworks Save Manager\\data\\backup_current_to_100.py";
                //THIS IS THE FINAL ONE YOU NEED TO UNCOMMENT AFTER FINISHING CODEBASE^^^^
                var backup_current_to_hundred = @"C:\\Users\\swoos\\source\\repos\\Boneworks-Save-Manager\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\data\\backup_current_to_hundred.py";
                psi.Arguments = $"\"{backup_current_to_hundred}\"\""; //todo make this whole area stuff for dependant on which save load

                //psi.UseShellExecute = false; //for normal
                //psi.CreateNoWindow = true; //for normal
                psi.UseShellExecute = false;
                psi.CreateNoWindow = false; //for debug
                psi.RedirectStandardOutput = true;
                psi.RedirectStandardError = true;
                var errors = "";
                var results = "";

                //using(var process = Process.Start(psi))
                //{
                //    errors = process.StandardError.ReadToEnd();
                //    results = process.StandardOutput.ReadToEnd();
                //}

                //MessageBox.Show(results);
            }
            if (selectedProfile.SelectedText == "Personal Save")
            {
                //TODO
            }
        }
    }
}
