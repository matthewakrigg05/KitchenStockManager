using Microsoft.Data.Sqlite;
using System.Security.Cryptography;
using System.Text;

namespace Utils
{
    public static class DBHelper
    {
        public static SqliteConnection GetConnection()
        {
            var connection = new SqliteConnection("Data Source = KSM.db");
            connection.Open();

            return connection;
        }
    }
}