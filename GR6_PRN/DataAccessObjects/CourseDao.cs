using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessObjects;
using BusinessObejcts;
namespace DataAccessObjects
{
    public class CourseDao
    {
        private static CourseDao instance = null;
        private static readonly object instanceLock = new object();
        private CourseDao() { }
        public static CourseDao Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CourseDao();
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
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return list;
        }

    }
}
