﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObejcts;
namespace Repository
{
    public interface IMember
    {
        public User checkLogin(string email, string password);
    }
}