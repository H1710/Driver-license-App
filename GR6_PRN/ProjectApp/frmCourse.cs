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
    public partial class frmCourse : Form
    {
        public frmCourse()
        {
            InitializeComponent();
        }

        ICourse manaCourse = new CourseRepository();
        BindingSource source = new BindingSource();

        public void loadListCourse()
        {
            try
            {
                source.DataSource = manaCourse.getListCourse();

                txtId.DataBindings.Clear();
                txtTitle.DataBindings.Clear();
                txtDes.DataBindings.Clear();
                txtStartDate.DataBindings.Clear();
                txtEndDate.DataBindings.Clear();

                txtId.Enabled = false;
                txtTitle.Enabled = false;
                txtDes.Enabled = false;
                txtStartDate.Enabled = false;
                txtEndDate.Enabled = false;

                txtId.DataBindings.Add("Text", source, "Id");
                txtTitle.DataBindings.Add("Text", source, "Title");
                txtDes.DataBindings.Add("Text", source, "Description");
                txtStartDate.DataBindings.Add("Text", source, "StartDate");
                txtEndDate.DataBindings.Add("Text", source, "EndDate");

                dgvCourse.DataSource = null;
                dgvCourse.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load list Course");
            }
        }


        public void loadToCombobox()
        {
            try
            {
                List<Course> listC = manaCourse.getListCourse();
                cboCourse.Items.Clear();

                foreach (Course c in listC)
                {
                    cboCourse.Items.Add("Title: " + c.Title + ", StartDate: " + c.StartDate);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load to combo box");
            }
        }

        private void frmCourse_Load(object sender, EventArgs e)
        {
            loadListCourse();
            loadToCombobox();
        }
    }
}
