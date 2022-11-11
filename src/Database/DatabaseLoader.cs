using System;
using System.IO;
using System.Text.Json;

public class DatabaseLoader
{
    private readonly string _savePath = AppDomain.CurrentDomain.BaseDirectory + "database.cabt";

    public void Save(Database database)
    {
        var jsonString = JsonSerializer.Serialize(database);
        File.WriteAllText(_savePath, jsonString);
    }

    public Database Load()
    {
        if (File.Exists(_savePath))
        {
            return LoadDatabaseFromDisc();
        }
        return new Database();

    }

    private Database LoadDatabaseFromDisc()
    {
        var jsonString = File.ReadAllText(_savePath);
        var result = JsonSerializer.Deserialize<Database>(jsonString);
        return result;
    }
}
