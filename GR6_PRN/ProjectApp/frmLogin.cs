using Repository;
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
using BusinessObejcts;
namespace ProjectApp
{
    public partial class frmLogin : Form
    {
        IMember iMem = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User u = iMem.checkLogin(txtEmail.Text, txtPass.Text);
            
            if (u != null )
            {
                if(u.RoleId == 1)
                {
                    frmMember f = new frmMember()
                    {
                        user = u,
                    };
                    f.ShowDialog();
                }
                if(u.RoleId == 4)
                {
                    frmAdmin f = new frmAdmin();
                    f.ShowDialog();
                }
                
            }
            else
            {
                
                MessageBox.Show("Login Failed");
            }
        }
    }
}
