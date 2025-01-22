using App.Core.Desktop;
using App.File.Json;

namespace FBITools
{
    public class Options
    {
        #region Fields
        [JsonIgnore]
        public readonly string FileName = "Options.json";
        [JsonIgnore]
        public readonly string WiiUDatabaseFile = WiiU.Cetk.Database;
        #endregion

        public Options()
        {
            IsDarkMode = true;
            IsDebugMode = true;
            IsAutoCenterWindow = true;
            IsAutoResizeWindow = true;
        }

        #region Properties
        [JsonIgnore]
        public static bool IsLoaded { get; private set; }

        [JsonConverter(JsonType.Boolean)]
        public bool IsDarkMode { get; set; }

        [JsonConverter(JsonType.Boolean)]
        public bool IsDebugMode { get; set; }

        [JsonConverter(JsonType.Boolean)]
        public bool IsAutoCenterWindow { get; set; }

        [JsonConverter(JsonType.Boolean)]
        public bool IsAutoResizeWindow { get; set; }

        public string FileCopy_Origin { get; set; }

        public string FileCopy_Destination { get; set; }

        [JsonConverter(JsonType.Boolean)]
        public bool FileCopy_CustomDestination { get; set; }

        public int FileCopy_Type { get; set; }

        public int FileCopy_Timer { get; set; }
        #endregion

        public bool Load()
        {
            IsLoaded = Json.Load(this, FileName);

            MainBaseForm.AutoCenterWindow = IsAutoCenterWindow;
            MainBaseForm.AutoResizeWindow = IsAutoResizeWindow;

            MainBaseForm.DebugMode = IsDebugMode;
            DebugManager.Enable = IsDebugMode;

            return IsLoaded;
        }

        public bool Update()
        {
            return Json.Save(this, FileName);
        }

        public bool ToggleDarkMode()
        {
            IsDarkMode = Theme.ToggleDarkTheme();

            return Update();
        }

        public bool ToggleDebugMode()
        {
            IsDebugMode = !IsDebugMode;
            MainBaseForm.DebugMode = IsDebugMode;
            DebugManager.Enable = IsDebugMode;

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
    }
}