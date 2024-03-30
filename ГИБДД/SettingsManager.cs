using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ГИБДД
{
    public class Settings
    {
        public bool IsRemember = false;
    }

    public class SettingsManager
    {
        public static Settings GetSettings()
        {
            if (!File.Exists("settings.json"))
            {
                File.WriteAllText("settings.json", "{}");
            }
            var settingsJson = File.ReadAllText("settings.json");
            return JsonConvert.DeserializeObject<Settings>(settingsJson);
        }

        public static void SaveSettings(Settings settings)
        {
            var finalString = JsonConvert.SerializeObject(settings);
            File.WriteAllText("settings.json", finalString);
        }
    }
}
