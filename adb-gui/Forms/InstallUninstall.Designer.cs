﻿namespace adbGUI.Forms
{
    partial class InstallUninstall
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_InstallUninstallInstall = new System.Windows.Forms.Button();
            this.txt_InstallUninstallPackageInstall = new System.Windows.Forms.TextBox();
            this.btn_InstallUninstallBrowse = new System.Windows.Forms.Button();
            this.cbx_InstallUninstallPackageUninstall = new System.Windows.Forms.ComboBox();
            this.btn_InstallUninstallUninstall = new System.Windows.Forms.Button();
            this.btn_InstallUninstallRefreshApps = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_InstallUninstallInstall);
            this.groupBox3.Controls.Add(this.txt_InstallUninstallPackageInstall);
            this.groupBox3.Controls.Add(this.btn_InstallUninstallBrowse);
            this.groupBox3.Location = new System.Drawing.Point(22, 23);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox3.Size = new System.Drawing.Size(904, 91);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "安装";
            // 
            // btn_InstallUninstallInstall
            // 
            this.btn_InstallUninstallInstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_InstallUninstallInstall.Location = new System.Drawing.Point(755, 35);
            this.btn_InstallUninstallInstall.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_InstallUninstallInstall.Name = "btn_InstallUninstallInstall";
            this.btn_InstallUninstallInstall.Size = new System.Drawing.Size(137, 43);
            this.btn_InstallUninstallInstall.TabIndex = 2;
            this.btn_InstallUninstallInstall.Text = "安装";
            this.btn_InstallUninstallInstall.UseVisualStyleBackColor = true;
            this.btn_InstallUninstallInstall.Click += new System.EventHandler(this.Btn_InstallUninstallInstall_Click);
            // 
            // txt_InstallUninstallPackageInstall
            // 
            this.txt_InstallUninstallPackageInstall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_InstallUninstallPackageInstall.Location = new System.Drawing.Point(11, 39);
            this.txt_InstallUninstallPackageInstall.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txt_InstallUninstallPackageInstall.Name = "txt_InstallUninstallPackageInstall";
            this.txt_InstallUninstallPackageInstall.Size = new System.Drawing.Size(581, 30);
            this.txt_InstallUninstallPackageInstall.TabIndex = 0;
            // 
            // btn_InstallUninstallBrowse
            // 
            this.btn_InstallUninstallBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_InstallUninstallBrowse.Location = new System.Drawing.Point(606, 35);
            this.btn_InstallUninstallBrowse.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_InstallUninstallBrowse.Name = "btn_InstallUninstallBrowse";
            this.btn_InstallUninstallBrowse.Size = new System.Drawing.Size(137, 43);
            this.btn_InstallUninstallBrowse.TabIndex = 1;
            this.btn_InstallUninstallBrowse.Text = "浏览...";
            this.btn_InstallUninstallBrowse.UseVisualStyleBackColor = true;
            this.btn_InstallUninstallBrowse.Click += new System.EventHandler(this.Btn_InstallUninstallBrowse_Click);
            // 
            // cbx_InstallUninstallPackageUninstall
            // 
            this.cbx_InstallUninstallPackageUninstall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbx_InstallUninstallPackageUninstall.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbx_InstallUninstallPackageUninstall.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_InstallUninstallPackageUninstall.FormattingEnabled = true;
            this.cbx_InstallUninstallPackageUninstall.Location = new System.Drawing.Point(11, 37);
            this.cbx_InstallUninstallPackageUninstall.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cbx_InstallUninstallPackageUninstall.Name = "cbx_InstallUninstallPackageUninstall";
            this.cbx_InstallUninstallPackageUninstall.Size = new System.Drawing.Size(676, 32);
            this.cbx_InstallUninstallPackageUninstall.TabIndex = 6;
            // 
            // btn_InstallUninstallUninstall
            // 
            this.btn_InstallUninstallUninstall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_InstallUninstallUninstall.Location = new System.Drawing.Point(755, 35);
            this.btn_InstallUninstallUninstall.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_InstallUninstallUninstall.Name = "btn_InstallUninstallUninstall";
            this.btn_InstallUninstallUninstall.Size = new System.Drawing.Size(137, 43);
            this.btn_InstallUninstallUninstall.TabIndex = 5;
            this.btn_InstallUninstallUninstall.Text = "卸载";
            this.btn_InstallUninstallUninstall.UseVisualStyleBackColor = true;
            this.btn_InstallUninstallUninstall.Click += new System.EventHandler(this.Btn_InstallUninstallUninstall_Click);
            // 
            // btn_InstallUninstallRefreshApps
            // 
            this.btn_InstallUninstallRefreshApps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_InstallUninstallRefreshApps.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_InstallUninstallRefreshApps.Location = new System.Drawing.Point(702, 35);
            this.btn_InstallUninstallRefreshApps.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_InstallUninstallRefreshApps.Name = "btn_InstallUninstallRefreshApps";
            this.btn_InstallUninstallRefreshApps.Size = new System.Drawing.Size(42, 43);
            this.btn_InstallUninstallRefreshApps.TabIndex = 5;
            this.btn_InstallUninstallRefreshApps.UseVisualStyleBackColor = true;
            this.btn_InstallUninstallRefreshApps.Click += new System.EventHandler(this.Btn_InstallUninstallRefreshApps_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbx_InstallUninstallPackageUninstall);
            this.groupBox1.Controls.Add(this.btn_InstallUninstallUninstall);
            this.groupBox1.Controls.Add(this.btn_InstallUninstallRefreshApps);
            this.groupBox1.Location = new System.Drawing.Point(22, 124);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(904, 95);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "卸载";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // InstallUninstall
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 241);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "InstallUninstall";
            this.ShowIcon = false;
            this.Text = "安装和卸载";
            this.Load += new System.EventHandler(this.InstallUninstall_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.InstallUninstall_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.InstallUninstall_DragEnter);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_InstallUninstallInstall;
        private System.Windows.Forms.Button btn_InstallUninstallRefreshApps;
        private System.Windows.Forms.Button btn_InstallUninstallUninstall;
        private System.Windows.Forms.TextBox txt_InstallUninstallPackageInstall;
        private System.Windows.Forms.Button btn_InstallUninstallBrowse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ComboBox cbx_InstallUninstallPackageUninstall;
    }
}