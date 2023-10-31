using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class TestQuestion
    {
        public int Id { get; set; }
        public int? QuestionId { get; set; }
        public int? TestId { get; set; }

        public virtual Question Question { get; set; }
        public virtual Test Test { get; set; }
    }
}
