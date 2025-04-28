namespace KitchenStockManager.Utils
{
    static class SQLQueries
    {
        // User-Related Queries and Statements
        public static string logInQuery = "SELECT * FROM users WHERE email = @email AND password = @password;";
        public static string emailQuery = "SELECT email FROM users WHERE email = @email;";
        public static string insertionUserStatement = "INSERT INTO users (email, password, firstName, lastName) " +
                    "VALUES (@email, @password, @firstName, @lastName)";
    }
}
