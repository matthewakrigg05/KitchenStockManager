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

        public void RegisterUser(string email, string pass, string fname, string lname, MySqlConnection connection)
        {
            using (connection)
            {
                string emailQuery = "SELECT * FROM Users (email) WHERE email = @email;";
                string insertionStatement = "INSERT INTO Users (email, password, firstName, lastName) " +
                    "VALUES (@email, @password, @firstName, @lastName)";

                using (MySqlCommand emailCmd = new MySqlCommand(emailQuery, connection))
                {
                    emailCmd.Parameters.AddWithValue("@email", email);
                    emailCmd.Prepare();

                    MySqlDataReader result = emailCmd.ExecuteReader();


                    if (result.HasRows)
                    {
                        Console.WriteLine("Registration has failed - email already taken!");
                        result.Close();
                        return;
                    }
                    else
                    {
                        emailAddress = email;
                        password = pass;
                        firstName = fname;
                        lastName = lname;
                    }
                }

                using (MySqlCommand insertCmd = new MySqlCommand(insertionStatement, connection))
                {
                    insertCmd.Parameters.AddWithValue("@email", email);
                    insertCmd.Parameters.AddWithValue("@password", pass);
                    insertCmd.Parameters.AddWithValue("@firstName", fname);
                    insertCmd.Parameters.AddWithValue("@lastName", lname);
                    insertCmd.Prepare();

                    int rows = insertCmd.ExecuteNonQuery();

                    if (rows == 1)
                    {
                        Console.WriteLine("Successfully registered a new user!");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Unsuccessful registration.");
                        return;
                    }
                }

            }
        }
    }
}
