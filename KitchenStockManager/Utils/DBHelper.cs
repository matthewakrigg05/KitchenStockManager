using Microsoft.Data.Sqlite;

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