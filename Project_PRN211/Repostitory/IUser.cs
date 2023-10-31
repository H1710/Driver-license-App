using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace Repository
{
    public interface IUser
    {
        public User checkLogin(string username, string password);
    }
}
