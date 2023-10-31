using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Mentor
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? AvailableSlots { get; set; }
        public string Specialty { get; set; }

        public virtual User User { get; set; }
    }
}
