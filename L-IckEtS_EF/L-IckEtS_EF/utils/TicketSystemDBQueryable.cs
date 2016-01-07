using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_IckEtS_EF.utils
{
    class TicketSystemDBQueryable
    {

        public IQueryable<ticket> getAllTicketsTable(ticket_systemEntities db)
        {
            return (from t in db.ticket where t.deleted_at == null select t);
        }

        public IQueryable<ticket> getNonClosedTicketsTable(ticket_systemEntities db)
        {
            return (from t in db.ticket where t.closed_at == null && t.deleted_at == null select t);
        }

        public ticket getTicketById(ticket_systemEntities db, int code)
        {
            IQueryable<ticket> table = (from t in db.ticket where t.code == code select t);
            return table.First();
        }

        internal IQueryable<request> getTicketRequests(ticket_systemEntities db, int code)
        {
            return (from r in db.request where r.ticket_id == code select r);
        }
    }
}
