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
    public partial class frmHillEncrypte : Form
    {
        public frmHillEncrypte()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            frmSendEmail frm = new frmSendEmail();
            frm.ShowDialog();
        }
    }
}
