namespace AdventureS25;

public static class CommandProcessor
{
    public static void Process()
    {
        // get input
        string rawInput = GetInput();
        Console.WriteLine(rawInput);
        
        // make sure two words

        // make sure we have the words in our vocabulary

        // do stuff with the command

    }
    
    public static string GetInput()
    {
        Console.Write("> ");
        string input = Console.ReadLine();
        return input;
    }
}