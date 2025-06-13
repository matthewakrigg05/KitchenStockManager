using Microsoft.Data.Sqlite;
using Utils;

public class DatabaseInitialiser
{
    public SqliteConnection DatabaseConnection;
    public string[] TableCreationStatements;

    public DatabaseInitialiser()
    {}

    public void sqlTableCreation(string filePath)
    {
        string sqlFile = File.ReadAllText(filePath);
        string[] sqlStatements = sqlFile.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

        using (var conn = DBHelper.GetConnection())
        {
            foreach (string statement in sqlStatements)
            {
                string trimmedStatement = statement.Trim();
                if (!string.IsNullOrWhiteSpace(trimmedStatement))
                {
                    using (var cmd = new SqliteCommand(trimmedStatement, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            Console.WriteLine("SQL tables have been successfully created!");
        }
    
    }
}