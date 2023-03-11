using System.Runtime.InteropServices;
using System;

namespace NitroxSaveParser.DataParse
{
    partial class DataSelectPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        string versionString ="World Version: "+VersionData.Versionstr;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }



        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DataViewer = new System.Windows.Forms.Label();
            this.ViewWorldData = new System.Windows.Forms.Button();
            this.ViewPlayerData = new System.Windows.Forms.Button();
            this.ViewBaseData = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.VersionNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(22)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(12, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(776, 335);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // DataViewer
            // 
            this.DataViewer.AutoSize = true;
            this.DataViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(22)))));
            this.DataViewer.Font = new System.Drawing.Font("Impact", 12.25F, System.Drawing.FontStyle.Bold);
            this.DataViewer.ForeColor = System.Drawing.Color.White;
            this.DataViewer.Location = new System.Drawing.Point(315, 17);
            this.DataViewer.Name = "DataViewer";
            this.DataViewer.Size = new System.Drawing.Size(137, 25);
            this.DataViewer.TabIndex = 22;
            this.DataViewer.Text = "Nitrox Data Viewer";
            this.DataViewer.UseCompatibleTextRendering = true;
            // 
            // ViewWorldData
            // 
            this.ViewWorldData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.ViewWorldData.Enabled = false;
            this.ViewWorldData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ViewWorldData.ForeColor = System.Drawing.Color.White;
            this.ViewWorldData.Location = new System.Drawing.Point(309, 119);
            this.ViewWorldData.Name = "ViewWorldData";
            this.ViewWorldData.Size = new System.Drawing.Size(170, 50);
            this.ViewWorldData.TabIndex = 23;
            this.ViewWorldData.Text = "View World Data";
            this.ViewWorldData.UseVisualStyleBackColor = false;
            this.ViewWorldData.Click += new System.EventHandler(this.ViewWorldData_Click);
            // 
            // ViewPlayerData
            // 
            this.ViewPlayerData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.ViewPlayerData.Enabled = false;
            this.ViewPlayerData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ViewPlayerData.ForeColor = System.Drawing.Color.White;
            this.ViewPlayerData.Location = new System.Drawing.Point(309, 192);
            this.ViewPlayerData.Name = "ViewPlayerData";
            this.ViewPlayerData.Size = new System.Drawing.Size(170, 50);
            this.ViewPlayerData.TabIndex = 24;
            this.ViewPlayerData.Text = "View Player Data";
            this.ViewPlayerData.UseVisualStyleBackColor = false;
            this.ViewPlayerData.Click += new System.EventHandler(this.ViewPlayerData_Click);
            // 
            // ViewBaseData
            // 
            this.ViewBaseData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.ViewBaseData.Enabled = false;
            this.ViewBaseData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ViewBaseData.ForeColor = System.Drawing.Color.White;
            this.ViewBaseData.Location = new System.Drawing.Point(309, 269);
            this.ViewBaseData.Name = "ViewBaseData";
            this.ViewBaseData.Size = new System.Drawing.Size(170, 50);
            this.ViewBaseData.TabIndex = 25;
            this.ViewBaseData.Text = "View Base Data";
            this.ViewBaseData.UseVisualStyleBackColor = false;
            this.ViewBaseData.Click += new System.EventHandler(this.ViewBaseData_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // VersionNum
            // 
            this.VersionNum.AutoSize = true;
            this.VersionNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(22)))));
            this.VersionNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.VersionNum.Location = new System.Drawing.Point(305, 77);
            this.VersionNum.Name = "VersionNum";
            this.VersionNum.Size = new System.Drawing.Size(188, 22);
            this.VersionNum.TabIndex = 27;
            this.VersionNum.Text = versionString;
            // 
            // DataSelectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.VersionNum);
            this.Controls.Add(this.ViewBaseData);
            this.Controls.Add(this.ViewPlayerData);
            this.Controls.Add(this.ViewWorldData);
            this.Controls.Add(this.DataViewer);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DataSelectPage";
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.DataViewer, 0);
            this.Controls.SetChildIndex(this.ViewWorldData, 0);
            this.Controls.SetChildIndex(this.ViewPlayerData, 0);
            this.Controls.SetChildIndex(this.ViewBaseData, 0);
            this.Controls.SetChildIndex(this.VersionNum, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DataViewer;
        private System.Windows.Forms.Button ViewWorldData;
        private System.Windows.Forms.Button ViewPlayerData;
        private System.Windows.Forms.Button ViewBaseData;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label VersionNum;
    }
}
