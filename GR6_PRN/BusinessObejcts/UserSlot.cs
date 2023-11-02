using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObejcts
{
    public partial class UserSlot
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? SlotId { get; set; }

        public virtual Slot Slot { get; set; }
        public virtual User User { get; set; }
    }
}
