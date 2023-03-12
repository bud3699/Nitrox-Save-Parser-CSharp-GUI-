﻿using System;
using System.IO;
using System.Text;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using NitroxSaveParser;
using ProtoBuf;



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
class PlayersData
{
    public static string PlayerCountstr { get; set; }

    public static void Parse()
    {
        InitialPage initialPage = new InitialPage();
        string json = File.ReadAllText(InitialPage.PlayerDataDir);
        PlayerData playerData;
        using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        {
            playerData = Serializer.Deserialize<PlayerData>(ms);
        }
        List<Player> players = playerData.Players;
        string name = players[0].Name;
        List<string> usedItems = players[0].UsedItems;
        try{List<string> quickSlotsBinding = players[0].QuickSlotsBinding;}
        catch (JsonReaderException ex){ Console.WriteLine(ex.Message); }
        try{List<string> equippedItems = players[0].EquippedItems;}
        catch (JsonReaderException ex){ Console.WriteLine(ex.Message); }
        try {List<string> modules = players[0].Modules; }
        catch (JsonReaderException ex){ Console.WriteLine(ex.Message); }
        string id = players[0].ID;
        Position spawnPosition = players[0].SpawnPosition;
        Rotation spawnRotation = players[0].SpawnRotation;
        Stats currentStats = players[0].CurrentStats;
        string subRootId = players[0].SubRootId;
        string permissions = players[0].Permissions;
        string nitroxId = players[0].Permissions;
        bool isPermaDeath = players[0].IsPermaDeath;
        List<string> completedGoals = players[0].CompletedGoals;
        try { List<string> pingInstancePreferences = players[0].PingInstancePreferences; }
        catch (JsonReaderException ex) { Console.WriteLine(ex.Message); }
        int PlayerCount = 0;
        foreach (var player in players)
        {
            PlayerCount = PlayerCount + 1;
            PlayerCountstr = PlayerCount.ToString();

        }

    }

}