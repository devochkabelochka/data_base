using System;
using System.Collections.Generic;

[Serializable]
public class Database
{
    public List<Item> items { get; set; } = new List<Item>();

    public Database() { }
}
