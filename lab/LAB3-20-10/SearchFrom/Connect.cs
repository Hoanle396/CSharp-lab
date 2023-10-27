using MySql.Data.MySqlClient;

namespace SearchFrom {
    static class Connect {
        static string url = "Server=localhost;User ID=root;Password='';Database=student";
        public static MySqlDataAdapter Adapter(string query) => new(query, url);
    }

}
