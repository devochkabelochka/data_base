using System.Linq;

public class RemoveFromDatabaseCommandAction : CommandAction
{
    private readonly DatabaseLoader _loader = new DatabaseLoader();

    public override void Invoke(string[] args)
    {
        var name = args[0];
        var database = _loader.Load();
        var itemToRemove = database.items.FirstOrDefault(x => x.name == name);
        if (itemToRemove != null) database.items.Remove(itemToRemove);
        _loader.Save(database);
    }
}