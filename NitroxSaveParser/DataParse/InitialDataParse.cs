using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NitroxSaveParser.DataParse
{
    public class InitialDataParse
    {
        public static void InitialData()
        {
            VersionData.Parse();
            PlayerData.Parse();
            //Parse.PlayerData();
        }

    }
}
