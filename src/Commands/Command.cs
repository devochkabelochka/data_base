public class Command
{
    public string name { get; private set; }
    public CommandAction action { get; private set; }

    public Command(string name, CommandAction action)
    {
        this.name = name;
        this.action = action;
    }

    public void Invoke(string[] args)
    {
        action.Invoke(args);
    }
}
