using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public static class Session
    {
        public const bool SystemLock = true;
        public static readonly string SystemName = AppManager.Name;

        private const CultureID Language = CultureID.UnitedStates_English;
        private const CultureID LanguageNumbers = CultureID.Brazil_Portuguese;

        public static readonly Options Options = new Options();

        // MasterForm
        public static MainForm MainPage { get; set; }

        public static MainContentForm MainContentPage { get; set; }

        // Forms
        public static ConfigForm ConfigPage { get; set; }

        public static FileCopyForm FileCopyPage { get; set; }

        public static ImageResizeForm ImageResizePage { get; set; }

        public static VbToCsharpForm VbToCsharpPage { get; set; }

        public static WiiU.WiiUForm WiiUPage { get; set; }

        public static WebCrawlerForm WebCrawlerPage { get; set; }

        public static void Load()
        {
            LanguageManager.SetLanguage(Language);
            LanguageManager.SetLanguageNumbers(LanguageNumbers);

            Options.Load();

            WiiU.DatabaseWiiU.Load();
            DebugManager.LogSQLSistema.SyncList(WiiU.DatabaseWiiU.Log);

            Network.Load();
        }

        public static void SetDefaultPageIcon()
        {
            MainBaseForm.Ico = Properties.Resources.ico_app;
        }
    }
}