﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Registration
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? SlotId { get; set; }
        public int? PaymentStatus { get; set; }

        public virtual Slot Slot { get; set; }
        public virtual User User { get; set; }
    }
}
