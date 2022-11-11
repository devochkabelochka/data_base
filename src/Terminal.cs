using System;
using System.Collections.Generic;
using System.Linq;

public class Terminal
{
    public static bool shouldExit = false;

    private Dictionary<string, Command> _commands = new Dictionary<string, Command>();

    public Terminal()
    {
        RegisterCommand("print", new PrintCommandAciton());
        RegisterCommand("remove", new RemoveFromDatabaseCommandAction());
        RegisterCommand("add", new SaveToDatabaseCommandAction());
        RegisterCommand("exit", new ExitCommandAction());
    }

    public void Start()
    {
        while (!shouldExit)
        {
            Read();
        }
    }

    private void RegisterCommand(string name, CommandAction action)
    {
        var command = new Command(name, action);
        _commands.Add(name, command);
    }

    private void Read()
    {
        var args = Console.ReadLine().Split(' ');
        var name = args.FirstOrDefault();
        var commandArgs = args.Skip(1).ToArray();
        _commands[name].Invoke(commandArgs);
    }
}
