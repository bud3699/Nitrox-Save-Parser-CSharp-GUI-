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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DataViewer = new System.Windows.Forms.Label();
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
            this.DataViewer.Click += new System.EventHandler(this.label1_Click);
            this.DataViewer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.DataViewer.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.DataViewer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            // 
            // DataSelectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.DataViewer);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DataSelectPage";
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.DataViewer, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DataViewer;
    }
}
