using System;

public class PrintCommandAciton : CommandAction
{
    private readonly DatabaseLoader _loader = new DatabaseLoader();

    public override void Invoke(string[] args)
    {
        var database = _loader.Load();
        Console.WriteLine($"Items({database.items.Count}):");
        foreach (var item in database.items)
        {
            Console.WriteLine($"{item.name}");
        }
    }
}
