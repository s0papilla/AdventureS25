namespace AdventureS25;

public static class CommandProcessor
{
    public static Command Process()
    {
        // get input
        string rawInput = GetInput();
        
        // make sure two words
        Command command = Parser.Parse(rawInput);

        Console.WriteLine("Verb: [" + command.Verb + "]");
        Console.WriteLine("Noun: [" + command.Noun + "]");
        
        // make sure we have the words in our vocabulary
        bool isValid = CommandValidator.IsValid(command);

        // do stuff with the command
        Console.WriteLine("isValid = " + isValid);

        return command;
    }
    
    public static string GetInput()
    {
        Console.Write("> ");
        string input = Console.ReadLine();
        return input;
    }
}