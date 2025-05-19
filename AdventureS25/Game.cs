namespace AdventureS25;

public static class Game
{
    public static bool isPlaying {get; set; }
    public static void PlayGame()
    {
        isPlaying =true;
        Initialize();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome to Frankenfriend!");
        Console.ResetColor();  // Reset to default color
        //Console.WriteLine("\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u28c0\u28c0\u2840\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\n\u2800\u2800\u2800\u2800\u2800\u2800\u28e0\u28d4\u287f\u281b\u2812\u2812\u2855\u2884\u2800\u2800\u2800\u2800\u2800\u2800\n\u2800\u2800\u2800\u2800\u28c0\u28f4\u28f3\u2803\u2800\u2800\u2800\u2800\u2818\u288e\u2866\u28c4\u2800\u2800\u2800\u2800\n\u2800\u2800\u2800\u28dc\u281f\u2801\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2808\u2822\u28f3\u2800\u2800\u2800\n\u2800\u2800\u28b8\u28f8\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2847\u2846\u2800\u2800\n\u2800\u2800\u2818\u284f\u2880\u28b4\u2836\u28e4\u2884\u28b2\u28f2\u2826\u28e6\u28e4\u2864\u2840\u2847\u2807\u2800\u2800\n\u2800\u2800\u2800\u28e7\u2800\u28fe\u2880\u28f8\u2878\u2818\u28b8\u2800\u28ff\u2800\u28f8\u284f\u28e7\u2800\u2800\u2800\n\u2800\u2800\u2800\u28b9\u2800\u28ff\u283f\u286f\u2840\u2880\u28fc\u2880\u28ff\u281b\u2809\u2800\u28bb\u2800\u2800\u2800\n\u2800\u2800\u2800\u28ff\u2810\u281b\u2802\u2818\u281b\u2812\u281b\u280a\u281b\u2802\u2800\u28b8\u28b8\u2800\u2800\u2800\n\u2800\u2800\u2800\u28ff\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u28b8\u287c\u2800\u2800\u2800\n\u2800\u2800\u2800\u28bb\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u28b8\u2846\u2800\u2800\u2800\n\u2800\u2800\u2880\u28be\u2847\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u28b8\u2877\u2840\u2800\u2800\n\u2800\u28e0\u2803\u2818\u280a\u2809\u281b\u281b\u280b\u2829\u2829\u282d\u280d\u281b\u281b\u281b\u2803\u2810\u2844\u2800\n\u2800\u28ef\u2849\u2809\u2889\u2849\u2809\u2809\u2809\u2809\u2809\u2809\u28c9\u28c9\u28c9\u28c9\u28c9\u28c9\u28f9\u2800\n\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800\u2800");
        //TextEffects.TypeLine("You’ve spent years as the sole caretaker of Desola Graveyard. The quiet used to be comforting. Now it lingers too long. You’ve walked these paths more times than you can count, but lately… something feels different. A presence in the fog. A whisper in the stillness. You don’t see anything — not really. But sometimes you wake with dirt under your nails. As you begin another long shift, the loneliness gnaws at you. Whatever’s out there… it’s reaching for you. And somehow, you know, you need to find a way to reach back.");
        //TextEffects.TypeLine("It's a cold and foggy night. You stand at the entrance, ready to begin your shift.");
        Console.WriteLine("You hesitate. Another day another dollar. Type 'enter' to step inside...");

        string input = Console.ReadLine()?.Trim().ToLower();

        while (input != "enter")
        {
            Console.WriteLine("You hesitate. The night is cold. Type 'enter' to step inside.");
            input = Console.ReadLine()?.Trim().ToLower();
        }
        TextEffects.TypeLine("You step through the gates. The fog rolls in behind you.");
        TextEffects.TypeLine("Without your flashlight it might be hard to see through this fog...");
        Console.WriteLine(Player.GetLocationDescription());
        Console.WriteLine("You should head north to your office and grab your flashlight before making your rounds.");
       
        
        while (isPlaying == true)
        {
            Command command = CommandProcessor.Process();
            
            if (command.IsValid)
            {
                if (command.Verb == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
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