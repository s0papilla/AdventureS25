namespace AdventureS25;

public class Location
{
    private string name;
    public Dictionary<string, Location> Connections;

    public Location(string nameInput)
    {
        name = nameInput;        
    }
}