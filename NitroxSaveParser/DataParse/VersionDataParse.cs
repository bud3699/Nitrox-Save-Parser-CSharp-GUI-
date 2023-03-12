using System;
using System.IO;
using Newtonsoft.Json;
using NitroxSaveParser;

class VersionData
{

    public static string Versionstr { get; set; }
    public static void Parse()
    {
        IntialPage nitialPage = new IntialPage();
        string directory = IntialPage.dir;
        // Read the file contents into a string
        string json = File.ReadAllText(directory);

        // Deserialize the JSON data into a dynamic object
        dynamic data = JsonConvert.DeserializeObject(json);

        // Get the individual values from the dynamic object
        int major = data.Major;
        int minor = data.Minor;
        int build = data.Build;
        int revision = data.Revision;

        // Put the values into a variable
        Version version = new Version(major, minor, build, revision);
        Versionstr = version.ToString();
    }
}