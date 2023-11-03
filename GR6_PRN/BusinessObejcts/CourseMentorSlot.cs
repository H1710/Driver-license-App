using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObejcts
{
    public partial class CourseMentorSlot
    {
        public CourseMentorSlot()
        {
            Registrations = new HashSet<Registration>();
        }

        public int Id { get; set; }
        public int? CourseId { get; set; }
        public int? MentorId { get; set; }
        public int? SlotId { get; set; }

        public virtual Course Course { get; set; }
        public virtual Mentor Mentor { get; set; }
        public virtual Slot Slot { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
