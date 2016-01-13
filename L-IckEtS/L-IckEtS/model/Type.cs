using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_IckEtS.model
{
    public class Type
    {
        public int id { get; set; }

        public string name { get; set; }

        public Type(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
