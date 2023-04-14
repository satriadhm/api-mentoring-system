using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mentoring_system.model
{
   public enum subjekMentoring
    {
        INTERACTION_DESIGN,
        ALGORITHM_PROGRAMMING,
        DATA_STRUCTURE

    }
    public class mentor : User
    {
        public mentor(string namaLengkap, string username, string password, string umur) : base(namaLengkap, username, password, umur)
        {
        
            this.role = (Role)1;
        }
    }
}
