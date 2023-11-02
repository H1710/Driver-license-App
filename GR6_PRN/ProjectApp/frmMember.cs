using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObejcts;
using Repository;

namespace ProjectApp
{
    public partial class frmMember : Form
    {
        public User user { get; set; }
        public frmMember()
        {
            InitializeComponent();
        }
        IMember manaMem = new MemberRepository();
        BindingSource source = new BindingSource();

        public void loadMember()
        {
            try
            {
                if (user != null)
                {
                    source.DataSource = user;

                    txtId.DataBindings.Clear();
                    txtEmail.DataBindings.Clear();
                    txtPass.DataBindings.Clear();
                    txtName.DataBindings.Clear();
                    txtRole.DataBindings.Clear();

                    txtId.Enabled = false;
                    txtEmail.Enabled = false;
                    txtPass.Enabled = false;
                    txtName.Enabled = false;
                    txtRole.Enabled = false;

                    txtId.DataBindings.Add("Text", source, "Id");
                    txtEmail.DataBindings.Add("Text", source, "Email");
                    txtPass.DataBindings.Add("Text", source, "Password");
                    txtName.DataBindings.Add("Text", source, "Name");
                    txtRole.DataBindings.Add("Text", source, "RoleId");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member");
            }
        }

        public User getObjects()
        {
            User u = new User()
            {
                Id = int.Parse(txtId.Text),
                Email = txtEmail.Text,
                Password = txtPass.Text,
                Name = txtName.Text,
                RoleId = int.Parse(txtRole.Text),
            };
            return u;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                User u = getObjects();

                bool rs = false;
                rs = manaMem.updateMember(u);
                if (rs)
                {
                    MessageBox.Show("Update successfully");
                    btnSave.Enabled = false;
                    txtEmail.Enabled = false;
                    txtPass.Enabled = false;
                    txtName.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Update failed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                txtEmail.Enabled = true;
                txtPass.Enabled = true;
                txtName.Enabled = true;
                btnSave.Enabled = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnViewCourse_Click(object sender, EventArgs e)
        {
            frmCourse f = new frmCourse()
            {
                user = user,
            };
            f.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void frmMember_Load(object sender, EventArgs e)
        {
            loadMember();
            btnSave.Enabled = false;
        }
    }
}
