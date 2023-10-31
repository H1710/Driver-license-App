using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class UserDao
    {
        private static UserDao instance = null;
        private static readonly object instanceLock = new object();
        private UserDao() { }
        public static UserDao Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDao();
                    }
                    return instance;
                }
            }
        }

        public static User CheckLogin(string email, string password)
        {
            User user = null;
            try
            {
                using var db = new PRN211Context();
                user = db.Users.SingleOrDefault(u => u.Email == email && u.Password == password);
                return user;
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return user;
        }
    }
}
