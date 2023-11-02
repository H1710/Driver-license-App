using BusinessObejcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessObjects;
using BusinessObejcts;
namespace Repository
{
    public class CourseRepository : ICourse
    {
        public CourseMentorSlot getCourse(int id) => CourseDao.GetCourse(id);

        public List<Course> getListCourse() => CourseDao.getListCourse();

        public bool regisUserCourse(UserCourse userCourse) => CourseDao.regisUserCourse(userCourse);
    }
}
