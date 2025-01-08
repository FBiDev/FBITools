using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public static class Session
    {
        #region Fields
        public const CultureID Language = CultureID.Brazil_Portuguese;
        public const CultureID LanguageNumbers = CultureID.Brazil_Portuguese;

        public const bool SystemLock = true;
        public static readonly string SystemName = AppManager.Name;

        private static Options _options = new Options();
        #endregion

        #region Properties
        public static Options Options
        {
            get { return _options; }
            private set { _options = value; }
        }

        public static MainForm MainPage { get; set; }

        public static MainContentForm MainContentPage { get; set; }

        public static ConfigForm ConfigPage { get; set; }

        public static FileCopyForm FileCopyPage { get; set; }

        public static ImageResizeForm ImageResizePage { get; set; }

        public static VbToCsharpForm VbToCsharpPage { get; set; }

        public static WiiU.WiiUcetkForm WiiUCetkPage { get; set; }
        #endregion

        public static void Load()
        {
            LanguageManager.SetLanguage(Language);
            LanguageManager.SetLanguageNumbers(LanguageNumbers);

            Options.Load();

            WiiU.BancoWiiU.Load();

            MainBaseForm.DebugMode = Options.IsDebugMode;
            MainBaseForm.AutoCenterWindow = Options.IsAutoCenterWindow;
            MainBaseForm.AutoResizeWindow = Options.IsAutoResizeWindow;

            DebugManager.Enable = Options.IsDebugMode;
            DebugManager.LogSQLSistema.SyncList(WiiU.BancoWiiU.Log);
        }

        public static void SetDefaultPageIcon()
        {
            MainBaseForm.Ico = Properties.Resources.ico_app;
        }
    }
}