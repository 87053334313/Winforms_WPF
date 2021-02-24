using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinQuestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Мы и не сомневались, что Вы так думаете !");
        }

        private void btnNo_MouseMove(object sender, MouseEventArgs e)
        {
            btnNo.Top = btnNo.Top-e.Y;
            btnNo.Left = btnNo.Left+e.X;
            if (btnNo.Top < -10 || btnNo.Top > 100)
                btnNo.Top = 60;
            if (btnNo.Left < -80 || btnNo.Left > 250)
                btnNo.Left = 120;
          
        }
    }
}
