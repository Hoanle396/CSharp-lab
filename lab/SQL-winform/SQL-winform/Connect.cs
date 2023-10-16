using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using MySqlConnector;

namespace SQL_winform
{
    static class Connect
    {
        static string url = "Server=localhost;User ID=root;Password='';Database=student";
        private static MySqlConnection? conn;
        public static MySqlConnection Instance {
            get
            {
                if (conn == null)
                {                    
                    conn = new MySqlConnection(url);
                }
                return conn;
            }
        }
    }
}
