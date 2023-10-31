﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class UserSlot
    {
        public int UserId { get; set; }
        public int SlotId { get; set; }

        public virtual Slot Slot { get; set; }
        public virtual User User { get; set; }
    }
}