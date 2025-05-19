namespace AdventureS25;

public static class Player
{
    public static Location CurrentLocation;
    public static List<Item> Inventory;

    public static void Initialize()
    {
        Inventory = new List<Item>();
        CurrentLocation = Map.StartLocation;
    }

    public static void Move(Command command)
    {
        if (CurrentLocation.CanMoveInDirection(command))
        {
            CurrentLocation = CurrentLocation.GetLocationInDirection(command);
            
            if (CurrentLocation.Name != "The Office" && CurrentLocation.Name != "Graveyard Entrance" && !Inventory.Contains(Items.GetItemByName("flashlight")))
            {
                TextEffects.TypeLine("It is too dark for you to see anything, you should grab your flashlight from the office so that you can see through this fog");
            }
            
            if (CurrentLocation.Name == "The Office")
            {
                if (Inventory.Contains(Items.GetItemByName("head"))
                    && Inventory.Contains(Items.GetItemByName("torso"))
                    && Inventory.Contains(Items.GetItemByName("rightleg"))
                    && Inventory.Contains(Items.GetItemByName("leftleg"))
                    && Inventory.Contains(Items.GetItemByName("rightarm"))
                    && Inventory.Contains(Items.GetItemByName("leftarm")))
                {
                    TextEffects.TypeLine("The heavy patter of rain begins, growing louder with each passing second." +
                                         " Thunder rumbles deep in the distance, shaking the windows of the office. " +
                                         "The dim light flickers as a cold wind howls through the cracked door." +
                                         "You stand in the center of the room, the eerie glow of the storm casting jagged shadows across the walls. " +
                                         "Before you lies the collection of body parts ... the missing pieces you hunted for, each waiting to become something more." +
                                         "With deliberate hands, you clear the cluttered desk. Papers scatter to the floor." +
                                         "Your heartbeat pounds in your ears as you pick up the torso ... placing it firmly on the dusty desk." +
                                         "One by one, the limbs follow: the right arm, left arm, right leg, left leg. Each piece clicks into place with an unnerving sound. " +
                                         "The room seems to grow colder, the storm’s fury swelling beyond the walls." +
                                         "Finally, your trembling hands reach for the head. As it settles atop the shoulders, the storm outside only gets louder. Lightning flashes violently, illuminating the room for a brief, blinding moment." +
                                         "Then... silence...." +
                                         "The creation before you stirs, as if waking from a long, haunted sleep. The shadows retreat, and a new presence fills the office — your Franken-Friend greets you with a soft smile as it has come to life.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You will no longer be lonely.");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The End :)");
                    Console.ResetColor();
                    Game.isPlaying = false;
                    return;
                } 
                
                if (Inventory.Contains(Items.GetItemByName("flashlight")))
                {
                    
                    Console.WriteLine("Your loneliness gnaws at you. You are too lonely to go back to work..."); 
                }

            }

            Console.WriteLine(CurrentLocation.GetDescription());
        }
        else
        {
            Console.WriteLine("You can't move " + command.Noun + ".");
        }
    }

    public static string GetLocationDescription()
    {
        return CurrentLocation.GetDescription();
    }

    public static void Take(Command command)
    {
        // figure out which item to take: turn the noun into an item
        Item item = Items.GetItemByName(command.Noun);

        if (item == null)
        {
            Console.WriteLine("I don't know what " + command.Noun + " is.");
        }
        else if (!CurrentLocation.HasItem(item))
        {
            Console.WriteLine("There is no " + command.Noun + " here.");
        }
        else if (!item.IsTakeable)
        {
            Console.WriteLine("The " + command.Noun + " can't be taken.");
        }
        else
        {
            Inventory.Add(item);
            CurrentLocation.RemoveItem(item);
            item.Pickup();

            if (item.Name == "head")
            {
                Console.WriteLine("This guy’s got a good head on his shoulders...once he has shoulders, anyway.");
            }
            else if (item.Name == "torso")
            {
                Console.WriteLine("You’ve got guts...literally. They're probably in here somewhere.");
            }
            else if (item.Name == "leftleg")
            {
                Console.WriteLine("You pick up the left leg... No time to drag your feet, this one’s coming with you.");
            }
            else if (item.Name == "rightleg")
            {
                Console.WriteLine("You pick up the right leg... seems like a step in the right direction.");
            }
            else if (item.Name == "leftarm")
            {
                Console.WriteLine("Left arm retrieved! High five... well, eventually.");
            }
            else if (item.Name == "rightarm")
            {
                Console.WriteLine("Right arm collected! Now that's a right-hand man you can count on.");
            }
            else
                Console.WriteLine("You take the " + command.Noun + ".");
        }
    }

    public static void ShowInventory()
    {
        if (Inventory.Count == 0)
        {
            Console.WriteLine("You are empty-handed.");
        }
        else
        {
            Console.WriteLine("You are carrying:");
            foreach (Item item in Inventory)
            {
                string article = SemanticTools.CreateArticle(item.Name);
                Console.WriteLine(" " + article + " " + item.Name);
            }
        }
    }

    public static void Look()
    {
        // Check if it's too dark to see
        if (
            CurrentLocation.Name != "The Office" &&
            CurrentLocation.Name != "Graveyard Entrance" &&
            !Inventory.Contains(Items.GetItemByName("flashlight"))
        )
        {
            TextEffects.TypeLine("It’s too dark to see anything. You need your flashlight to look around.");
            return;
        }

        // If it's bright enough, show the normal description
        Console.WriteLine(CurrentLocation.GetDescriptionWithItems());
    }

    public static void Drop(Command command)
    {
        Item item = Items.GetItemByName(command.Noun);

        if (item == null)
        {
            string article = SemanticTools.CreateArticle(command.Noun);
            Console.WriteLine("I don't know what " + article + " " + command.Noun + " is.");
        }
        else if (!Inventory.Contains(item))
        {
            Console.WriteLine("You're not carrying the " + command.Noun + ".");
        }
        else
        {
            Inventory.Remove(item);
            CurrentLocation.AddItem(item);
            Console.WriteLine("You drop the " + command.Noun + ".");
        }

    }

    public static void Drink(Command command)
    {
        if (command.Noun == "beer")
        {
            Console.WriteLine("** drinking beer");
            Conditions.ChangeCondition(ConditionTypes.IsDrunk, true);
            RemoveItemFromInventory("beer");
            AddItemToInventory("beer-bottle");
        }
    }

    public static void AddItemToInventory(string itemName)
    {
        Item item = Items.GetItemByName(itemName);

        if (item == null)
        {
            return;
        }

        Inventory.Add(item);
    }

    public static void RemoveItemFromInventory(string itemName)
    {
        Item item = Items.GetItemByName(itemName);
        if (item == null)
        {
            return;
        }

        Inventory.Remove(item);
    }

    public static void MoveToLocation(string locationName)
    {
        // look up the location object based on the name
        Location newLocation = Map.GetLocationByName(locationName);

        // if there's no location with that name
        if (newLocation == null)
        {
            Console.WriteLine("Trying to move to unknown location: " + locationName + ".");
            return;
        }

        // set our current location to the new location
        CurrentLocation = newLocation;

        // print out a description of the location
        Look();
    }

    public static void Examine(string noun)
    {
        if (CurrentLocation.Name == "The Office")
        {
            string[] lines = new string[]
            {
                "[Mausoleum]",
                "↑",
                "[West Lot] ← [Grounds] → [East Lot]",
                "↑", 
                "[Office]", 
                "↑",
                "[Entrance]"
            };
            int width = lines.Max(line => line.Length);
            // Print each line centered within the specified width
            foreach (string line in lines)
            {
                // Center the text using PadLeft and PadRight
                string centeredText = line.PadLeft((width - line.Length) / 2 + line.Length)
                    .PadRight(width);
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(centeredText);
                Console.ResetColor();
            }
          
        }
        else
        {
            Console.WriteLine("You don't see a map here.");
        }
    }
}