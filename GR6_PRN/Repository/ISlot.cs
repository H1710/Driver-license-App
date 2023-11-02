using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObejcts;
namespace Repository
{
    public interface ISlot
    { 
        public List<Slot> GetSlots(int id);

        public bool regisUserSlot (UserSlot slot);
    }
}
