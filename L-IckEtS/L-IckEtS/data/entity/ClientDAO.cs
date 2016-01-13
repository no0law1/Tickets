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
    class ClientDAO
    {
        private static Client createClient(SqlDataReader data)
        {
            int id = SqlDataReaderUtils.GetValue<int>(data, 0);
            string name = SqlDataReaderUtils.GetValue<string>(data, 1);
            string email = SqlDataReaderUtils.GetValue<string>(data, 2);

            return new Client(id, name, email);
        }

        internal static Client getClient(DB connection, int id)
        {
            using (SqlConnection db = connection.getConnection())
            {
                using (SqlCommand command = db.CreateCommand())
                {
                    command.CommandText = String.Format("SELECT * FROM client WHERE id = {0}", id);
                    db.Open();
                    SqlDataReader data = command.ExecuteReader();
                    if (!data.Read())
                    {
                        return null;
                    }
                    return createClient(data);
                }
            }
        }
    }
}
