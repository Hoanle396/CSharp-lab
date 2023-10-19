using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_sqldata_adapter
{
    static class Connect
    {
        static string url = "Server=localhost;User ID=root;Password='';Database=student";
        public static MySqlDataAdapter Adapter(string query) => new(query, url);
    }
   
}
