using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adbGUI.Forms
{
	public class ExtForm : Form
	{
		protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
		{
			switch (keyData)
			{
				case Keys.Escape:
					Debug.WriteLine("Keypress detected. Closing ExtForm...");
					Close();
					return true;
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ExtForm
            // 
            this.ClientSize = new System.Drawing.Size(278, 244);
            this.Name = "ExtForm";
            this.Load += new System.EventHandler(this.ExtForm_Load);
            this.ResumeLayout(false);

        }

        private void ExtForm_Load(object sender, EventArgs e)
        {

        }
    }
}
