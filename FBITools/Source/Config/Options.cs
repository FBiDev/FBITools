using Newtonsoft.Json;
using App.Core.Desktop;

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
        bool autoCenterWindow = true;
        bool autoResizeWindow = true;

        [JsonConverter(typeof(BoolConverter))]
        public bool DarkMode { get { return darkMode; } set { darkMode = value; } }

        [JsonConverter(typeof(BoolConverter))]
        public bool DebugMode { get { return debugMode; } set { debugMode = value; } }

        [JsonConverter(typeof(BoolConverter))]
        public bool AutoCenterWindow { get { return autoCenterWindow; } set { autoCenterWindow = value; } }

        [JsonConverter(typeof(BoolConverter))]
        public bool AutoResizeWindow { get { return autoResizeWindow; } set { autoResizeWindow = value; } }

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

        public bool ToggleAutoCenterWindow()
        {
            AutoCenterWindow = !AutoCenterWindow;
            MainBaseForm.AutoCenterWindow = AutoCenterWindow;
            return Session.UpdateOptions();
        }

        public bool ToggleAutoResizeWindow()
        {
            AutoResizeWindow = !AutoResizeWindow;
            MainBaseForm.AutoResizeWindow = AutoResizeWindow;
            return Session.UpdateOptions();
        }
        #endregion

        #region System
        public string SaveState_Origin { get; set; }
        public string SaveState_Destination { get; set; }
        public int SaveState_Type { get; set; }
        public int SaveState_Timer { get; set; }

        public string MemoryCard_Origin { get; set; }
        public string MemoryCard_Destination { get; set; }
        public int MemoryCard_Type { get; set; }
        public int MemoryCard_Timer { get; set; }
        #endregion
    }
}