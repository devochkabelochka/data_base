using System;

[Serializable]
public class Item
{
    public string name { get; set; }

    public Item() { }

    public Item(string name)
    {
        this.name = name;
    }
}
