namespace AdventureS25;

public static class Items
{
    private static Dictionary<string, Item> nameToItem = 
        new Dictionary<string, Item>();
    
    public static void Initialize()
    {
        Item sword = new Item("sword",
            "long sword");
        nameToItem.Add("sword", sword);
        
        Item donut = new Item("donut",
            "long donut", false);
        nameToItem.Add("donut", donut);
        
        Item beer = new Item("beer",
            "beer's beer");
        nameToItem.Add("beer", beer);
        
        Item apple = new Item("apple",
            "a shiny rotten apple");
        nameToItem.Add("apple", apple);
        
        // tell the map to add the item at a specific location
        Map.AddItem(sword.Name, "Entrance");
        Map.AddItem(apple.Name, "Entrance");
        Map.AddItem(donut.Name, "Storage");
        Map.AddItem(beer.Name, "Throne Room");
    }

    public static Item GetItemByName(string itemName)
    {
        if (nameToItem.ContainsKey(itemName))
        {
            return nameToItem[itemName];
        }
        return null;
    }
}