using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MdiApplication
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            InitializeComponent();
        }

        private void ChildTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toogleForegroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ToogleMenuItem.Checked == true)
            {
                ToogleMenuItem.Checked = false;
                ChildTextBox.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                ToogleMenuItem.Checked = true;
                ChildTextBox.ForeColor = System.Drawing.Color.Blue;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
             
        }
    }
}
