using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public static class Session
    {
        public const CultureID Language = CultureID.UnitedStates_English;
        public const CultureID LanguageNumbers = CultureID.Brazil_Portuguese;

        public const bool SystemLock = true;
        public static readonly string SystemName = AppManager.Name;

        private static Options _options = new Options();

        public static Options Options
        {
            get { return _options; }
            private set { _options = value; }
        }

        public static MainCode MainPage { get; set; }

        public static MainContentCode MainContentPage { get; set; }

        public static MainMenuCode MainMenuPage { get; set; }

        public static ConfigCode ConfigPage { get; set; }

        public static FileCopyCode FileCopyPage { get; set; }

        public static ImageResizeCode ImageResizePage { get; set; }

        public static VbToCsharpCode VbToCsharpPage { get; set; }

        public static WiiU.WiiUCode WiiUPage { get; set; }

        public static WebCrawlerCode WebCrawlerPage { get; set; }

        public static void Load()
        {
            LanguageManager.SetLanguage(Language);
            LanguageManager.SetLanguageNumbers(LanguageNumbers);

            Options.Load();

            WiiU.DatabaseWiiU.Load();
            DebugManager.LogSQLSistema.SyncList(WiiU.DatabaseWiiU.Log);
        }

        public static void SetDefaultPageIcon()
        {
            MainBaseForm.Ico = Properties.Resources.ico_app;
        }
    }
}