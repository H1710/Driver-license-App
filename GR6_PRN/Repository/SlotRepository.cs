using BusinessObejcts;
using DataAccessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class SlotRepository : ISlot
    {
        public List<Slot> GetSlots(int id) => SlotDao.getListSlot(id);

        public bool regisUserSlot(UserSlot slot) => SlotDao.regisUserSlot(slot);
    }
}
