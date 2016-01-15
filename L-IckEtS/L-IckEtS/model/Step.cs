using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_IckEtS.model
{
    public class Step
    {
        public int num_order { get; set; }
        public string description { get; set; }
        public int id_type { get; set; }

        public Step(int num_order, string description, int id_type)
        {
            this.num_order = num_order;
            this.description = description;
            this.id_type = id_type;
        }
    }
}
