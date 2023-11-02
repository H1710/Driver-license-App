using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObejcts
{
    public partial class Slot
    {
        public Slot()
        {
            CourseMentorSlots = new HashSet<CourseMentorSlot>();
            Registrations = new HashSet<Registration>();
            UserSlots = new HashSet<UserSlot>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan? StartTime { get; set; }
        public TimeSpan? EndTime { get; set; }

        public virtual ICollection<CourseMentorSlot> CourseMentorSlots { get; set; }
        public virtual ICollection<Registration> Registrations { get; set; }
        public virtual ICollection<UserSlot> UserSlots { get; set; }
    }
}
