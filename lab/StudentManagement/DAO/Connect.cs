using MySqlConnector;
using System.Data;

namespace DAO
{
     public class Connect
    {
         string url = "Server=localhost;User ID=root;Password='';Database=student";
        protected  MySqlConnection? conn;
        protected  MySqlConnection Instance
        {
            get
            {
                if (conn == null)
                {
                    conn = new MySqlConnection(url);
                    
                }
                if (conn.State == ConnectionState.Closed) conn.Open();
                return conn;
            }
        }
    }
}
