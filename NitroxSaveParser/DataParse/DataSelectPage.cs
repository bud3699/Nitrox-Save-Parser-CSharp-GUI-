using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NitroxSaveParser.DataParse
{
    public partial class DataSelectPage : NitroxSaveParser.InitialPage
    {
        public static string Versionstr { get; set; }
        public DataSelectPage()
        {
            InitializeComponent();
            if (ReadWorldDataTrue)
            {
                ViewWorldData.Enabled = true; 
            }
            if (ReadBaseDataTrue) 
            {
                ViewBaseData.Enabled = true;
            }
            if (ReadPlayerDataTrue) 
            {
                ViewPlayerData.Enabled = true;
            }
        }

        private void ViewWorldData_Click(object sender, EventArgs e)
        {

        }

        private void ViewPlayerData_Click(object sender, EventArgs e)
        {

        }

        private void ViewBaseData_Click(object sender, EventArgs e)
        {

        }

        private void PlayerCount_Click(object sender, EventArgs e)
        {

        }
    }
}
