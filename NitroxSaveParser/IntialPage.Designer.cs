using System.Reflection;
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
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ReadData
            // 
            this.ReadData.Enabled = false;
            this.ReadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.ReadData.Location = new System.Drawing.Point(183, 288);
            this.ReadData.Name = "ReadData";
            this.ReadData.Size = new System.Drawing.Size(115, 30);
            this.ReadData.TabIndex = 3;
            this.ReadData.Text = "Read Data";
            this.ReadData.UseVisualStyleBackColor = true;
            this.ReadData.Click += new System.EventHandler(this.ReadData_Click);
            // 
            // WorldData
            // 
            this.WorldData.AutoSize = true;
            this.WorldData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.WorldData.Location = new System.Drawing.Point(118, 177);
            this.WorldData.Name = "WorldData";
            this.WorldData.Size = new System.Drawing.Size(171, 28);
            this.WorldData.TabIndex = 6;
            this.WorldData.Text = "Read World Data";
            this.WorldData.UseVisualStyleBackColor = true;
            this.WorldData.CheckedChanged += new System.EventHandler(this.WorldData_CheckedChanged);
            // 
            // PlayerData
            // 
            this.PlayerData.AutoSize = true;
            this.PlayerData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.PlayerData.Location = new System.Drawing.Point(315, 177);
            this.PlayerData.Name = "PlayerData";
            this.PlayerData.Size = new System.Drawing.Size(173, 28);
            this.PlayerData.TabIndex = 7;
            this.PlayerData.Text = "Read Player Data";
            this.PlayerData.UseVisualStyleBackColor = true;
            this.PlayerData.CheckedChanged += new System.EventHandler(this.PlayerData_CheckedChanged_1);
            // 
            // BaseData
            // 
            this.BaseData.AutoSize = true;
            this.BaseData.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BaseData.Location = new System.Drawing.Point(513, 177);
            this.BaseData.Name = "BaseData";
            this.BaseData.Size = new System.Drawing.Size(163, 28);
            this.BaseData.TabIndex = 8;
            this.BaseData.Text = "Read Base Data";
            this.BaseData.UseVisualStyleBackColor = true;
            this.BaseData.CheckedChanged += new System.EventHandler(this.BaseData_CheckedChanged);
            // 
            // Found
            // 
            this.Found.AutoSize = true;
            this.Found.Enabled = false;
            this.Found.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Found.ForeColor = System.Drawing.Color.Lime;
            this.Found.Location = new System.Drawing.Point(326, 116);
            this.Found.Name = "Found";
            this.Found.Size = new System.Drawing.Size(146, 27);
            this.Found.TabIndex = 9;
            this.Found.Text = "Found Directory";
            this.Found.UseCompatibleTextRendering = true;
            this.Found.Visible = false;
            this.Found.Click += new System.EventHandler(this.label1_Click);
            // 
            // DirBox
            // 
            this.DirBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.DirBox.Location = new System.Drawing.Point(315, 41);
            this.DirBox.Name = "DirBox";
            this.DirBox.Size = new System.Drawing.Size(173, 50);
            this.DirBox.TabIndex = 10;
            this.DirBox.Text = "Select Directory";
            this.DirBox.UseVisualStyleBackColor = true;
            this.DirBox.Click += new System.EventHandler(this.button1_Click);
            // 
            // NotFound
            // 
            this.NotFound.AutoSize = true;
            this.NotFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.NotFound.ForeColor = System.Drawing.Color.Red;
            this.NotFound.Location = new System.Drawing.Point(312, 116);
            this.NotFound.Name = "NotFound";
            this.NotFound.Size = new System.Drawing.Size(176, 27);
            this.NotFound.TabIndex = 11;
            this.NotFound.Text = "No Directory Found";
            this.NotFound.UseCompatibleTextRendering = true;
            // 
            // IntialPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.NotFound);
            this.Controls.Add(this.DirBox);
            this.Controls.Add(this.Found);
            this.Controls.Add(this.BaseData);
            this.Controls.Add(this.PlayerData);
            this.Controls.Add(this.WorldData);
            this.Controls.Add(this.ReadData);
            this.Name = "IntialPage";
            this.Text = "Nitrox Save Parser";
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
    }
}

