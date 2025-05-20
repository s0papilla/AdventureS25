namespace AdventureS25;

public static class Game
{
    public static bool isPlaying {get; set; }
    public static void PlayGame()
    {
        isPlaying =true;
        Initialize();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("   \u2584\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588    \u2584\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588    \u2584\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588 \u2588\u2588\u2588\u2584\u2584\u2584\u2584      \u2584\u2588   \u2584\u2588\u2584    \u2584\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588 \u2588\u2588\u2588\u2584\u2584\u2584\u2584           \u2584\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588    \u2584\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588  \u2584\u2588     \u2584\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588 \u2588\u2588\u2588\u2584\u2584\u2584\u2584   \u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2584  \n  \u2588\u2588\u2588    \u2588\u2588\u2588   \u2588\u2588\u2588    \u2588\u2588\u2588   \u2588\u2588\u2588    \u2588\u2588\u2588 \u2588\u2588\u2588\u2580\u2580\u2580\u2588\u2588\u2584   \u2588\u2588\u2588 \u2584\u2588\u2588\u2588\u2580   \u2588\u2588\u2588    \u2588\u2588\u2588 \u2588\u2588\u2588\u2580\u2580\u2580\u2588\u2588\u2584        \u2588\u2588\u2588    \u2588\u2588\u2588   \u2588\u2588\u2588    \u2588\u2588\u2588 \u2588\u2588\u2588    \u2588\u2588\u2588    \u2588\u2588\u2588 \u2588\u2588\u2588\u2580\u2580\u2580\u2588\u2588\u2584 \u2588\u2588\u2588   \u2580\u2588\u2588\u2588 \n  \u2588\u2588\u2588    \u2588\u2580    \u2588\u2588\u2588    \u2588\u2588\u2588   \u2588\u2588\u2588    \u2588\u2588\u2588 \u2588\u2588\u2588   \u2588\u2588\u2588   \u2588\u2588\u2588\u2590\u2588\u2588\u2580     \u2588\u2588\u2588    \u2588\u2580  \u2588\u2588\u2588   \u2588\u2588\u2588        \u2588\u2588\u2588    \u2588\u2580    \u2588\u2588\u2588    \u2588\u2588\u2588 \u2588\u2588\u2588\u258c   \u2588\u2588\u2588    \u2588\u2580  \u2588\u2588\u2588   \u2588\u2588\u2588 \u2588\u2588\u2588    \u2588\u2588\u2588 \n \u2584\u2588\u2588\u2588\u2584\u2584\u2584      \u2584\u2588\u2588\u2588\u2584\u2584\u2584\u2584\u2588\u2588\u2580   \u2588\u2588\u2588    \u2588\u2588\u2588 \u2588\u2588\u2588   \u2588\u2588\u2588  \u2584\u2588\u2588\u2588\u2588\u2588\u2580     \u2584\u2588\u2588\u2588\u2584\u2584\u2584     \u2588\u2588\u2588   \u2588\u2588\u2588       \u2584\u2588\u2588\u2588\u2584\u2584\u2584      \u2584\u2588\u2588\u2588\u2584\u2584\u2584\u2584\u2588\u2588\u2580 \u2588\u2588\u2588\u258c  \u2584\u2588\u2588\u2588\u2584\u2584\u2584     \u2588\u2588\u2588   \u2588\u2588\u2588 \u2588\u2588\u2588    \u2588\u2588\u2588 \n\u2580\u2580\u2588\u2588\u2588\u2580\u2580\u2580     \u2580\u2580\u2588\u2588\u2588\u2580\u2580\u2580\u2580\u2580   \u2580\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588 \u2588\u2588\u2588   \u2588\u2588\u2588 \u2580\u2580\u2588\u2588\u2588\u2588\u2588\u2584    \u2580\u2580\u2588\u2588\u2588\u2580\u2580\u2580     \u2588\u2588\u2588   \u2588\u2588\u2588      \u2580\u2580\u2588\u2588\u2588\u2580\u2580\u2580     \u2580\u2580\u2588\u2588\u2588\u2580\u2580\u2580\u2580\u2580   \u2588\u2588\u2588\u258c \u2580\u2580\u2588\u2588\u2588\u2580\u2580\u2580     \u2588\u2588\u2588   \u2588\u2588\u2588 \u2588\u2588\u2588    \u2588\u2588\u2588 \n  \u2588\u2588\u2588        \u2580\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588   \u2588\u2588\u2588    \u2588\u2588\u2588 \u2588\u2588\u2588   \u2588\u2588\u2588   \u2588\u2588\u2588\u2590\u2588\u2588\u2584     \u2588\u2588\u2588    \u2588\u2584  \u2588\u2588\u2588   \u2588\u2588\u2588        \u2588\u2588\u2588        \u2580\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588 \u2588\u2588\u2588    \u2588\u2588\u2588    \u2588\u2584  \u2588\u2588\u2588   \u2588\u2588\u2588 \u2588\u2588\u2588    \u2588\u2588\u2588 \n  \u2588\u2588\u2588          \u2588\u2588\u2588    \u2588\u2588\u2588   \u2588\u2588\u2588    \u2588\u2588\u2588 \u2588\u2588\u2588   \u2588\u2588\u2588   \u2588\u2588\u2588 \u2580\u2588\u2588\u2588\u2584   \u2588\u2588\u2588    \u2588\u2588\u2588 \u2588\u2588\u2588   \u2588\u2588\u2588        \u2588\u2588\u2588          \u2588\u2588\u2588    \u2588\u2588\u2588 \u2588\u2588\u2588    \u2588\u2588\u2588    \u2588\u2588\u2588 \u2588\u2588\u2588   \u2588\u2588\u2588 \u2588\u2588\u2588   \u2584\u2588\u2588\u2588 \n  \u2588\u2588\u2588          \u2588\u2588\u2588    \u2588\u2588\u2588   \u2588\u2588\u2588    \u2588\u2580   \u2580\u2588   \u2588\u2580    \u2588\u2588\u2588   \u2580\u2588\u2580   \u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588  \u2580\u2588   \u2588\u2580         \u2588\u2588\u2588          \u2588\u2588\u2588    \u2588\u2588\u2588 \u2588\u2580     \u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588  \u2580\u2588   \u2588\u2580  \u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2588\u2580  \n               \u2588\u2588\u2588    \u2588\u2588\u2588                          \u2580                                                    \u2588\u2588\u2588    \u2588\u2588\u2588                                       ");
        Console.ResetColor();  // Reset to default color
        Console.WriteLine("                                 {} {}\n                         !  !  ! II II !  !  !\n                      !  I__I__I_II II_I__I__I  !\n                      I_/|__|__|_|| ||_|__|__|\\_I\n                   ! /|_/|  |  | || || |  |  |\\_|\\ !       \n       .--.        I//|  |  |  | || || |  |  |  |\\\\I        .--.\n      /-   \\    ! /|/ |  |  |  | || || |  |  |  | \\|\\ !    /=   \\\n      \\=__ /    I//|  |  |  |  | || || |  |  |  |  |\\\\I    \\-__ /\n       }  {  ! /|/ |  |  |  |  | || || |  |  |  |  | \\|\\ !  }  {\n      {____} I//|  |  |  |  |  | || || |  |  |  |  |  |\\\\I {____}\n_!__!__|= |=/|/ |  |  |  |  |  | || || |  |  |  |  |  | \\|\\=|  |__!__!_\n_I__I__|  ||/|__|__|__|__|__|__|_|| ||_|__|__|__|__|__|__|\\||- |__I__I_\n-|--|--|- ||-|--|--|--|--|--|--|-|| ||-|--|--|--|--|--|--|-||= |--|--|-\n |  |  |  || |  |  |  |  |  |  | || || |  |  |  |  |  |  | ||  |  |  |\n |  |  |= || |  |  |  |  |  |  | || || |  |  |  |  |  |  | ||= |  |  |\n |  |  |- || |  |  |  |  |  |  | || || |  |  |  |  |  |  | ||= |  |  |\n |  |  |- || |  |  |  |  |  |  | || || |  |  |  |  |  |  | ||- |  |  | \n_|__|__|  ||_|__|__|__|__|__|__|_|| ||_|__|__|__|__|__|__|_||  |__|__|_\n-|--|--|= ||-|--|--|--|--|--|--|-|| ||-|--|--|--|--|--|--|-||- |--|--|-\n-|--|--|| |  |  |  |  |  |  | || || |  |  |  |  |  |  | ||= |  |  | \n~~~~~~~~~~~^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^~~~~~~~~~~~");
        TextEffects.TypeLine("You’ve spent years as the sole caretaker of Desola Graveyard. Your job is to walk the sullen grounds, and make sure everything stays in its place. The quiet of night used to be comforting. Now it lingers too long. You’ve walked these paths more times than you can count, but lately… something feels different. A presence in the fog. A whisper in the stillness. As you begin another long shift, the loneliness gnaws at you. Whatever’s out there… it’s reaching for you. The emptiness inside you pushes you to find a way to reach back.");
        TextEffects.TypeLine("It's a cold and foggy night. You stand at the entrance, ready to begin your shift.");
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