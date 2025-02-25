namespace AdventureS25;

public static class CommandProcessor
{
    public static List<string> Verbs = new List<string>
        {"go", "eat"};
    
    public static List<string> StandaloneVerbs = new List<string>
        {"exit", "inventory", "look"};
    
    public static List<string> Nouns = new List<string>
        {"bagel", "apple", "beer"};
    
    public static void Process()
    {
        // get input
        string rawInput = GetInput();
        
        // make sure two words
        Command command = Parse(rawInput);

        Console.WriteLine("Verb: [" + command.Verb + "]");
        Console.WriteLine("Noun: [" + command.Noun + "]");
        
        // make sure we have the words in our vocabulary
        bool isValid = IsValid(command);

        // do stuff with the command
        Console.WriteLine("isValid = " + isValid);
    }

    private static bool IsValid(Command command)
    {
        bool isValid = false;
        
        if (IsVerb(command.Verb) || IsStandaloneVerb(command.Verb))
        {
            if (IsStandaloneVerb(command.Verb))
            {
                isValid = true;
            }
            else if (IsNoun(command.Noun))
            {
                isValid = true;
            }
        }
            
        return isValid;
    }
    
    private static bool IsNoun(string commandNoun)
    {
        if (Nouns.Contains(commandNoun))
        {
            return true;
        }
        return false;
    }

    private static bool IsStandaloneVerb(string commandVerb)
    {
        if (StandaloneVerbs.Contains(commandVerb))
        {
            return true;
        }
        return false;
    }

    private static bool IsVerb(string commandVerb)
    {
        if (Verbs.Contains(commandVerb))
        {
            return true;
        }
        
        return false;
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

        if (input == "")
        {
            words = new List<string>();
        }
        
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