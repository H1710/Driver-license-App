﻿using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObejcts
{
    public partial class UserTest
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? TestId { get; set; }
        public int? Score { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }

        public virtual Test Test { get; set; }
        public virtual User User { get; set; }
    }
}
