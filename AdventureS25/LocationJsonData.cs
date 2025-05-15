﻿namespace AdventureS25;

public class LocationJsonData
{
    public string Name { get; set; }
    
    public string InitialDescription { get; set; }
    public string Description { get; set; }
    
    public Dictionary<string, string> Connections { get; set; }
}