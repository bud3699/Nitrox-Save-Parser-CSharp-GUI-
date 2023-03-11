using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace NitroxSaveParser
{
    partial class IntialPage
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
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReadData = new System.Windows.Forms.Button();
            this.WorldData = new System.Windows.Forms.CheckBox();
            this.PlayerData = new System.Windows.Forms.CheckBox();
            this.BaseData = new System.Windows.Forms.CheckBox();
            this.Found = new System.Windows.Forms.Label();
            this.DirBox = new System.Windows.Forms.Button();
            this.NotFound = new System.Windows.Forms.Label();
            this.MadeByBud = new System.Windows.Forms.Label();
            this.ButtonBox = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.Button();
            this.Minimise = new System.Windows.Forms.Button();
            this.Version = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NitroxText = new System.Windows.Forms.Label();
            this.Corner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ReadData
            // 
            this.ReadData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.ReadData.Enabled = false;
            this.ReadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ReadData.Location = new System.Drawing.Point(324, 315);
            this.ReadData.Name = "ReadData";
            this.ReadData.Size = new System.Drawing.Size(146, 37);
            this.ReadData.TabIndex = 3;
            this.ReadData.Text = "Read Data";
            this.ReadData.UseVisualStyleBackColor = false;
            this.ReadData.Click += new System.EventHandler(this.ReadData_Click);
            // 
            // WorldData
            // 
            this.WorldData.AutoSize = true;
            this.WorldData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(22)))));
            this.WorldData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.WorldData.Location = new System.Drawing.Point(118, 177);
            this.WorldData.Name = "WorldData";
            this.WorldData.Size = new System.Drawing.Size(171, 28);
            this.WorldData.TabIndex = 6;
            this.WorldData.Text = "Read World Data";
            this.WorldData.UseVisualStyleBackColor = false;
            this.WorldData.CheckedChanged += new System.EventHandler(this.WorldData_CheckedChanged);
            // 
            // PlayerData
            // 
            this.PlayerData.AutoSize = true;
            this.PlayerData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(22)))));
            this.PlayerData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.PlayerData.Location = new System.Drawing.Point(309, 177);
            this.PlayerData.Name = "PlayerData";
            this.PlayerData.Size = new System.Drawing.Size(173, 28);
            this.PlayerData.TabIndex = 7;
            this.PlayerData.Text = "Read Player Data";
            this.PlayerData.UseVisualStyleBackColor = false;
            this.PlayerData.CheckedChanged += new System.EventHandler(this.PlayerData_CheckedChanged_1);
            // 
            // BaseData
            // 
            this.BaseData.AutoSize = true;
            this.BaseData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(22)))));
            this.BaseData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BaseData.Location = new System.Drawing.Point(513, 177);
            this.BaseData.Name = "BaseData";
            this.BaseData.Size = new System.Drawing.Size(163, 28);
            this.BaseData.TabIndex = 8;
            this.BaseData.Text = "Read Base Data";
            this.BaseData.UseVisualStyleBackColor = false;
            this.BaseData.CheckedChanged += new System.EventHandler(this.BaseData_CheckedChanged);
            // 
            // Found
            // 
            this.Found.AutoSize = true;
            this.Found.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(22)))));
            this.Found.Enabled = false;
            this.Found.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Found.ForeColor = System.Drawing.Color.Lime;
            this.Found.Location = new System.Drawing.Point(324, 89);
            this.Found.Name = "Found";
            this.Found.Size = new System.Drawing.Size(149, 27);
            this.Found.TabIndex = 9;
            this.Found.Text = "Found Save File";
            this.Found.UseCompatibleTextRendering = true;
            this.Found.Visible = false;
            this.Found.Click += new System.EventHandler(this.label1_Click);
            // 
            // DirBox
            // 
            this.DirBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(43)))));
            this.DirBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.DirBox.ForeColor = System.Drawing.Color.White;
            this.DirBox.Location = new System.Drawing.Point(315, 248);
            this.DirBox.Name = "DirBox";
            this.DirBox.Size = new System.Drawing.Size(170, 50);
            this.DirBox.TabIndex = 10;
            this.DirBox.Text = "Select Directory";
            this.DirBox.UseVisualStyleBackColor = false;
            this.DirBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // NotFound
            // 
            this.NotFound.AutoSize = true;
            this.NotFound.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(22)))));
            this.NotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.NotFound.ForeColor = System.Drawing.Color.Red;
            this.NotFound.Location = new System.Drawing.Point(328, 89);
            this.NotFound.Name = "NotFound";
            this.NotFound.Size = new System.Drawing.Size(142, 27);
            this.NotFound.TabIndex = 11;
            this.NotFound.Text = "No Save Found";
            this.NotFound.UseCompatibleTextRendering = true;
            this.NotFound.Click += new System.EventHandler(this.NotFound_Click);
            // 
            // MadeByBud
            // 
            this.MadeByBud.AutoSize = true;
            this.MadeByBud.Location = new System.Drawing.Point(726, 429);
            this.MadeByBud.Name = "MadeByBud";
            this.MadeByBud.Size = new System.Drawing.Size(71, 13);
            this.MadeByBud.TabIndex = 12;
            this.MadeByBud.Text = "Made By Bud";
            // 
            // ButtonBox
            // 
            this.ButtonBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(22)))));
            this.ButtonBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ButtonBox.Location = new System.Drawing.Point(12, 48);
            this.ButtonBox.Name = "ButtonBox";
            this.ButtonBox.Padding = new System.Windows.Forms.Padding(10);
            this.ButtonBox.Size = new System.Drawing.Size(776, 335);
            this.ButtonBox.TabIndex = 13;
            this.ButtonBox.TabStop = false;
            this.ButtonBox.Click += new System.EventHandler(this.ButtonBox_Click);
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.DimGray;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(760, 13);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(27, 27);
            this.Close.TabIndex = 14;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Minimise
            // 
            this.Minimise.BackColor = System.Drawing.Color.DimGray;
            this.Minimise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold);
            this.Minimise.ForeColor = System.Drawing.Color.White;
            this.Minimise.Location = new System.Drawing.Point(726, 13);
            this.Minimise.Name = "Minimise";
            this.Minimise.Size = new System.Drawing.Size(27, 27);
            this.Minimise.TabIndex = 15;
            this.Minimise.Text = "-";
            this.Minimise.UseVisualStyleBackColor = false;
            this.Minimise.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Version
            // 
            this.Version.AutoSize = true;
            this.Version.Location = new System.Drawing.Point(9, 429);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(81, 13);
            this.Version.TabIndex = 16;
            this.Version.Text = "Version: 1.0.0.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(22)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(776, 30);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // NitroxText
            // 
            this.NitroxText.AutoSize = true;
            this.NitroxText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(22)))));
            this.NitroxText.Font = new System.Drawing.Font("Impact", 12.25F, System.Drawing.FontStyle.Bold);
            this.NitroxText.ForeColor = System.Drawing.Color.White;
            this.NitroxText.Location = new System.Drawing.Point(12, 16);
            this.NitroxText.Name = "NitroxText";
            this.NitroxText.Size = new System.Drawing.Size(137, 25);
            this.NitroxText.TabIndex = 19;
            this.NitroxText.Text = "Nitrox Save Parser";
            this.NitroxText.UseCompatibleTextRendering = true;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, 800, 451, 20, 20));

            // 
            // Corner
            // 
            this.Corner.AutoSize = true;
            this.Corner.BackColor = System.Drawing.Color.Black;
            this.Corner.ForeColor = System.Drawing.Color.Black;
            this.Corner.Location = new System.Drawing.Point(763, 436);
            this.Corner.Name = "Corner";
            this.Corner.Size = new System.Drawing.Size(34, 13);
            this.Corner.TabIndex = 20;
            this.Corner.Text = "Blank";
            // 
            // IntialPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.NitroxText);
            this.Controls.Add(this.Version);
            this.Controls.Add(this.Minimise);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.MadeByBud);
            this.Controls.Add(this.NotFound);
            this.Controls.Add(this.DirBox);
            this.Controls.Add(this.Found);
            this.Controls.Add(this.BaseData);
            this.Controls.Add(this.PlayerData);
            this.Controls.Add(this.WorldData);
            this.Controls.Add(this.ReadData);
            this.Controls.Add(this.ButtonBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Corner);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "IntialPage";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Nitrox Save Parser";
            this.Load += new System.EventHandler(this.IntialPage_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button ReadData;
        private System.Windows.Forms.CheckBox WorldData;
        private System.Windows.Forms.CheckBox PlayerData;
        private System.Windows.Forms.CheckBox BaseData;
        private Label Found;
        private Button DirBox;
        private Label NotFound;
        private Label MadeByBud;
        private PictureBox ButtonBox;
        private Button Close;
        private Button Minimise;
        private Label Version;
        private PictureBox pictureBox1;
        private ContextMenuStrip contextMenuStrip2;
        private Label NitroxText;
        private Label Corner;
    }
}

