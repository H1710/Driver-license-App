using BusinessObejcts;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ProjectApp
{
    public partial class frmStaffDetail : Form
    {
        public frmStaffDetail()
        {
            InitializeComponent();
        }

        public IMember IMem { get; set; }
        public bool InsertOrUpdate { get; set; }
        public User StaffInfo { get; set; }

        private void frmStaffDetail_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate == true)
            {
                txtID.Text = StaffInfo.Id.ToString();
                txtName.Text = StaffInfo.Name.ToString();
                txtEmail.Text = StaffInfo.Email.ToString();
                txtPassword.Text = StaffInfo.Password.ToString();
                comboBox1.SelectedIndex = 0;

                
            }
            txtID.ReadOnly = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (InsertOrUpdate == false)
                {
                    var user = new User
                    {
                        Name = txtName.Text,
                        Email = txtEmail.Text,
                        Password = txtPassword.Text
                    };
                    string roleName = "Staff";
                    IMem.AddUser(user, 1);
                    MessageBox.Show("Create User successfully");
                    //ClearText();
                }
                else
                {
                    var user = new User
                    {
                        Id = int.Parse(txtID.Text),
                        Name = txtName.Text,
                        Email = txtEmail.Text,
                        Password = txtPassword.Text,
                        RoleId = 1
                    };
                    String roleName = comboBox1.Text;
                    int roleId = 1;
                    if (roleName == "Mentor") roleId = 2;
                    if (roleName == "Mentor") roleId = 3;
                    if (roleName == "Admin") roleId = 4;
                    IMem.updateMember(user, roleId);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("123");
            }
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
