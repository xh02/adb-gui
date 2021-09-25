using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adbGUI.Forms
{
    public partial class author : ExtForm
    {
        public author()
        {
            InitializeComponent();
        }

        private void author_Load(object sender, EventArgs e)
        {
            textBox1.Select(0, 0);
        }
    }
}
