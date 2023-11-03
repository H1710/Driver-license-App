using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObejcts
{
    public partial class MentorRating
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? MentorId { get; set; }
        public int? Rating { get; set; }
        public string Feedback { get; set; }

        public virtual Mentor Mentor { get; set; }
        public virtual User User { get; set; }
    }
}
