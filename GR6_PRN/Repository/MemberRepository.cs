using BusinessObejcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessObjects;
namespace Repository
{
    public class MemberRepository : IMember
    {
        public User checkLogin(string email, string password) => MemberDao.checkLogin(email, password);
    }
}
