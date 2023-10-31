using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessObjects;

namespace Repository
{
    public class UserRepository : IUser
    {
        public User checkLogin(string username, string password) => UserDao.CheckLogin(username, password);
    }
}
