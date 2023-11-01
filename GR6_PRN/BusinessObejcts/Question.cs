using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObejcts
{
    public partial class Question
    {
        public Question()
        {
            TestQuestions = new HashSet<TestQuestion>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string OptA { get; set; }
        public string OptB { get; set; }
        public string OptC { get; set; }
        public string OptD { get; set; }
        public string Answer { get; set; }

        public virtual ICollection<TestQuestion> TestQuestions { get; set; }
    }
}
