using BusinessObejcts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObjects
{
    public class SlotDao
    {
        private static SlotDao instance = null;
        private static readonly object instanceLock = new object();
        private SlotDao() { }
        public static SlotDao Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new SlotDao();
                    }
                    return instance;
                }
            }
        }

        public static List<Slot> getListSlot(int id)
        {
            List<Slot> slots = null;
            try
            {
                using var db = new PRN211Context();
                /*slots = db.Slots.Where(s => s.Id == id).ToList();*/
                slots = db.Slots.ToList();
                return slots;
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);   
            }
            return slots;
        }


        public static bool regisUserSlot(UserSlot slot)
        {
            bool rs = false;
            try
            {
                using var db = new PRN211Context();
                db.UserSlots.Add(slot);
                db.SaveChanges();
                rs = true;
                return rs;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return rs;
        }
    }
}
