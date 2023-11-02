using BusinessObejcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class MentorDao
    {
        private static MentorDao instance = null;
        private static readonly object instanceLock = new object();
        private MentorDao() { }
        public static MentorDao Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MentorDao();
                    }
                    return instance;
                }
            }
        }

        public static List<Mentor> GetMentors(int id)
        {
            List<Mentor> listM = null;
            try
            {
                using var db = new PRN211Context();
                listM = db.Mentors.Where(m => m.Id == id).ToList();
                return listM;
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return listM;
        }
    }
}
