using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryData
{
    public class DB
    {
        public static string ConnectionString
        {
            get
            {
                string connString = ConfigurationManager.ConnectionStrings["LibraryDBConnection"].ToString();
                var sb = new SqlConnectionStringBuilder(connString);
                return sb.ToString();
            }
        }
        public static SqlConnection GetSqlConnection()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }
    }
}
