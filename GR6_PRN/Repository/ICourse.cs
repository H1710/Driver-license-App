﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObejcts;
namespace Repository
{
    public interface ICourse
    {
        public List<Course> getListCourse();

        public CourseMentorSlot getCourse(int id);

        public bool regisUserCourse(UserCourse userCourse);
    }
}
