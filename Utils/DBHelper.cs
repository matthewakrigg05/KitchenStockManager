using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;

namespace Utils
{
    public static class DBHelper
    {
        public static async Task<MySqlConnection> GetConnection()
        {
            string dbPass = Environment.GetEnvironmentVariable("dbPass") ?? throw new InvalidOperationException("Database password environment variable is not set.");
            string connstring = string.Format($"Server=127.0.0.1; database=ksm; UID=root; password={dbPass}");
            var connection = new MySqlConnection(connstring);
            await connection.OpenAsync();

            return connection;
        }

        public static string Encrypt(string password)
        {
            return password;
        }
    }
}