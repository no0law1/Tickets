using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_IckEtS_EF.utils
{
    class TicketSystemDBQueryable
    {

        internal IEnumerable<ticket> getAllTicketsTable(ticket_systemEntities db)
        {
            return db.GetTicketsView.SqlQuery("SELECT * FROM ticket WHERE ticket.deleted_at is null").AsEnumerable();
            //return (from t in db.ticket where t.deleted_at == null select t).AsEnumerable();
        }

        internal IEnumerable<ticket> getNonClosedTicketsTable(ticket_systemEntities db)
        {
            return db.GetTicketsView.SqlQuery("SELECT * FROM ticket WHERE ticket.closed_at is null AND ticket.deleted_at is null").AsEnumerable();
            //return (from t in db.ticket where t.closed_at == null && t.deleted_at == null select t).AsEnumerable();
        }

        internal ticket getTicketById(ticket_systemEntities db, int code)
        {
            return db.GetTicketsView.SqlQuery("SELECT * FROM ticket WHERE ticket.code = @code", new SqlParameter("@code", code)).First();
            //return (from t in db.ticket where t.code == code select t).First();
        }

        internal client getClientById(ticket_systemEntities db, int id)
        {
            return db.client.SqlQuery("select * from client where id = @id", new SqlParameter("@id", id)).First();
        }
        
        internal administrator getAdminById(ticket_systemEntities db, int id)
        {
            return db.administrator.SqlQuery("select * from administrator where id = @id", new SqlParameter("@id", id)).First();
        }

        internal type getTypeById(ticket_systemEntities db, int? id)
        {
            return db.type.SqlQuery("select * from type where id = @id", new SqlParameter("@id", id)).First();
        }

        internal IEnumerable<action> getActionsByTicketId(ticket_systemEntities db, int id)
        {
            return db.action.SqlQuery("select * from action where ticket_id = @id", new SqlParameter("@id", id)).AsEnumerable();
        }

        internal IEnumerable<request> getTicketRequests(ticket_systemEntities db, int code)
        {
            return (from r in db.request where r.ticket_id == code select r).AsEnumerable();
        }
    }
}
