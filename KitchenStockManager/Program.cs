namespace KitchenStockManager
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseInitialiser dbInit = new DatabaseInitialiser("SQLscripts/TablesScript.sql");
            if (!dbInit.DatabaseExists())
            {
                dbInit.ExtractSqlTableStatements();
                dbInit.CreateSqlTables();
            }
            else
            {
                Console.WriteLine("Database already exists. Skipping initialization.");
            }
        }
    }
}
