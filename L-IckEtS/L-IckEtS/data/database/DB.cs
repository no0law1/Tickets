using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L_IckEtS.database
{
    class DB
    {
        private System.Data.SqlClient.SqlConnectionStringBuilder builder;

        private SqlConnection connection;

        public DB(string data_source, string initial_catalog, Boolean integrated_security)
        {
            builder = new System.Data.SqlClient.SqlConnectionStringBuilder();
            builder["Data Source"] = data_source;
            builder["Initial Catalog"] = initial_catalog;
            builder["integrated Security"] = integrated_security.ToString();
        }

        public SqlConnection getConnection(){
            SqlConnection con = new SqlConnection();
            con.ConnectionString = builder.ConnectionString;
            Console.Write(con.ConnectionString);
            return con;
        }

        public void closeConnection()
        {
            connection.Close();
            connection = null;
        }
    }
}
