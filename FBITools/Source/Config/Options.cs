using Newtonsoft.Json;
using GNX.Desktop;

namespace FBITools
{
    public class Options
    {
        #region Options
        [JsonIgnore]
        public const string FileName = "Options.json";
        [JsonIgnore]
        public static bool Loaded;

        bool darkMode = true;
        bool debugMode = true;

        [JsonConverter(typeof(BoolConverter))]
        public bool DarkMode { get { return darkMode; } set { darkMode = value; } }

        [JsonConverter(typeof(BoolConverter))]
        public bool DebugMode { get { return debugMode; } set { debugMode = value; } }

        public bool ToggleDarkMode()
        {
            DarkMode = Theme.ToggleDarkTheme();
            return Session.UpdateOptions();
        }

        public bool ToggleDebugMode()
        {
            DebugMode = !DebugMode;
            DebugManager.Enable = DebugMode;
            MainBaseForm.DebugMode = DebugMode;

            return Session.UpdateOptions();
        }

        public string SaveState_Origin { get; set; }
        public string SaveState_Destination { get; set; }

        public string MemoryCard_Origin { get; set; }
        public string MemoryCard_Destination { get; set; }
        public int MemoryCard_Timer { get; set; }
        #endregion

        #region System
        #endregion
    }
}