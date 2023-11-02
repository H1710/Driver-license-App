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

        public int getMaxId() => MemberDao.getMaxId();

        public bool regisCourseMentorSlot(CourseMentorSlot slot) => MemberDao.regisCourseMentorSlot(slot);

        public bool registration(Registration registration) => MemberDao.Registration(registration);

        public bool updateMember(User user) => MemberDao.updateMember(user);
    }
}
