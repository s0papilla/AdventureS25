namespace AdventureS25;

public static class Map
{
    public static Location StartLocation;
    
    public static void Initialize()
    {
        Location entrance = new Location("Entrance", 
            "This is the entrance room. Everything starts here.");
        Location storage = new Location("Storage", 
            "You are in a small storage room. There are lots of things.");
        Location throne = new Location("Throne Room", 
            "There is a big ass throne here.");
        
        entrance.AddConnection("east", storage);
        storage.AddConnection("west", entrance);
        throne.AddConnection("south", entrance);
        entrance.AddConnection("north", throne);

        StartLocation = entrance;
    }
}