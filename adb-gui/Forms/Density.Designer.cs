﻿namespace adbGUI.Forms
{
    partial class Density
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
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btn_resetDpi = new System.Windows.Forms.Button();
            this.btn_showDpi = new System.Windows.Forms.Button();
            this.btn_setDpi = new System.Windows.Forms.Button();
            this.txt_phoneDpi = new System.Windows.Forms.TextBox();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btn_resetDpi);
            this.groupBox9.Controls.Add(this.btn_showDpi);
            this.groupBox9.Controls.Add(this.btn_setDpi);
            this.groupBox9.Controls.Add(this.txt_phoneDpi);
            this.groupBox9.Location = new System.Drawing.Point(18, 17);
            this.groupBox9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox9.Size = new System.Drawing.Size(524, 68);
            this.groupBox9.TabIndex = 14;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "更改dpi";
            // 
            // btn_resetDpi
            // 
            this.btn_resetDpi.Location = new System.Drawing.Point(279, 26);
            this.btn_resetDpi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_resetDpi.Name = "btn_resetDpi";
            this.btn_resetDpi.Size = new System.Drawing.Size(112, 32);
            this.btn_resetDpi.TabIndex = 31;
            this.btn_resetDpi.Text = "重置";
            this.btn_resetDpi.UseVisualStyleBackColor = true;
            this.btn_resetDpi.Click += new System.EventHandler(this.Btn_resetDpi_Click);
            // 
            // btn_showDpi
            // 
            this.btn_showDpi.Location = new System.Drawing.Point(400, 26);
            this.btn_showDpi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_showDpi.Name = "btn_showDpi";
            this.btn_showDpi.Size = new System.Drawing.Size(112, 32);
            this.btn_showDpi.TabIndex = 30;
            this.btn_showDpi.Text = "当前dpi";
            this.btn_showDpi.UseVisualStyleBackColor = true;
            this.btn_showDpi.Click += new System.EventHandler(this.Btn_showDpi_Click);
            // 
            // btn_setDpi
            // 
            this.btn_setDpi.Location = new System.Drawing.Point(158, 26);
            this.btn_setDpi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_setDpi.Name = "btn_setDpi";
            this.btn_setDpi.Size = new System.Drawing.Size(112, 32);
            this.btn_setDpi.TabIndex = 29;
            this.btn_setDpi.Text = "确定";
            this.btn_setDpi.UseVisualStyleBackColor = true;
            this.btn_setDpi.Click += new System.EventHandler(this.Btn_setDpi_Click);
            // 
            // txt_phoneDpi
            // 
            this.txt_phoneDpi.Location = new System.Drawing.Point(9, 29);
            this.txt_phoneDpi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_phoneDpi.Name = "txt_phoneDpi";
            this.txt_phoneDpi.Size = new System.Drawing.Size(138, 28);
            this.txt_phoneDpi.TabIndex = 28;
            this.txt_phoneDpi.Text = "480";
            // 
            // Density
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 101);
            this.Controls.Add(this.groupBox9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Density";
            this.ShowIcon = false;
            this.Text = "更改dpi";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DpiChange_KeyDown);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Button btn_resetDpi;
        private System.Windows.Forms.Button btn_showDpi;
        private System.Windows.Forms.Button btn_setDpi;
        private System.Windows.Forms.TextBox txt_phoneDpi;
    }
}