using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            //make form non resizable
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //set path box to be previous entered path
            string text = System.IO.File.ReadAllText(@"C: \Users\swoos\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\data\saved_path.txt");
            pathInput.Text = text;

            //turn buttons off because no save selected
            if (selectedProfile.SelectedText == "")
            {
                btnDelete.Enabled = false;
                btnBackup.Enabled = false;
                btnLoad.Enabled = false;
            }

            //set application icon
            this.Icon = new Icon("C:\\Users\\swoos\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\data\\application_icon.ico");

            //set splash image
            pictureBox1.Image = Image.FromFile("C:\\Users\\swoos\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\bin\\Debug\\data\\splashimage.jpg");
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copy the path to your game save data here, it should look something like:\nC:\\Users\\YOUR USER HERE\\AppData\\LocalLow\\Stress Level Zero\\BONEWORKS\\resources1.dat", "Help Window", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string[] savedPath = {pathInput.Text};
            System.IO.File.WriteAllLines(@"C:\Users\swoos\source\repos\WindowsFormsApp1\WindowsFormsApp1\bin\Debug\data\saved_path.txt", savedPath);
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
