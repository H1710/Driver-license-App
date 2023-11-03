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
using Microsoft.VisualBasic.Devices;
using System.Security.Cryptography;

namespace ProjectApp
{
    public partial class frmCourse : Form
    {
        public frmCourse()
        {
            InitializeComponent();
        }

        public User user { get; set; }

        IMember manaMem = new MemberRepository();
        ICourse manaCourse = new CourseRepository();
        IMentor manaMentor = new MentorRepository();
        ISlot manaSlot = new SlotRepository();
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

        private Dictionary<int, string> courseDictionary = new Dictionary<int, string>();
        private Dictionary<int, string> slotDictionary = new Dictionary<int, string>();
        private Dictionary<int, string> mentorDictionary = new Dictionary<int, string>();

        public void loadCourseToCombobox()
        {
            try
            {
                List<Course> listC = manaCourse.getListCourse();
                cboCourse.Items.Clear();

                // Clear the dictionary when loading new data
                courseDictionary.Clear();

                foreach (Course c in listC)
                {
                    string displayString = "Title: " + c.Title + ", StartDate: " + c.StartDate;
                    cboCourse.Items.Add(displayString);

                    // Store the ID along with the display string in the dictionary
                    courseDictionary[c.Id] = displayString;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load to combo box");
            }
        }

        public void loadSlotToCbo(CourseMentorSlot course)
        {
            try
            {
                cboSlot.Items.Clear();
                slotDictionary.Clear();
                string slotId = course.SlotId.ToString();
                List<Slot> slots = manaSlot.GetSlots(int.Parse(slotId));

                foreach (Slot slot in slots)
                {
                    string slotDisplayString = "Slot: " + slot.Id;
                    cboSlot.Items.Add(slotDisplayString);
                    slotDictionary[slot.Id] = slotDisplayString;
                }

                cboMentor.Items.Clear();
                mentorDictionary.Clear();
                string mentorId = course.MentorId.ToString();
                List<Mentor> mentors = manaMentor.getMentors(int.Parse(mentorId));

                foreach (Mentor mentor in mentors)
                {
                    string mentorDisplayString = "Mentor: " + mentor.Id;
                    cboMentor.Items.Add(mentorDisplayString);
                    mentorDictionary[mentor.Id] = mentorDisplayString;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load failed");
            }
        }
        private void frmCourse_Load(object sender, EventArgs e)
        {
            loadListCourse();
            loadCourseToCombobox();
        }


        private void cboCourse_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboCourse.SelectedIndex != -1)
            {
                // Get the selected display string
                string selectedDisplayString = cboCourse.SelectedItem.ToString();

                // Find the associated ID from the dictionary
                int selectedId = courseDictionary.FirstOrDefault(kvp => kvp.Value == selectedDisplayString).Key;
                CourseMentorSlot course = manaCourse.getCourse(selectedId);
                if(course != null)
                {
                    loadSlotToCbo(course);
                }
            }

        }



 /*       private void btnSelect_Click(object sender, EventArgs e)
        {
            // Parse the selectedCourseId from the courseDictionary
            string selectedDisplayString = cboCourse.SelectedItem.ToString();
            string selectedDisplay1String = cboSlot.SelectedItem.ToString();
            string selectedDisplay2String = cboMentor.SelectedItem.ToString();

            int selectedCourseId = courseDictionary.FirstOrDefault(kvp => kvp.Value == selectedDisplayString).Key;
            int selectedSlotId = slotDictionary.FirstOrDefault(s => s.Value == selectedDisplay1String).Key;
            int selectedMentorId = mentorDictionary.FirstOrDefault(m => m.Value == selectedDisplay2String).Key;

            if (selectedCourseId != -1 && selectedSlotId != -1 && selectedMentorId != -1)
            {
                try
                {
                    int id = manaMem.getMaxId() + 1;
                    MessageBox.Show(selectedCourseId + "s" + selectedSlotId + "m" + selectedMentorId);
                    Registration registration = new Registration()
                    {
                        Id = id,
                        UserId = user.Id,
                        SlotId = selectedSlotId,
                        PaymentStatus = 1
                    };
*//*                    bool rs = manaMem.registration(registration);
                    MessageBox.Show(rs.ToString());*//*
                    CourseMentorSlot courseMentorSlot = new CourseMentorSlot()
                    {
                        *//*                        CourseId = selectedCourseId,
                                                MentorId = selectedMentorId,
                                                SlotId = selectedSlotId,*//*
                        CourseId = 1,
                        MentorId = 1,
                        SlotId = 1,
                    };
*//*                    bool rs1 = manaMem.regisCourseMentorSlot(courseMentorSlot);
                    MessageBox.Show(rs1.ToString());*//*
                    UserSlot slotSlot = new UserSlot()
                    {
                        UserId = user.Id,
                        SlotId = selectedSlotId,
                    };
                    bool rs2 = manaSlot.regisUserSlot(slotSlot);
                    MessageBox.Show(rs2.ToString());

                    UserCourse slotCourse = new UserCourse()
                    {
                        UserId = user.Id,
                        CourseId = selectedCourseId,
                    };
*//*                    bool rs3 = manaCourse.regisUserCourse(slotCourse);
                    MessageBox.Show(rs3.ToString());*//*
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                MessageBox.Show("Invalid selection.");
            }
        }*/
    }
}

