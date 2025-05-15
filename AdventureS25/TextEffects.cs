namespace AdventureS25;

public class TextEffects
{
    public static void TypeLine(string text, int delay = 40)
    {
        foreach (char c in text)
        {
            Console.Write(c);
            Thread.Sleep(delay);
        }
        Console.WriteLine(); // Move to the next line after typing is done
    }
}