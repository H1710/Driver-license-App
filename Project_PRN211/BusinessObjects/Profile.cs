using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Profile
    {
        public int UserId { get; set; }
        public DateTime? RegDate { get; set; }

        public virtual User User { get; set; }
    }
}
