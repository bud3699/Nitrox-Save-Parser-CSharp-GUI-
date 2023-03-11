using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonParsingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string jsonData = "{\"Players\":[{\"Name\":\"bud\",\"UsedItems\":[\"Flare\"],\"QuickSlotsBinding\":[\"835b57ce-fb1c-49fe-9740-e08acfef7ffb\",\"null\",\"null\",\"null\",\"null\"],\"EquippedItems\":[],\"Modules\":[],\"Id\":1,\"SpawnPosition\":{\"X\":-105.493919,\"Y\":1.9027071,\"Z\":-305.1903},\"SpawnRotation\":{\"X\":0.0,\"Y\":0.6419517,\"Z\":0.0,\"W\":-0.7667451},\"CurrentStats\":{\"Oxygen\":45.0,\"MaxOxygen\":45.0,\"Health\":80.0,\"Food\":45.7381134,\"Water\":83.83331,\"InfectionAmount\":0.1},\"SubRootId\":\"90e44d82-accf-42ea-9c83-fb0d9f002d1e\",\"Permissions\":\"ADMIN\",\"NitroxId\":\"095626d0-472c-431b-a409-5d8b06be828b\",\"IsPermaDeath\":false,\"CompletedGoals\":[\"FilteredWater\",\"NutrientBlock\",\"Flare\",\"Equip_Flare\",\"Open_PDA\",\"Pickup_VehicleHullModule1\",\"VehicleHullModule1\"],\"PingInstancePreferences\":[]}]}";

            JObject parsedJson = JObject.Parse(jsonData);
            JArray playersArray = (JArray)parsedJson["Players"];

            foreach (JObject playerObject in playersArray.Children<JObject>())
            {
                string name = (string)playerObject["Name"];
                JArray usedItems = (JArray)playerObject["UsedItems"];
                JArray quickSlotsBinding = (JArray)playerObject["QuickSlotsBinding"];
                JArray equippedItems = (JArray)playerObject["EquippedItems"];
                JArray modules = (JArray)playerObject["Modules"];
                int id = (int)playerObject["Id"];
                JObject spawnPosition = (JObject)playerObject["SpawnPosition"];
                JObject spawnRotation = (JObject)playerObject["SpawnRotation"];
                JObject currentStats = (JObject)playerObject["CurrentStats"];
                string subRootId = (string)playerObject["SubRootId"];
                string permissions = (string)playerObject["Permissions"];
                string nitroxId = (string)playerObject["NitroxId"];
                bool isPermaDeath = (bool)playerObject["IsPermaDeath"];
                JArray completedGoals = (JArray)playerObject["CompletedGoals"];
                JArray pingInstancePreferences = (JArray)playerObject["PingInstancePreferences"];
            }
        }
    }
}