﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObejcts;
using DataAccessObjects;
namespace Repository
{
    public class MentorRepository : IMentor
    {
        public List<Mentor> getMentors(int id) => MentorDao.GetMentors(id);
    }
}
