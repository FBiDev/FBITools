using App.Core.Desktop;
using App.Serialization;

namespace FBITools
{
    public class Options
    {
        [JsonIgnore]
        private const string FileName = "Options.json";

        public Options()
        {
            IsDarkMode = true;
            IsDebugMode = true;
            IsAutoCenterWindow = true;
            IsAutoResizeWindow = true;
        }

        [JsonIgnore]
        public static bool IsLoaded { get; private set; }

        [JsonConverter(JsonType.Boolean)]
        public bool IsDarkMode { get; private set; }

        [JsonConverter(JsonType.Boolean)]
        public bool IsDebugMode { get; private set; }

        [JsonConverter(JsonType.Boolean)]
        public bool IsAutoCenterWindow { get; private set; }

        [JsonConverter(JsonType.Boolean)]
        public bool IsAutoResizeWindow { get; private set; }

        public string FileCopyOrigin { get; set; }

        public string FileCopyDestination { get; set; }

        [JsonConverter(JsonType.Boolean)]
        public bool FileCopyCustomDestination { get; set; }

        public int FileCopyType { get; set; }

        public int FileCopyTimer { get; set; }

        public void Load()
        {
            IsLoaded = Json.Load(this, FileName);

            MainBaseForm.AutoCenterWindow = IsAutoCenterWindow;
            MainBaseForm.AutoResizeWindow = IsAutoResizeWindow;

            MainBaseForm.DebugMode = IsDebugMode;
            DebugManager.Enable = IsDebugMode;
        }

        public void Update()
        {
            Json.Save(this, FileName);
        }

        public void ToggleDarkMode()
        {
            IsDarkMode = Theme.ToggleDarkTheme();

            Update();
        }

        public void ToggleDebugMode()
        {
            IsDebugMode = !IsDebugMode;
            MainBaseForm.DebugMode = IsDebugMode;
            DebugManager.Enable = IsDebugMode;

            Update();
        }

        public void ToggleAutoCenterWindow()
        {
            IsAutoCenterWindow = !IsAutoCenterWindow;
            MainBaseForm.AutoCenterWindow = IsAutoCenterWindow;

            Update();
        }

        public void ToggleAutoResizeWindow()
        {
            IsAutoResizeWindow = !IsAutoResizeWindow;
            MainBaseForm.AutoResizeWindow = IsAutoResizeWindow;

            Update();
        }
    }
}