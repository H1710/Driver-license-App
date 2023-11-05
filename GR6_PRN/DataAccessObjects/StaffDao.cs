using BusinessObejcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class StaffDao
    {
        private static StaffDao instance = null;
        private static readonly object instanceLock = new object();
        public StaffDao() { }
        public static StaffDao Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new StaffDao();
                    }
                    return instance;
                }
            }
        }

        public static List<Course> getListCourse()
        {
            List<Course> list = null;
            try
            {
                using var db = new PRN211Context();
                list = db.Courses.ToList();
                return list;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return list;
        }
    }
}
