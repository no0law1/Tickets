using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_IckEtS.model
{
    class Ticket
    {

        public Ticket(int code,
            string state,
            string description,
            DateTime created_at,
            DateTime closed_at,
            string priority,
            int admin_id,
            int client_id,
            int id_type)
        {
            this.code = code;
            this.STATE = state;
            this.description = description;
            this.created_at = created_at;
            this.closed_at = closed_at;
            this.priority = priority;
            this.deleted_at = deleted_at;
            this.admin_id = admin_id;
            this.client_id = client_id;
            this.id_type = id_type;
        }

        public int code { get; set; }
        public string STATE { get; set; }
        public string description { get; set; }
        public System.DateTime created_at { get; set; }
        public Nullable<System.DateTime> closed_at { get; set; }
        public string priority { get; set; }
        public Nullable<System.DateTime> deleted_at { get; set; }
        public int admin_id { get; set; }
        public int client_id { get; set; }
        public Nullable<int> id_type { get; set; }
    }
}
