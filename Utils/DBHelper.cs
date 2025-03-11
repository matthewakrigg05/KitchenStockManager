using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Text;

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

        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                string saltString = Environment.GetEnvironmentVariable("salt") ?? throw new InvalidOperationException("Salt environment variable is not set.");
                byte[] salt = Encoding.ASCII.GetBytes(saltString);

                byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
                byte[] saltedPassword = new byte[passwordBytes.Length + salt.Length];

                // Concatenate password and salt
                Buffer.BlockCopy(passwordBytes, 0, saltedPassword, 0, passwordBytes.Length);
                Buffer.BlockCopy(salt, 0, saltedPassword, passwordBytes.Length, salt.Length);

                // Hash the concatenated password and salt
                byte[] hashedBytes = sha256.ComputeHash(saltedPassword);

                // Concatenate the salt and hashed password for storage
                byte[] hashedPasswordWithSalt = new byte[hashedBytes.Length + salt.Length];
                Buffer.BlockCopy(salt, 0, hashedPasswordWithSalt, 0, salt.Length);
                Buffer.BlockCopy(hashedBytes, 0, hashedPasswordWithSalt, salt.Length, hashedBytes.Length);

                return Convert.ToBase64String(hashedPasswordWithSalt);
            }
        }
    }
}