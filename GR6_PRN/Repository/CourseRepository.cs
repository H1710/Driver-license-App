using BusinessObejcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessObjects;
namespace Repository
{
    public class CourseRepository : ICourse
    {
        public List<Course> getListCourse() => CourseDao.getListCourse();
    }
}
