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
    public partial class frmQuestionDetail : Form
    {
        public IQuestion QuesRepo { get; set; }
        public Boolean InsertOrUpdate {  get; set; }
        public Question question { get; set; }
        public frmQuestionDetail()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            try
            {
                var ques = new Question {
                
                Title=txtTiltle.Text,
                OptA=txtA.Text,
                OptB=txtB.Text,
                OptC=txtC.Text,
                OptD=txtD.Text,
                Answer=txtAnswer.Text,
                };
                if(InsertOrUpdate == true)
                {
                    QuesRepo.UpdateQuestion(ques);
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    QuesRepo.AddQuestion(ques);
                    DialogResult = DialogResult.OK;
                }


            } catch (Exception ex)
            {

                MessageBox.Show(ex.Message, InsertOrUpdate == true ? "Update successfully" : "Add a new Question");
            }
        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQuestionDetail_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            if(InsertOrUpdate == true)
            {
                txtID.Text=question.Id.ToString();
                txtTiltle.Text=question.Title.ToString();
                txtA.Text=question.OptA.ToString();
                txtB.Text=question.OptB.ToString();
                txtC.Text = question.OptC.ToString();
                txtD.Text = question.OptD.ToString();
                txtAnswer.Text = question.Answer.ToString();
                txtID.Enabled = !InsertOrUpdate;

            }
        }
    }
}
