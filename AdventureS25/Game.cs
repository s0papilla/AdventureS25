namespace AdventureS25;

public static class Game
{
    public static void PlayGame()
    {
        bool isPlaying = true;
        
        while (isPlaying == true)
        {
            CommandProcessor.Process();

            string input = "exit";
            
            if (input == "exit")
            {
                Console.WriteLine("Game Over!");
                isPlaying = false;
            }
        }
    }
}