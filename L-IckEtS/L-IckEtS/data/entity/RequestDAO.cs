using L_IckEtS.data.database.utils;
using L_IckEtS.database;
using L_IckEtS.model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_IckEtS.data.entity
{
    class RequestDAO
    {
        private static Request createRequest(SqlDataReader data)
        {
            int id = SqlDataReaderUtils.GetValue<int>(data, 0);
            DateTime created_at = SqlDataReaderUtils.GetValue<DateTime>(data, 1);
            DateTime? response_date = SqlDataReaderUtils.GetValue<DateTime>(data, 2);
            string response = SqlDataReaderUtils.GetValue<string>(data, 3);
            int ticket_id = SqlDataReaderUtils.GetValue<int>(data, 4);
            int client_id = SqlDataReaderUtils.GetValue<int>(data, 5);
            int? admin_id = SqlDataReaderUtils.GetValue<int>(data, 6);

            return new Request(id, created_at, response_date.Equals(default(DateTime)) ? null : response_date,
                response, ticket_id, client_id, admin_id.Equals(default(int))?null:admin_id);
        }

        public static IEnumerable<Request> getTicketRequests(DB connection, int ticketCode)
        {
            using (SqlConnection db = connection.getConnection())
            {
                using (SqlCommand command = db.CreateCommand())
                {
                    command.CommandText = String.Format("SELECT * FROM request WHERE ticket_id = {0}", ticketCode);
                    db.Open();
                    SqlDataReader data = command.ExecuteReader();
                    LinkedList<Request> list = new LinkedList<Request>();
                    while (data.Read())
                    {
                        list.AddLast(createRequest(data));
                    }
                    return list;
                }
            }
        }
    }
}
