using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Xml.Xsl;
using System.Security.Cryptography.X509Certificates;

namespace NitroxSaveParser
{
    public partial class IntialPage : Form
    {
        public IntialPage()
        {
            InitializeComponent();
        }
        public static string selectedDir { get; set; }
        public static bool ReadWorldDataTrue { get; set; }
        public static bool ReadPlayerDataTrue { get; set; }
        public static bool ReadBaseDataTrue { get; set; }

        public void Directory_Location(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WorldData_CheckedChanged(object sender, EventArgs e)
        {
            bool ReadWorldDataTrue = true;
        }

        private void PlayerData_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            string selectedDir;

            // FolderBrowserDialog is a big no no, because its UI sucks!!! REMEMBER BUD! 
            using (CommonOpenFileDialog dialog = new()
            {
                Multiselect = false,
                InitialDirectory = "C:/",
                EnsurePathExists = true,
                IsFolderPicker = true,
                Title = "Select World Data directory"
            })
            {
                if (dialog.ShowDialog() != CommonFileDialogResult.Ok)
                {
                    return;
                }
                selectedDir = Path.GetFullPath(dialog.FileName);
                string dir = selectedDir + @"\Version.json";
                
                //string dir = selectedDir; 
                //for directories is above
                if (File.Exists(dir))
                {
                    Found.Enabled = true;
                    Found.Visible = true;
                    NotFound.Enabled = false;
                    NotFound.Visible = false;
                    ReadData.Enabled = true;
                }
                else
                {
                    ReadData.Enabled = false;
                    Found.Enabled = false;
                    Found.Visible = false;
                    NotFound.Visible = true;
                    NotFound.Visible = true;

                }
            }



        }

        private void ReadData_Click(object sender, EventArgs e)
        {

        }

        private void PlayerData_CheckedChanged_1(object sender, EventArgs e)
        {
            bool ReadBaseDataTrue = true;
        }

        private void BaseData_CheckedChanged(object sender, EventArgs e)
        {
            bool ReadBaseDataTrue = true;
        }
    }
}
