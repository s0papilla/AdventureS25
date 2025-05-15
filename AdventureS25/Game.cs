namespace AdventureS25;

public static class Game
{
    public static void PlayGame()
    {
        Initialize();
        Console.WriteLine("Welcome to Frankenfriend!");
        Console.WriteLine("You’ve spent years as the sole caretaker of Desola Graveyard. The quiet used to be comforting. Now it lingers too long. You’ve walked these paths more times than you can count, but lately… something feels different. A presence in the fog. A whisper in the stillness. You don’t see anything — not really. But sometimes you wake with dirt under your nails. As you begin another long shift, the loneliness gnaws at you. Whatever’s out there… it’s reaching for you. And somehow, you know, you need to find a way to reach back.");
        Console.WriteLine(Player.GetLocationDescription());
        Console.WriteLine("It's a cold and foggy night. You stand at the entrance, ready to begin your shift.");
        Console.WriteLine("You hesitate. Another day another dollar. Type 'enter' to step inside...");

        string input = Console.ReadLine()?.Trim().ToLower();

        while (input != "enter")
        {
            Console.WriteLine("You hesitate. The night is cold. Type 'enter' to step inside.");
            input = Console.ReadLine()?.Trim().ToLower();
        }
        Console.WriteLine("You step through the gates. The fog rolls in behind you.");
        Console.WriteLine("Without your flashlight it might be hard to see through this fog...");
        Console.WriteLine($"{Player.CurrentLocation.Description}\n");
        Console.WriteLine("You should head north to your office and grab your flashlight before making your rounds.");
    
        bool isPlaying = true;
        
        while (isPlaying == true)
        {
            Command command = CommandProcessor.Process();
            
            if (command.IsValid)
            {
                if (command.Verb == "exit")
                {
                    Console.WriteLine("Game Over...Coward");
                    isPlaying = false;
                }
                else
                {
                    CommandHandler.Handle(command);
                }
            }
        }
    }

    private static void Initialize()
    {
        Conditions.Initialize();
        States.Initialize();
        Map.Initialize();
        Items.Initialize();
        Player.Initialize();
    }
}