using System;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class PlayerData
{
    public static void Parse()
    {
        try
        {
            // Load JSON data from file
            string path = Path.Combine(Directory.GetCurrentDirectory(), "data.json");
            string data = File.ReadAllText(path);

            // Parse JSON data
            JObject json = JObject.Parse(data);
            JArray players = (JArray)json["players"];

            // Iterate over players and store their info in variables
            string[] names = new string[players.Count];
            int[] ids = new int[players.Count];
            string[][] modules = new string[players.Count][];
            for (int i = 0; i < players.Count; i++)
            {
                JObject player = (JObject)players[i];
                names[i] = (string)player["name"];
                ids[i] = (int)player["id"];
                modules[i] = player["modules"].ToObject<string[]>();
            }

            // Print the variables
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine("Name: " + names[i]);
                Console.WriteLine("ID: " + ids[i]);
                Console.Write("Modules: ");
                foreach (string module in modules[i])
                {
                    Console.Write(module + " ");
                }
                Console.WriteLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred: " + ex.Message);
        }
    }
}
