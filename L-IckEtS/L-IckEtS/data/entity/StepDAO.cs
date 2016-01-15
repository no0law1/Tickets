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
    class StepDAO
    {

        private static Step createStep(SqlDataReader data)
        {
            int num_order = SqlDataReaderUtils.GetValue<int>(data, 0);
            string description = SqlDataReaderUtils.GetValue<string>(data, 1);
            int id_type = SqlDataReaderUtils.GetValue<int>(data, 2);

            return new Step(num_order, description, id_type);
        }

        internal static IEnumerable<Step> getStepsOfType(DB connection, int type_id)
        {
            using (SqlConnection db = connection.getConnection())
            {
                using (SqlCommand command = db.CreateCommand())
                {
                    command.CommandText = String.Format("SELECT * FROM step WHERE id_type = {0}", type_id);
                    db.Open();
                    SqlDataReader data = command.ExecuteReader();
                    LinkedList<Step> list = new LinkedList<Step>();
                    while (data.Read())
                    {
                        list.AddLast(createStep(data));
                    }
                    return list;
                }
            }
        }
    }
}
