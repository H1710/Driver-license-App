using System;
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

        public bool updateMember(User user, int roleId);

        public bool registration(Registration registration);

        public int getMaxId();

        public bool regisCourseMentorSlot(CourseMentorSlot slot);

        public List<User> getAllStaff();

        public void AddUser(User newUser, int roleId);
        public void DeleteUser(int userId);
    }
}
