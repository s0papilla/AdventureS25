namespace AdventureS25;

public static class Game
{
    public static void PlayGame()
    {
        Map.Initialize();
        Player.Initialize();
        
        Console.WriteLine(Player.GetLocationDescription());
        
        bool isPlaying = true;
        
        while (isPlaying == true)
        {
            Command command = CommandProcessor.Process();
            
            if (command.IsValid)
            {
                if (command.Verb == "exit")
                {
                    Console.WriteLine("Game Over!");
                    isPlaying = false;
                }
                else
                {
                    CommandHandler.Handle(command);
                }
            }
        }
    }
}