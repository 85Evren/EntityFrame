using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giris2
{
    public class User
    {

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime CreDate { get; set; }

        public string GenderID { get; set; }

        public Gender Gender { get; set; }

        public List<Adress> Adresses { get; set; }  
    }
}
