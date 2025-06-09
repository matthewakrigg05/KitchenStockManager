using Utils;
using Xunit;

namespace KitchenStockManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Kitchen Stock Manager!");
            if (Program.Quick_Test()) {
                Console.WriteLine("Database connection is successful.");
            } else {
                Console.WriteLine("Database connection failed.");
            }

        }

        public static bool Quick_Test()
        {
            // Act
            using var dbConnection = DBHelper.GetConnection();
            
            // Assert
            return dbConnection.State == System.Data.ConnectionState.Closed;
        }

    }
}
