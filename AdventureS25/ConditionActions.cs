namespace AdventureS25;

public static class ConditionActions
{
    public static Action WriteOutput(string message)
    {
        return () => { Console.WriteLine(message); };
    }
}