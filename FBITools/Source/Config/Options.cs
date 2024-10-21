using App.Core.Desktop;
using App.File;
using App.File.Desktop;

namespace FBITools
{
    public class Options
    {
        #region Options
        [JsonIgnore]
        public const string FileName = "Options.json";
        [JsonIgnore]
        public static bool IsLoaded;

        public Options()
        {
            IsDarkMode = true;
            IsDebugMode = true;
            IsAutoCenterWindow = true;
            IsAutoResizeWindow = true;
        }

        [JsonConverter(JsonType.Boolean)]
        public bool IsDarkMode { get; set; }

        [JsonConverter(JsonType.Boolean)]
        public bool IsDebugMode { get; set; }

        [JsonConverter(JsonType.Boolean)]
        public bool IsAutoCenterWindow { get; set; }

        [JsonConverter(JsonType.Boolean)]
        public bool IsAutoResizeWindow { get; set; }

        public bool ToggleDarkMode()
        {
            IsDarkMode = Theme.ToggleDarkTheme();
            return Update();
        }

        public bool ToggleDebugMode()
        {
            IsDebugMode = !IsDebugMode;
            DebugManager.Enable = IsDebugMode;
            MainBaseForm.DebugMode = IsDebugMode;

            return Update();
        }

        public bool ToggleAutoCenterWindow()
        {
            IsAutoCenterWindow = !IsAutoCenterWindow;
            MainBaseForm.AutoCenterWindow = IsAutoCenterWindow;
            return Update();
        }

        public bool ToggleAutoResizeWindow()
        {
            IsAutoResizeWindow = !IsAutoResizeWindow;
            MainBaseForm.AutoResizeWindow = IsAutoResizeWindow;
            return Update();
        }
        #endregion

        public bool Load()
        {
            return IsLoaded = Json.Load(this, FileName);
        }

        public bool Update()
        {
            return Json.Save(this, FileName);
        }

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