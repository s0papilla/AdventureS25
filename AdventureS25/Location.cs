namespace AdventureS25;

public class Location
{
    private string name;
    public string Description;
    public string InitialDescription;
    
    public Dictionary<string, Location> Connections;
    public List<Item> Items = new List<Item>();
    
    private bool hasPlayerBeenHere = false;
    
    public Location(string nameInput, string descriptionInput, string initialDescriptionInput)
    {
        Name = nameInput;
        Description = descriptionInput;
        Connections = new Dictionary<string, Location>();
        InitialDescription = initialDescriptionInput;
    }

    public string Name { get; }

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
        string fullDescription = name + "\n";

        if (hasPlayerBeenHere)
        {
            fullDescription += Description;
        }
        else
        {
            fullDescription += InitialDescription;
        }
        
        hasPlayerBeenHere = true;
        
        return fullDescription;
    }
    
    public string GetDescriptionWithItems()
    {
        string fullDescription = name + "\n";

        if (hasPlayerBeenHere)
        {
            fullDescription += Description;
        }
        else
        {
            fullDescription += InitialDescription;
        }

        foreach (Item item in Items)
        {
            fullDescription += "\n" + item.GetLocationDescription();
        }

        hasPlayerBeenHere = true;
        
        return fullDescription;
    }

    public void AddItem(Item item)
    {
        Debugger.Write("Adding item "+ item.Name + "to " + name);
        Items.Add(item);
    }

    public bool HasItem(Item itemLookingFor)
    {
        foreach (Item item in Items)
        {
            if (item.Name == itemLookingFor.Name)
            {
                return true;
            }
        }
        
        return false;
    }

    public void RemoveItem(Item item)
    {
        Items.Remove(item);
    }

    public void RemoveConnection(string direction)
    {
        if (Connections.ContainsKey(direction))
        {
            Connections.Remove(direction);
        }
    }
}