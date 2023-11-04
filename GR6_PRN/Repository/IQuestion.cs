using BusinessObejcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IQuestion
    {
        IEnumerable<Question> GetQuestions();
        void AddQuestion(Question question);
        void RemoveQuestion(int quesId);
        void UpdateQuestion(Question question);
    }
}
