using Microsoft.Data.Sqlite;
using Utils;

public class DatabaseInitialiser
{
    private readonly string _tableScriptPath;
    public List<string> TableCreationStatements { get; private set; } = new List<string>();

    public DatabaseInitialiser(string tableScriptPath)
    {
        _tableScriptPath = tableScriptPath;
    }

    public void ExtractSqlTableStatements()
    {
        string sqlFile = File.ReadAllText(_tableScriptPath);
        string[] sqlStatements = sqlFile.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string statement in sqlStatements)
        {
            string trimmed = statement.Trim();

            if (!string.IsNullOrWhiteSpace(trimmed))
            {
                TableCreationStatements.Add(trimmed);
            }
        }
    }

    public void CreateSqlTables()
    {
        using (var conn = DBHelper.GetConnection())
        {
            foreach (string statement in TableCreationStatements)
            {
                using (var cmd = new SqliteCommand(statement, conn))
                    cmd.ExecuteNonQuery();
            }

            Console.WriteLine("SQL tables have been successfully created!");
        }
    }

    // As part of the db initialiser, it has to check if the db exists first, if so, skip initialisation to avoid sql errors for tables
    // that already exists
    public bool DatabaseExists(string dbPath="KSM.db")
    {
        return File.Exists(dbPath);
    }
}