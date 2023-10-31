using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Repository;
using BusinessObjects;

namespace Project_App
{
    public partial class frmLogin : Form
    {
        IUser manageUser = new UserRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User u = manageUser.checkLogin(txtEmail.Text, txtPassword.Text);
            if (u != null && u.RoleId == 1)
            {
                frmProfileUser f = new frmProfileUser();
                f.ShowDialog();
            }
        }
    }
}
