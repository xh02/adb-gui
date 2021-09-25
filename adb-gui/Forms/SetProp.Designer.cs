namespace adbGUI.Forms
{
    partial class SetProp
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
            this.btn_setProp = new System.Windows.Forms.Button();
            this.txt_setPropKey = new System.Windows.Forms.TextBox();
            this.txt_setPropValue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_setProp
            // 
            this.btn_setProp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_setProp.Location = new System.Drawing.Point(780, 43);
            this.btn_setProp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_setProp.Name = "btn_setProp";
            this.btn_setProp.Size = new System.Drawing.Size(112, 32);
            this.btn_setProp.TabIndex = 0;
            this.btn_setProp.Text = "确定";
            this.btn_setProp.UseVisualStyleBackColor = true;
            this.btn_setProp.Click += new System.EventHandler(this.Btn_setProp_Click);
            // 
            // txt_setPropKey
            // 
            this.txt_setPropKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_setPropKey.Location = new System.Drawing.Point(14, 46);
            this.txt_setPropKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_setPropKey.Name = "txt_setPropKey";
            this.txt_setPropKey.Size = new System.Drawing.Size(566, 28);
            this.txt_setPropKey.TabIndex = 1;
            // 
            // txt_setPropValue
            // 
            this.txt_setPropValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_setPropValue.Location = new System.Drawing.Point(591, 46);
            this.txt_setPropValue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_setPropValue.Name = "txt_setPropValue";
            this.txt_setPropValue.Size = new System.Drawing.Size(182, 28);
            this.txt_setPropValue.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "关键字";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "值";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_setProp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_setPropKey);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_setPropValue);
            this.groupBox1.Location = new System.Drawing.Point(18, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(906, 91);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置配置";
            // 
            // SetProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 93);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1489, 149);
            this.MinimumSize = new System.Drawing.Size(946, 149);
            this.Name = "SetProp";
            this.ShowIcon = false;
            this.Text = "设置配置";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_setProp;
        private System.Windows.Forms.TextBox txt_setPropKey;
        private System.Windows.Forms.TextBox txt_setPropValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}