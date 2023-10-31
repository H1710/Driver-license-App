using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class Test
    {
        public Test()
        {
            TestQuestions = new HashSet<TestQuestion>();
            UserTests = new HashSet<UserTest>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<TestQuestion> TestQuestions { get; set; }
        public virtual ICollection<UserTest> UserTests { get; set; }
    }
}
