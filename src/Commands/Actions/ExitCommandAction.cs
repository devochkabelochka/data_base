public class ExitCommandAction : CommandAction
{
    public override void Invoke(string[] args)
    {
        Terminal.shouldExit = true;
    }
}