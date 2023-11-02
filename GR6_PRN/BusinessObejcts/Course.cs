using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObejcts
{
    public partial class Course
    {
        public Course()
        {
            CourseMentorSlots = new HashSet<CourseMentorSlot>();
            UserCourses = new HashSet<UserCourse>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public virtual ICollection<CourseMentorSlot> CourseMentorSlots { get; set; }
        public virtual ICollection<UserCourse> UserCourses { get; set; }
    }
}
