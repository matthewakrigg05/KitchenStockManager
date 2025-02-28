using MySql.Data;
using MySql.Data.MySqlClient;

namespace Utils
{
    public static class DBHelper
    {

        public static async Task<MySqlConnection> GetConnection()
        {
            string connstring = string.Format("Server=127.0.0.1; database=ksm; UID=root; password=pass");
            var connection = new MySqlConnection(connstring);
            connection.Open();

            return connection;
        }
    }
}