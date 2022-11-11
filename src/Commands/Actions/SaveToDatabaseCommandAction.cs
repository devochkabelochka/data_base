public class SaveToDatabaseCommandAction : CommandAction
{
    private readonly DatabaseLoader _loader = new DatabaseLoader();

    public override void Invoke(string[] args)
    {
        var name = args[0];
        var database = _loader.Load();
        database.items.Add(new Item(name));
        _loader.Save(database);
    }
}
