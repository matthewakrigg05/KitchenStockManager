using Utils;
using Xunit;

namespace KitchenStockManager
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseInitialiser dbInit = new DatabaseInitialiser();

            dbInit.sqlTableCreation("SQLscripts/FullTablesScript.sql");
        }
    }
}
