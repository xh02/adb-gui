namespace adbGUI.Forms
{
    partial class Sideload
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_SideloadBrowse = new System.Windows.Forms.Button();
            this.txt_SideloadPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SideloadStart = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_SideloadBrowse);
            this.groupBox2.Controls.Add(this.txt_SideloadPath);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btn_SideloadStart);
            this.groupBox2.Location = new System.Drawing.Point(18, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(574, 89);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sideload";
            // 
            // btn_SideloadBrowse
            // 
            this.btn_SideloadBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SideloadBrowse.Location = new System.Drawing.Point(332, 46);
            this.btn_SideloadBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SideloadBrowse.Name = "btn_SideloadBrowse";
            this.btn_SideloadBrowse.Size = new System.Drawing.Size(112, 32);
            this.btn_SideloadBrowse.TabIndex = 1;
            this.btn_SideloadBrowse.Text = "打开文件";
            this.btn_SideloadBrowse.UseVisualStyleBackColor = true;
            this.btn_SideloadBrowse.Click += new System.EventHandler(this.Btn_SideloadBrowse_Click);
            // 
            // txt_SideloadPath
            // 
            this.txt_SideloadPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SideloadPath.Location = new System.Drawing.Point(9, 48);
            this.txt_SideloadPath.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SideloadPath.Name = "txt_SideloadPath";
            this.txt_SideloadPath.Size = new System.Drawing.Size(315, 28);
            this.txt_SideloadPath.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. 从sideload模式进入Recovery  2选择文件, 点击sideload 按钮";
            // 
            // btn_SideloadStart
            // 
            this.btn_SideloadStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SideloadStart.Location = new System.Drawing.Point(453, 46);
            this.btn_SideloadStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SideloadStart.Name = "btn_SideloadStart";
            this.btn_SideloadStart.Size = new System.Drawing.Size(112, 32);
            this.btn_SideloadStart.TabIndex = 2;
            this.btn_SideloadStart.Text = "Sideload";
            this.btn_SideloadStart.UseVisualStyleBackColor = true;
            this.btn_SideloadStart.Click += new System.EventHandler(this.Btn_SideloadStart_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Sideload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 122);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Sideload";
            this.ShowIcon = false;
            this.Text = "Sideload";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_SideloadBrowse;
        private System.Windows.Forms.TextBox txt_SideloadPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_SideloadStart;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}