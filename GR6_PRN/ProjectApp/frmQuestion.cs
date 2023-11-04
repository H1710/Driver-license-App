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
    public partial class frmQuestion : Form
    {
        IQuestion questionRepo = new QuestionRepository();
        BindingSource source = new BindingSource();
        public frmQuestion()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void Textbox(bool state)
        {
            txtID.Enabled = false;
            txtTitle.Enabled = state;
            txtA.Enabled = state;
            txtB.Enabled = state;
            txtC.Enabled = state;
            txtD.Enabled = state;
            txtAnswer.Enabled = state;
        }

        private Question GetQuestion()
        {
            Question question = null;
            try
            {
                question = new Question()
                {
                    Id = int.Parse(txtID.Text),
                    Title = txtTitle.Text,
                    OptA = txtA.Text,
                    OptB = txtB.Text,
                    OptC = txtC.Text,
                    OptD = txtD.Text,
                    Answer = txtAnswer.Text
                };
            }catch (Exception ex) {
                MessageBox.Show(ex.Message, "Get Question");
            }
            return question;

        }
        private void LoadQuestionList()
        {
            try
            {
                var quesList = questionRepo.GetQuestions();
                source.DataSource = quesList;
                txtID.DataBindings.Clear();
                txtTitle.DataBindings.Clear();
                txtA.DataBindings.Clear();
                txtB.DataBindings.Clear();  
                txtC.DataBindings.Clear();
                txtD.DataBindings.Clear();
                txtAnswer.DataBindings.Clear();

                txtID.DataBindings.Add("Text", source, "Id");
                txtTitle.DataBindings.Add("Text", source, "Title");
                txtA.DataBindings.Add("Text", source, "OptA");
                txtB.DataBindings.Add("Text", source, "OptB");
                txtC.DataBindings.Add("Text", source, "OptC");
                txtD.DataBindings.Add("Text", source, "OptD");
                txtAnswer.DataBindings.Add("Text", source, "Answer");

                dgvQuestion.DataSource = null;
                dgvQuestion.DataSource = quesList;

            }catch (Exception ex) { MessageBox.Show(ex.Message, "Load Question List"); }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            frmStaff frmStaff = new frmStaff();
            frmStaff.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var ques = new Question()
            {
                Id = int.Parse(txtID.Text),

            };
             questionRepo.RemoveQuestion(ques.Id);
            LoadQuestionList();

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Textbox(true);
            try
            {
                frmQuestionDetail frmQuestion = new frmQuestionDetail
                {
                    InsertOrUpdate = false,
                    QuesRepo = questionRepo,

                };
                if(frmQuestion.ShowDialog() == DialogResult.OK)
                {
                    LoadQuestionList();
                    source.Position = source.Count - 1;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in adding question");
            }
        }

        private void frmQuestion_Load(object sender, EventArgs e)
        {
            Textbox(false);
            LoadQuestionList();
            dgvQuestion.CellContentDoubleClick += dgvQuestion_CellDoubleClick;
        }

        private void dgvQuestion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmQuestionDetail frmQuestion = new frmQuestionDetail()
            {
                InsertOrUpdate = true,
                QuesRepo = questionRepo,
                question = GetQuestion(),
            };
            if (frmQuestion.ShowDialog(this) == DialogResult.OK)
            {
                LoadQuestionList();
                source.Position = source.Count - 1;
            }
        }
    }
}
