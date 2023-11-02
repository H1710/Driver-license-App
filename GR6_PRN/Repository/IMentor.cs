using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObejcts;
using DataAccessObjects;
namespace Repository
{
    public interface IMentor
    {
        public List<Mentor> getMentors(int id);
    }
}
