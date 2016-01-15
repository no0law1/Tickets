using L_IckEtS.data.database.utils;
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
            DateTime created_at = SqlDataReaderUtils.GetValue<DateTime>(data, 1);
            Nullable<DateTime> ended_at = SqlDataReaderUtils.GetValue<DateTime>(data, 2);
            string note = SqlDataReaderUtils.GetValue<String>(data, 3);
            int ticket_id = SqlDataReaderUtils.GetValue<int>(data, 4);
            int admin_id = SqlDataReaderUtils.GetValue<int>(data, 5);
            int step_order = SqlDataReaderUtils.GetValue<int>(data, 6);
            int id_type = SqlDataReaderUtils.GetValue<int>(data, 7);

            return new model.Action(created_at, ended_at.Equals(default(DateTime))?null:ended_at, note, ticket_id, admin_id, step_order, id_type);
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

        internal static Boolean insertAction(DB connection, L_IckEtS.model.Action action)
        {
            using (SqlConnection db = connection.getConnection())
            {
                using (SqlCommand command = new SqlCommand("CreateAction", db))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.Add("@note", System.Data.SqlDbType.VarChar).Value = action.note;
                    command.Parameters.Add("@ticket_id", System.Data.SqlDbType.Int).Value = action.ticket_id;
                    command.Parameters.Add("@admin_id", System.Data.SqlDbType.Int).Value = action.admin_id;
                    command.Parameters.Add("@step_order", System.Data.SqlDbType.Int).Value = action.step_order;
                    command.Parameters.Add("@id_type", System.Data.SqlDbType.Int).Value = action.id_type;
                    db.Open();

                    return command.ExecuteNonQuery()<1 ? false : true;
                }
            }
        }
    }
}
