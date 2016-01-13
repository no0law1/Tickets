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
    class AdminDAO
    {
        private static Admin createAdmin(SqlDataReader data)
        {
            int id = SqlDataReaderUtils.GetValue<int>(data, 0);
            string name = SqlDataReaderUtils.GetValue<string>(data, 1);
            string email = SqlDataReaderUtils.GetValue<string>(data, 2);
            return new Admin(id, name, email);
        }

        public static Admin getAdminByID(DB connection, int id)
        {
            using (SqlConnection db = connection.getConnection())
            {
                using (SqlCommand command = db.CreateCommand())
                {
                    command.CommandText = String.Format("SELECT * FROM administrator WHERE id={0}", id);
                    db.Open();
                    SqlDataReader data = command.ExecuteReader();
                    if (!data.Read())
                    {
                        return null;
                    }
                    return createAdmin(data);
                }
            }
        }
    }
}
