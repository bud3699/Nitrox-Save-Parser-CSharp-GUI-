using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

class PlayerData
{
    public List<Player> Players { get; set; }
}

class Player
{
    public string Name { get; set; }
    public List<string> UsedItems { get; set; }
    public List<string> QuickSlotsBinding { get; set; }
    public List<string> EquippedItems { get; set; }
    public List<string> Modules { get; set; }
    public string ID { get; set; }
    public Position SpawnPosition { get; set; }
    public Rotation SpawnRotation { get; set; }
    public Stats CurrentStats { get; set; }
    public string SubRootId { get; set; }
    public string Permissions { get; set; }
    public string NitroxId { get; set; }
    public bool IsPermaDeath { get; set; }
    public List<string> CompletedGoals { get; set; }
    public List<string> PingInstancePreferences { get; set; }
}

class Position
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }
}

class Rotation
{
    public float X { get; set; }
    public float Y { get; set; }
    public float Z { get; set; }
    public float W { get; set; }
}

class Stats
{
    public float Oxygen { get; set; }
    public float MaxOxygen { get; set; }
    public float Health { get; set;}
    public float Food { get; set; }
    public float Water { get; set; }
    public float InfectionAmount { get; set; }
}
class parse
{
    public static void PlayerParse()
    {
        string json = File.ReadAllText("PlayerData.json");
        PlayerData playerData = JsonConvert.DeserializeObject<PlayerData>(json);
        List<Player> players = playerData.Players;
        string name = players[0].Name;
        List<string> usedItems = players[0].UsedItems;
        List<string> quickSlotsBinding = players[0].QuickSlotsBinding;
        List<string> equippedItems = players[0].QuickSlotsBinding;
        List<string> modules = players[0].Modules;
        string id = players[0].ID;
        Position spawnPosition = players[0].SpawnPosition;
        Rotation spawnRotation = players[0].SpawnRotation;
        Stats currentStats = players[0].CurrentStats;
        string subRootId = players[0].SubRootId;
        string permissions = players[0].Permissions;
        string nitroxId = players[0].Permissions;
        bool isPermaDeath = players[0].IsPermaDeath;
        List<string> completedGoals = players[0].CompletedGoals;
        List<string> pingInstancePreferences = players[0].PingInstancePreferences;

    }

}