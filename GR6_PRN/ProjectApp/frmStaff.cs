using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectApp
{
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {

        }

        private void btnQuestion_Click(object sender, EventArgs e)
        {
            frmQuestion frm = new frmQuestion();
            frm.ShowDialog();
            this.Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
