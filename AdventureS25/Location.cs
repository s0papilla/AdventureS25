namespace AdventureS25;

public class Location
{
    private string name;
    public string Description;
    
    public Dictionary<string, Location> Connections;
    
    public Location(string nameInput, string descriptionInput)
    {
        name = nameInput;
        Description = descriptionInput;
        Connections = new Dictionary<string, Location>();
    }

    public void AddConnection(string direction, Location location)
    {
        Connections.Add(direction, location);
    }

    public bool CanMoveInDirection(Command command)
    {
        if (Connections.ContainsKey(command.Noun))
        {
            return true;
        }
        return false;
    }

    public Location GetLocationInDirection(Command command)
    {
        return Connections[command.Noun];
    }

    public string GetDescription()
    {
        return name + "\n" + Description;
    }
}