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

        public static void Start()
        {
            LanguageManager.SetLanguage(Language);
            LanguageManager.SetLanguageNumbers(LanguageNumbers);

            Options.Load();

            //Banco.Load();
            WiiU.BancoWiiU.Load();

            MainBaseForm.DebugMode = Options.IsDebugMode;
            MainBaseForm.AutoCenterWindow = Options.IsAutoCenterWindow;
            MainBaseForm.AutoResizeWindow = Options.IsAutoResizeWindow;

            DebugManager.Enable = Options.IsDebugMode;
        }
        #endregion

        #region Forms
        public static void SetFormIcon() { MainBaseForm.Ico = Properties.Resources.ico_app; }

        public static MainForm MainForm;
        public static MainContentForm MainContentForm;

        public static ConfigForm ConfigForm;

        public static FileCopyForm FileCopyForm;
        public static FileBackupForm FileBackupForm;
        public static ImageResizeForm ImageResizeForm;
        public static VbToCsharpForm VbToCsharpForm;
        #endregion

        #region WiiU
        public static WiiUcetkForm WiiUcetkForm;
        #endregion
    }
}