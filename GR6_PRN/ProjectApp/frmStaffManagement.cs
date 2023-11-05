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

namespace ProjectApp
{
    public partial class frmStaffManagement : Form
    {
        IMember IMem = new MemberRepository();
        BindingSource source;
        public frmStaffManagement()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void LoadStaffList()
        {
            var staffs = IMem.getAllStaff();
            try
            {
                source = new BindingSource();
                source.DataSource = staffs;

                txtUserID.DataBindings.Clear();
                txtUserEmail.DataBindings.Clear();
                txtUserName.DataBindings.Clear();
                txtPassword.DataBindings.Clear();
                txtRole.DataBindings.Clear();

                txtUserID.DataBindings.Add("Text", source, "id");
                txtUserEmail.DataBindings.Add("Text", source, "email");
                txtUserName.DataBindings.Add("Text", source, "name");
                txtPassword.DataBindings.Add("Text", source, "password");
                txtRole.DataBindings.Add("Text", source, "role");


                dgvStaffList.DataSource = source;
                dgvStaffList.Columns["RoleID"].Visible = false;
                if (staffs.Count() == 0)
                {

                }
                else
                {

                }


            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmStaffManagement_Load(object sender, EventArgs e)
        {
            LoadStaffList();
            dgvStaffList.CellDoubleClick += DgvStaffList_CellDoubleClick;
        }

        private void DgvStaffList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmStaffDetail frmStaffDetail = new frmStaffDetail
            {
                Text = "Update staff",
                InsertOrUpdate = true,
                StaffInfo = GetUserObject(),
                IMem = IMem
            };
            if (frmStaffDetail.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                LoadStaffList();
                source.Position = source.Count - 1;
            }
            LoadStaffList();
        }

        private User GetUserObject()
        {
            User user = null;
            try
            {
                user = new User
                {
                    Id = int.Parse(txtUserID.Text),
                    Name = txtUserName.Text,
                    Email = txtUserEmail.Text,
                    Password = txtPassword.Text,
                    Role = new Role
                    {
                        Name = txtRole.Text
                    }
                };
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            return user;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmStaffDetail frmStaffDetail = new frmStaffDetail
            {
                Text = "Add Staff",
                InsertOrUpdate = false,
                IMem = IMem
            };
            if (frmStaffDetail.ShowDialog() == DialogResult.Cancel)
            {
                LoadStaffList();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int userId = int.Parse(txtUserID.Text);
            if (userId != 0)
            {
                IMem.DeleteUser(userId);
            }
            LoadStaffList();
        }
    }
}
