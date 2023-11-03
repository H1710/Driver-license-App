using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObejcts
{
    public partial class Profile
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public DateTime? RegDate { get; set; }

        public virtual User User { get; set; }
    }
}
