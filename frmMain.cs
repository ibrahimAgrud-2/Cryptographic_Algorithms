using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KriptolojiOdevi
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form frm = new frmHillEncrypt();
            frm.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
                Form frm = new frmHillDescrypt();
                frm.ShowDialog();
            }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {

            Form frm = new frmSendEmail();
            frm.ShowDialog();
        }
    }
}
