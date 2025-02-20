namespace AdventureS25;

public static class CommandProcessor
{
    public static void Process()
    {
        // get input
        string rawInput = GetInput();
        
        // make sure two words
        Command command = Parse(rawInput);

        Console.WriteLine("Verb: [" + command.Verb + "]");
        Console.WriteLine("Noun: [" + command.Noun + "]");
        
        // make sure we have the words in our vocabulary

        // do stuff with the command

    }
    
    public static string GetInput()
    {
        Console.Write("> ");
        string input = Console.ReadLine();
        return input;
    }

    public static Command Parse(string input)
    {
        input = RemoveExtraSpaces(input);
        input = input.ToLower();
        
        // breaK the input into individual words
        List<string> words = input.Split(' ').ToList();
        
        Command command = new Command();
        
        if (words.Count == 2)
        {
            command.Verb = words[0];
            command.Noun = words[1];
        }
        else if (words.Count == 1)
        {
            command.Verb = words[0];
        }
        else
        {
            Console.WriteLine("I don't understand that.");
        }
        
        return command;
    }

    private static string RemoveExtraSpaces(string input)
    {
        input = input.Trim();

        while (input.Contains("  "))
        {
            input = input.Replace("  ", " ");
        }
        
        return input;
    }
}