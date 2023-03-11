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
using NitroxSaveParser.DataParse;

namespace NitroxSaveParser
{
    public partial class IntialPage : Form
    {
        public IntialPage()
        {
            InitializeComponent();
        }
        public static string selectedDir { get;}
        public static bool ReadWorldDataTrue = false;
        public static bool ReadPlayerDataTrue = false;
        public static bool ReadBaseDataTrue = false;
        public static bool Directoryvalid = false;

        private bool mouseDown;
        private Point lastLocation;

        public void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        public void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        public void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        public void Directory_Location(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void WorldData_CheckedChanged(object sender, EventArgs e)
        {
            if (WorldData.Checked)
            {
                ReadWorldDataTrue = true;
                if (Directoryvalid)
                {
                    ReadData.Enabled = true;
                }
            }
            else
            {
                ReadWorldDataTrue = false;
                if (!ReadBaseDataTrue && !ReadWorldDataTrue && !ReadPlayerDataTrue)
                {
                    ReadData.Enabled = false;
                }
            }
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
                    Directoryvalid = true;
                    Found.Enabled = true;
                    Found.Visible = true;
                    NotFound.Enabled = false;
                    NotFound.Visible = false;
                    if (ReadBaseDataTrue | ReadPlayerDataTrue | ReadWorldDataTrue)
                    {
                        ReadData.Enabled = true;
                    }
                }
                else
                {
                    ReadData.Enabled = false;
                    Found.Enabled = false;
                    Found.Visible = false;
                    NotFound.Enabled = true;
                    NotFound.Visible = true;

                }
            }



        }

        private void ReadData_Click(object sender, EventArgs e)
        {
            InitialDataParse.InitialData();
            DataSelectPage DataSelectPage = new DataSelectPage();
            DataSelectPage.Show();
        }

        private void PlayerData_CheckedChanged_1(object sender, EventArgs e)
        {
            if (PlayerData.Checked)
            {
                ReadPlayerDataTrue = true;
                if (Directoryvalid)
                {
                    ReadData.Enabled = true;
                }
            }
            else
            {
                ReadPlayerDataTrue = false;
                if (!ReadBaseDataTrue && !ReadWorldDataTrue && !ReadPlayerDataTrue)
                {
                    ReadData.Enabled = false;
                }
            }
        }

        private void BaseData_CheckedChanged(object sender, EventArgs e)
        {
            if (BaseData.Checked)
            {
                ReadBaseDataTrue = true;
                if (Directoryvalid)
                {
                    ReadData.Enabled = true;
                }
            }
            else
            {
                ReadBaseDataTrue = false;
                if (!ReadBaseDataTrue && !ReadWorldDataTrue && !ReadPlayerDataTrue)
                {
                    ReadData.Enabled = false;
                }
            }
        }

        private void IntialPage_Load(object sender, EventArgs e)
        {

        }

        private void NotFound_Click(object sender, EventArgs e)
        {

        }


        private void Close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MadeByBud_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi From bud :) ");
        }
    }
}
