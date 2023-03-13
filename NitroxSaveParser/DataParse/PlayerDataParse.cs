using System;
using System.IO;
using System.Text;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using NitroxSaveParser;
using ProtoBuf;
using Newtonsoft.Json.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Linq.Expressions;
using System.Net;

public class EmptyArrayToNullConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        return objectType.IsArray || objectType.IsGenericType;
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType == JsonToken.Null)
            return null;

        // If the token is a start array and the next token is an end array, return null
        if (reader.TokenType == JsonToken.StartArray && reader.Read() && reader.TokenType == JsonToken.EndArray)
            return null;

        var elementType = objectType.IsArray ? objectType.GetElementType() : objectType.GetGenericArguments()[0];
        var listType = typeof(List<>).MakeGenericType(elementType);
        var list = (IList)Activator.CreateInstance(listType);

        if (reader.TokenType == JsonToken.StartArray)
        {
            while (reader.Read() && reader.TokenType != JsonToken.EndArray)
            {
                var value = serializer.Deserialize(reader, elementType);
                list.Add(value);
            }
        }
        else
        {
            var value = serializer.Deserialize(reader, elementType);
            list.Add(value);
        }

        if (objectType.IsArray)
        {
            var array = Array.CreateInstance(elementType, list.Count);
            list.CopyTo(array, 0);
            return array;
        }

        return list;
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        serializer.Serialize(writer, value);
    }
}
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
        // PlayerData playerData;
        PlayerData playerData = JsonConvert.DeserializeObject<PlayerData>(json, new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore,
            Converters = new List<JsonConverter> { new EmptyArrayToNullConverter() }
        });   //This is the original Deserialize code
        //using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        //{
        //    playerData = Serializer.Deserialize<PlayerData>(ms);
        //}
        List<Player> players = playerData.Players;
        string name = players[0].Name;
        List<string> usedItems = players[0].UsedItems;
        try{List<string> quickSlotsBinding = players[0].QuickSlotsBinding;}
        catch (JsonReaderException ex){ Console.WriteLine(ex.Message); }
        List<string> equippedItems = null;
        if (players[0].EquippedItems != null)
        {
            equippedItems = players[0].EquippedItems;
        }
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