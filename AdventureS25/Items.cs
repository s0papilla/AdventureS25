namespace AdventureS25;

public static class Items
{
    public static void Initialize()
    {
        Item sword = new Item("sword",
            "long sword");
        Item donut = new Item("donut",
            "long donut", false);
        Item beer = new Item("beer",
            "beer's beer");
        
        // tell the map to add the item at a specific location
        Map.AddItem(sword.Name, "Entrance");
    }
}