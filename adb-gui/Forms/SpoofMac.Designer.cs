namespace adbGUI.Forms
{
    partial class SpoofMAc
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btn_SpoofMacReset = new System.Windows.Forms.Button();
            this.btn_SpoofMacSet = new System.Windows.Forms.Button();
            this.btn_SpoofMacShow = new System.Windows.Forms.Button();
            this.txt_SpoofMacAdress = new System.Windows.Forms.TextBox();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btn_SpoofMacReset);
            this.groupBox6.Controls.Add(this.btn_SpoofMacSet);
            this.groupBox6.Controls.Add(this.btn_SpoofMacShow);
            this.groupBox6.Controls.Add(this.txt_SpoofMacAdress);
            this.groupBox6.Location = new System.Drawing.Point(18, 17);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(536, 68);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "伪装Mac";
            // 
            // btn_SpoofMacReset
            // 
            this.btn_SpoofMacReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_SpoofMacReset.Location = new System.Drawing.Point(248, 25);
            this.btn_SpoofMacReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SpoofMacReset.Name = "btn_SpoofMacReset";
            this.btn_SpoofMacReset.Size = new System.Drawing.Size(70, 30);
            this.btn_SpoofMacReset.TabIndex = 27;
            this.btn_SpoofMacReset.Text = "重置";
            this.btn_SpoofMacReset.UseVisualStyleBackColor = true;
            this.btn_SpoofMacReset.Click += new System.EventHandler(this.Btn_SpoofMacReset_Click);
            // 
            // btn_SpoofMacSet
            // 
            this.btn_SpoofMacSet.Location = new System.Drawing.Point(170, 25);
            this.btn_SpoofMacSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SpoofMacSet.Name = "btn_SpoofMacSet";
            this.btn_SpoofMacSet.Size = new System.Drawing.Size(70, 30);
            this.btn_SpoofMacSet.TabIndex = 25;
            this.btn_SpoofMacSet.Text = "确定";
            this.btn_SpoofMacSet.UseVisualStyleBackColor = true;
            this.btn_SpoofMacSet.Click += new System.EventHandler(this.Btn_SpoofMacSet_Click);
            // 
            // btn_SpoofMacShow
            // 
            this.btn_SpoofMacShow.Location = new System.Drawing.Point(326, 25);
            this.btn_SpoofMacShow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SpoofMacShow.Name = "btn_SpoofMacShow";
            this.btn_SpoofMacShow.Size = new System.Drawing.Size(129, 30);
            this.btn_SpoofMacShow.TabIndex = 26;
            this.btn_SpoofMacShow.Text = "显示当前Mac";
            this.btn_SpoofMacShow.UseVisualStyleBackColor = true;
            this.btn_SpoofMacShow.Click += new System.EventHandler(this.Btn_SpoofMacShow_Click);
            // 
            // txt_SpoofMacAdress
            // 
            this.txt_SpoofMacAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_SpoofMacAdress.Location = new System.Drawing.Point(9, 26);
            this.txt_SpoofMacAdress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SpoofMacAdress.Name = "txt_SpoofMacAdress";
            this.txt_SpoofMacAdress.Size = new System.Drawing.Size(150, 26);
            this.txt_SpoofMacAdress.TabIndex = 24;
            this.txt_SpoofMacAdress.Text = "00:11:22:33:44:55";
            this.txt_SpoofMacAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_SpoofMacAdress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_SpoofMacAdress_KeyDown);
            // 
            // SpoofMAc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 101);
            this.Controls.Add(this.groupBox6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "SpoofMAc";
            this.Text = "Mac伪装";
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btn_SpoofMacReset;
        private System.Windows.Forms.Button btn_SpoofMacSet;
        private System.Windows.Forms.Button btn_SpoofMacShow;
        private System.Windows.Forms.TextBox txt_SpoofMacAdress;
    }
}