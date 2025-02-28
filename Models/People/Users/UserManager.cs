using MySql.Data.MySqlClient;
using System.Net.Mail;
using Utils;

namespace KitchenStockManager.Models.People.Users
{
    class UserManager
    {

        public UserManager() { }

        // connect to db separately, rather than passing it down
        public async Task<User> LogIn(string email, string pass)
        {
            using (var connection = await DBHelper.GetConnection())
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
                        return null;
                    }
                    else
                    {
                        return new User(email, pass);
                    }
                }
            }
        }

        public User RegisterUser(string email, string pass, string fname, string lname, MySqlConnection connection)
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

                    using (MySqlDataReader result = emailCmd.ExecuteReader())
                    {
                        if (result.HasRows)
                        {
                            Console.WriteLine("Registration has failed - email already taken!");
                            return null;
                        }
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
                        return new User(email, pass, fname, lname); ;
                    }
                    else
                    {
                        Console.WriteLine("Unsuccessful registration.");
                        return null;
                    }
                }

            }
        }
    }
}
