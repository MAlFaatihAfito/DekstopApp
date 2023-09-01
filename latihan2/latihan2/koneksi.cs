using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihan2
{
    internal class koneksi
    {
        static string conn;

        public static SqlConnection Conn
        {
            get
            {
                return new SqlConnection(conn);
            }
        }

        static koneksi()
        {
            string connStr = "server=localhost;" +
                "database=latihan1;" +
                "Integrated Security=True";
            conn = connStr;
        }
    }
}
