using BusinessObejcts;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class QuestionRepository : IQuestion
    {
        public void AddQuestion(Question question) => QuestionDAO.Instance.AddQuestion(question);


        public IEnumerable<Question> GetQuestions() => QuestionDAO.Instance.GetAllQuestion();
        
        public void RemoveQuestion(int quesId) =>QuestionDAO.Instance.RemoveQuestion(quesId);
       

        public void UpdateQuestion(Question question) => QuestionDAO.Instance.UpdateQuestion(question);
        
    }
}
