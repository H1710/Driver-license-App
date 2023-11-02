using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObejcts;
namespace DataAccessObjects
{
    public class MemberDao
    {
        private static MemberDao instance = null;
        private static readonly object instanceLock = new object();
        private MemberDao() { }
        public static MemberDao Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDao();
                    }
                    return instance;
                }
            }
        }


        public static User checkLogin(string email, string password)
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

        public static bool updateMember(User user)
        {
            bool rs = false;
            try
            {
                using var db = new PRN211Context();
                db.Users.Update(user);
                db.SaveChanges();
                rs = true;
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return rs;
        }

        public static bool Registration(Registration registration)
        {
            bool rs = false;
            try
            {
                using var db = new PRN211Context();
                db.Registrations.Add(registration);
                db.SaveChanges();
                rs = true;
                return rs;
            }catch(Exception ex)
            {
                Console.WriteLine (ex.Message);
            }
            return rs;
        }

        public static bool regisCourseMentorSlot(CourseMentorSlot courseMentorSlot)
        {
            bool success = false;
            try
            {
                using (var db = new PRN211Context())
                {
                    db.CourseMentorSlots.Add(courseMentorSlot);
                    int affectedRows = db.SaveChanges();

                    if (affectedRows > 0)
                    {
                        success = true;
                    }
                    else
                    {
                        // The data was not saved. Handle this case accordingly.
                        Console.WriteLine("No rows were affected. Data not saved.");
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the exception and its message for debugging purposes.
                Console.WriteLine("Error in regisCourseMentorSlot: " + ex.Message);
            }
            return success;
        }


        public static int getMaxId()
        {
            int max = 0;
            using var db = new PRN211Context();
            max = db.Registrations.Max(r => r.Id);
            return max;
        }
    }
}
