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
            return db.GetTicketsView.SqlQuery("SELECT * FROM ticket WHERE ticket.deleted_at is null").AsEnumerable().ToList();
            //return (from t in db.ticket where t.deleted_at == null select t).AsEnumerable();
        }

        internal IEnumerable<ticket> getNonClosedTicketsTable(ticket_systemEntities db)
        {
            return db.GetTicketsView.SqlQuery("SELECT * FROM ticket WHERE ticket.closed_at is null AND ticket.deleted_at is null").AsEnumerable().ToList();
            //return (from t in db.ticket where t.closed_at == null && t.deleted_at == null select t).AsEnumerable();
        }

        internal ticket getTicketById(ticket_systemEntities db, int code)
        {
            return db.GetTicketsView.SqlQuery("SELECT * FROM ticket WHERE ticket.code = @code", new SqlParameter("@code", code)).First();
            //return (from t in db.ticket where t.code == code select t).First();
        }

        internal client getClientById(ticket_systemEntities db, int id)
        {
            return (from c in db.client where c.id == id select c).First();
            //return db.client.SqlQuery("select * from client where id = @id", new SqlParameter("@id", id)).First();
        }
        
        internal administrator getAdminById(ticket_systemEntities db, int id)
        {
            return (from admin in db.administrator where admin.id == id select admin).First();
            //return db.administrator.SqlQuery("select * from administrator where id = @id", new SqlParameter("@id", id)).First();
        }

        internal type getTypeById(ticket_systemEntities db, int? id)
        {
            return (from t in db.type where t.id == id select t).First();
            //return db.type.SqlQuery("select * from type where id = @id", new SqlParameter("@id", id)).First();
        }

        internal IEnumerable<request> getTicketRequests(ticket_systemEntities db, int code)
        {
            return (from r in db.request where r.ticket_id == code select r).AsEnumerable().ToList();
        }

        internal IEnumerable<action> getTicketActions(ticket_systemEntities db, int code)
        {
            return (from a in db.action where a.ticket_id == code select a).AsEnumerable().ToList();
            //return db.action.SqlQuery("select * from action where ticket_id=@code", new SqlParameter("@code", code));
        }

        internal IEnumerable<step> getStepsOfType(ticket_systemEntities db, int id)
        {
            return (from s in db.step where s.id_type == id orderby s.num_order select s).AsEnumerable().ToList();
            //return db.step.SqlQuery("SELECT * FROM step where id_type=@id order by num_order", new SqlParameter("@id", id)).AsEnumerable();
        }

        internal Boolean existsActions(ticket_systemEntities db, int id)
        {
            return (from a in db.action where a.ticket_id == id select a).Any();
            //return db.action.SqlQuery("SELECT * FROM action WHERE ticket_id = @id", new SqlParameter("@id", id)).Any();
        }
    }
}
