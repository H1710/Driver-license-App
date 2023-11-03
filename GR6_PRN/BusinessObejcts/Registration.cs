using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObejcts
{
    public partial class Registration
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? IdCms { get; set; }

        public virtual CourseMentorSlot IdCmsNavigation { get; set; }
        public virtual User User { get; set; }
    }
}
