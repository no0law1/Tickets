using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_IckEtS.model
{
    public class Admin
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }

        public Admin(int id, string name, string email)
        {
            this.id = id;
            this.name = name;
            this.email = email;
        }
    }
}
