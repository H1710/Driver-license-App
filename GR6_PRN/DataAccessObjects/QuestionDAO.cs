using BusinessObejcts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class QuestionDAO
    {
        private static QuestionDAO instance = null;
        private static readonly object Lock = new object();
        private QuestionDAO() { }
        public static QuestionDAO Instance
        {
            get
            {
                lock (Lock)
                {
                    if (instance == null)
                    {
                        instance = new QuestionDAO();
                    }
                    return instance;
                }
            }
        }

       

        public void AddQuestion(Question ques)
        {
            var context = new PRN211Context();
            Question question = context.Questions.Find(ques.Id);
            if (question == null)
            {
                context.Questions.Add(ques);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Question is already exist");
            }
        }

        public void RemoveQuestion(int quesID) {
            var context = new PRN211Context();
            Question ques = context.Questions.Find(quesID);
            if (ques != null)
            {
             bool isExisted = context.TestQuestions.Where(x => x.QuestionId == quesID).Any();
                if (isExisted)
                {
                    throw new Exception("Can not remove this question");
                }
                context.Questions.Remove(ques);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Question does not exist");
                
            }
        }
        public void UpdateQuestion(Question ques)
        {
            var context = new PRN211Context();
            Question question = context.Questions.Find(ques.Id);
            if (question != null)
            {

                context.Questions.Update(ques);
                context.SaveChanges();
            }
            else { throw new Exception("Question does not exist"); }
        }

        public List<Question> GetAllQuestion()
        {
            List<Question> QuestionList = new List<Question>();
            try
            {
                using (var context = new PRN211Context())
                {
                    QuestionList = context.Questions.ToList();
                    return QuestionList;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
