﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObejcts
{
    public partial class Mentor
    {
        public Mentor()
        {
            CourseMentorSlots = new HashSet<CourseMentorSlot>();
            MentorRatings = new HashSet<MentorRating>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? AvailableSlots { get; set; }
        public string Specialty { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<CourseMentorSlot> CourseMentorSlots { get; set; }
        public virtual ICollection<MentorRating> MentorRatings { get; set; }
    }
}
