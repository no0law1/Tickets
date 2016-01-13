using L_IckEtS.database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace L_IckEtS.data.entity
{
    class ActionDAO
    {
        private static model.Action createAction(SqlDataReader data)
        {
            //TODO: createAction
            return new model.Action();
        }

        public static IEnumerable<model.Action> getTicketActions(DB connection, int ticketID)
        {
            using (SqlConnection db = connection.getConnection())
            {
                using (SqlCommand command = db.CreateCommand())
                {
                    command.CommandText = String.Format("SELECT * FROM action WHERE ticket_id = {0}", ticketID);
                    db.Open();
                    SqlDataReader data = command.ExecuteReader();
                    LinkedList<model.Action> list = new LinkedList<model.Action>();
                    while (data.Read())
                    {
                        list.AddLast(createAction(data));
                    }
                    return list;
                }
            }
        }
    }
}
