using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_IckEtS.model
{
    public class Request
    {
        public Request(int id, DateTime created_at, DateTime response_date, string response, int ticket_id, int client_id, int admin_id)
        {
            this.id = id;
            this.created_at = created_at;
            this.response_date = response_date;
            this.response = response;
            this.ticket_id = ticket_id;
            this.client_id = client_id;
            this.admin_id = admin_id;
        }

        public int id { get; set; }
        public System.DateTime created_at { get; set; }
        public Nullable<System.DateTime> response_date { get; set; }
        public string response { get; set; }
        public int ticket_id { get; set; }
        public int client_id { get; set; }
        public Nullable<int> admin_id { get; set; }
    }
}
