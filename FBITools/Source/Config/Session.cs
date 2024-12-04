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

        public static MainForm MainForm { get; set; }

        public static MainContentForm MainContentForm { get; set; }

        public static ConfigForm ConfigForm { get; set; }

        public static FileCopyForm FileCopyForm { get; set; }

        public static FileBackupForm FileBackupForm { get; set; }

        public static ImageResizeForm ImageResizeForm { get; set; }

        public static VbToCsharpForm VbToCsharpForm { get; set; }

        public static WiiUcetkForm WiiUcetkForm { get; set; }
        #endregion

        public static void Start()
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

        public static void SetFormIcon()
        {
            MainBaseForm.Ico = Properties.Resources.ico_app;
        }
    }
}