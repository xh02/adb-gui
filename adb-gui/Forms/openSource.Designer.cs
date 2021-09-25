
namespace adbGUI.Forms
{
    partial class openSource
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(openSource));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.License = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.License);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(698, 534);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "开源声明";
            // 
            // License
            // 
            this.License.AcceptsReturn = true;
            this.License.AcceptsTab = true;
            this.License.BackColor = System.Drawing.SystemColors.Window;
            this.License.Location = new System.Drawing.Point(17, 245);
            this.License.Multiline = true;
            this.License.Name = "License";
            this.License.ReadOnly = true;
            this.License.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.License.Size = new System.Drawing.Size(660, 283);
            this.License.TabIndex = 1;
            this.License.Text = "似乎许可证文件没了，要不去百度一下？";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Multiline = true;
            this.label1.Name = "label1";
            this.label1.ReadOnly = true;
            this.label1.Size = new System.Drawing.Size(660, 213);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // openSource
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(732, 573);
            this.Controls.Add(this.groupBox1);
            this.Name = "openSource";
            this.Text = "开源声明";
            this.Load += new System.EventHandler(this.openSource_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox License;
        private System.Windows.Forms.TextBox label1;
    }
}