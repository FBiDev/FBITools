using App.Core.Desktop;
using App.File;

namespace FBITools
{
    public class Options
    {
        #region Options
        [JsonIgnore]
        public const string FileName = "Options.json";
        [JsonIgnore]
        public static bool Loaded;
        [JsonIgnore]
        bool darkMode = true;
        bool debugMode = true;
        bool autoCenterWindow = true;
        bool autoResizeWindow = true;

        [JsonConverter(JsonType.Boolean)]
        public bool DarkMode { get { return darkMode; } set { darkMode = value; } }

        [JsonConverter(JsonType.Boolean)]
        public bool DebugMode { get { return debugMode; } set { debugMode = value; } }

        [JsonConverter(JsonType.Boolean)]
        public bool AutoCenterWindow { get { return autoCenterWindow; } set { autoCenterWindow = value; } }

        [JsonConverter(JsonType.Boolean)]
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
        public string FileCopy_Origin { get; set; }
        public string FileCopy_Destination { get; set; }
        public int FileCopy_Type { get; set; }
        public int FileCopy_Timer { get; set; }

        public string FileBackup_Origin { get; set; }
        public string FileBackup_Destination { get; set; }
        public int FileBackup_Type { get; set; }
        public int FileBackup_Timer { get; set; }

        [JsonIgnore]
        public string WiiUDatabaseFile = WiiU.Cetk.Database;
        #endregion
    }
}