using Utils;
using Xunit;

namespace KitchenStockManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Kitchen Stock Manager!");
            if (Program.Quick_Test().Result) {
                Console.WriteLine("Database connection is successful.");
            } else {
                Console.WriteLine("Database connection failed.");
            }

        }

        public static async Task<bool> Quick_Test()
        {
                        // Act
            var dbConnection = await DBHelper.GetConnection();

            // Assert
            return dbConnection.State == System.Data.ConnectionState.Open;
        }

    }
}
