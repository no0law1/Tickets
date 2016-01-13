using L_IckEtS.data.database.utils;
using L_IckEtS.database;
using L_IckEtS.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;

namespace L_IckEtS.data.entity
{
    class TicketDAO
    {

        private static Ticket createTicket(SqlDataReader data)
        {
            int code = SqlDataReaderUtils.GetValue<int>(data, 0);
            string state = SqlDataReaderUtils.GetValue<string>(data, 1);
            string description = SqlDataReaderUtils.GetValue<string>(data, 2);
            DateTime created_at = SqlDataReaderUtils.GetValue<DateTime>(data, 3);
            DateTime closed_at = SqlDataReaderUtils.GetValue<DateTime>(data, 4);
            string priority = SqlDataReaderUtils.GetValue<string>(data, 5);
            DateTime deleted_at = SqlDataReaderUtils.GetValue<DateTime>(data, 6);
            int admin_id = SqlDataReaderUtils.GetValue<int>(data, 7);
            int client_id = SqlDataReaderUtils.GetValue<int>(data, 8);
            int id_type = SqlDataReaderUtils.GetValue<int>(data, 9);

            return new Ticket(code, state, description, created_at, closed_at, priority, deleted_at, admin_id, client_id, id_type);
        }

        public static IEnumerable<Ticket> getNonClosedTickets(DB connection)
        {
            using (SqlConnection db = connection.getConnection())
            {
                using (SqlCommand command = db.CreateCommand())
                {
                    command.CommandText = String.Format("SELECT * FROM ticket WHERE closed_at is null AND deleted_at is null");
                    db.Open();
                    SqlDataReader data = command.ExecuteReader();
                    LinkedList<Ticket> list = new LinkedList<Ticket>();
                    while (data.Read())
                    {
                        list.AddLast(createTicket(data));
                    }
                    return list;
                }
            }
        }

        public static IEnumerable<Ticket> getAllTickets(DB connection)
        {
            using (SqlConnection db = connection.getConnection())
            {
                using (SqlCommand command = db.CreateCommand())
                {
                    command.CommandText = String.Format("SELECT * FROM ticket WHERE deleted_at is null");
                    db.Open();
                    SqlDataReader data = command.ExecuteReader();
                    LinkedList<Ticket> list = new LinkedList<Ticket>();
                    while (data.Read())
                    {
                        list.AddLast(createTicket(data));
                    }
                    return list;
                }
            }
        }

        public static Ticket getTicketById(DB connection, int code)
        {
            using (SqlConnection db = connection.getConnection())
            {
                using (SqlCommand command = db.CreateCommand())
                {
                    command.CommandText = String.Format("SELECT * FROM ticket WHERE code = {0}", code);
                    db.Open();
                    SqlDataReader data = command.ExecuteReader();
                    if (!data.Read())
                    {
                        return null;
                    }
                    return createTicket(data);
                }
            }
        }

        public static Boolean removeTicket(DB connection, int code)
        {
            using (SqlConnection db = connection.getConnection())
            {
                //TODO: Use stored procedure
                return false;
            }
        }
    }
}
