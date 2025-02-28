using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;

namespace KitchenStockManager.Models.People
{
    internal class User
    {
        private string emailAddress { get; set; }
        private string password { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string role { get; set; }

        public User() { }

        public User(string email, string pass)
        {
            emailAddress = email;
            password = pass;
        }

        public void LogIn(string email, string pass, MySqlConnection connection)
        {
            using (connection)
            {
                string logInQuery = "SELECT * FROM Users (email, password) WHERE email = @email AND password = @password;";

                using (MySqlCommand cmd = new MySqlCommand(logInQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", pass);
                    cmd.Prepare();

                    MySqlDataReader result = cmd.ExecuteReader();

                    if (!result.HasRows)
                    {
                        Console.WriteLine("Log In has failed");
                        result.Close(); 
                        return;
                    }
                    else
                    {
                        emailAddress = email;
                        password = pass;
                    }

                }
            }
        }
    }
}
