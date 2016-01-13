using L_IckEtS.data.database.utils;
using L_IckEtS.database;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_IckEtS.data.entity
{
    class TypeDAO
    {

        private static model.Type createType(SqlDataReader data)
        {
            int id = SqlDataReaderUtils.GetValue<int>(data, 0);
            string name = SqlDataReaderUtils.GetValue<string>(data, 1);

            return new model.Type(id, name);
        }

        public static model.Type getType(DB connection, int id)
        {
            using (SqlConnection db = connection.getConnection())
            {
                using (SqlCommand command = db.CreateCommand())
                {
                    command.CommandText = String.Format("SELECT * FROM type WHERE id={0}", id);
                    db.Open();
                    SqlDataReader data = command.ExecuteReader();
                    if (!data.Read())
                    {
                        return null;
                    }
                    return createType(data);
                }
            }
        }
    }
}
