using MySql.Data.MySqlClient;
using Utils;

namespace KitchenStockManager.Models.People.Users
{
    static class UserManager
    {

        // connect to db separately, rather than passing it down
        public static async Task<User?> LogIn(string email, string pass)
        {
            using (var connection = await DBHelper.GetConnection())
            {
                string logInQuery = "SELECT * FROM users WHERE email = @email AND password = @password;";

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

        public static async Task<User?> RegisterUser(string email, string pass, string fname, string lname)
        {
            using (var connection = await DBHelper.GetConnection())
            {
                string emailQuery = "SELECT email FROM users WHERE email = @email;";
                string insertionStatement = "INSERT INTO users (email, password, firstName, lastName) " +
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
