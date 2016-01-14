using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_IckEtS.model
{
    public class Action
    {
        private string p1;
        private int p2;
        private int admin_id1;
        private int order;
        private int? nullable;

        public DateTime created_at {get; set;}
		public Nullable<DateTime> ended_at {get; set;}

		public string note {get; set;}
		public int ticket_id {get; set;}
		public int admin_id {get; set;}
		public int step_order {get; set;}
        public int id_type { get; set; }

        public Action(DateTime created_at,
            Nullable<DateTime> ended_at,
            string note,
            int ticket_id,
            int admin_id,
            int step_order,
            int id_type)
        {
            this.created_at = created_at;
            this.ended_at = ended_at;
            this.note = note;
            this.ticket_id = ticket_id;
            this.admin_id = admin_id;
            this.step_order = step_order;
            this.id_type = id_type;
        }

        public Action(string note,
            int ticket_id,
            int admin_id,
            int step_order,
            int? id_type)
        {
            this.note = note;
            this.ticket_id = ticket_id;
            this.admin_id = admin_id;
            this.step_order = step_order;
            this.id_type = (int)id_type;
        }
    }
}
