using System;
using System.IO;

namespace adbGUI.Forms
{
    public partial class openSource :ExtForm
    {
        public openSource()
        {
            InitializeComponent();
            label1.Select(0, 0);
        }

        private void openSource_Load(object sender, EventArgs e)
        {
            try
            {
                License.Text = File.ReadAllText("LICENSE");
            }
            catch { }
                  
        }
    }
}
