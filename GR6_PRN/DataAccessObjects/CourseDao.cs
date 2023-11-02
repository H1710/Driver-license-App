using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessObjects;
using BusinessObejcts;
using System.Net;

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

        public static CourseMentorSlot GetCourse(int id)
        {
            CourseMentorSlot course = null;
            try
            {
                using var db = new PRN211Context(); 
                course = db.CourseMentorSlots.FirstOrDefault(c => c.CourseId == id);
                return course;
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return course;
        }


        public static bool regisUserCourse(UserCourse course)
        {
            bool rs = false;
            try
            {
                using var db = new PRN211Context();
                db.UserCourses.Add(course);
                db.SaveChanges();
                rs = true;
                return rs;
            }catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
            return rs;
        }

    }
}
