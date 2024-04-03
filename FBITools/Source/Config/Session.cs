using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public static class Session
    {
        #region Options
        public static Options Options = new Options();

        public static bool LoadOptions()
        { return Options.Loaded = Json.Load(ref Options, Options.FileName); }

        public static bool UpdateOptions()
        { return Json.Save(Options, Options.FileName); }
        #endregion

        #region Main
        public const bool Singleton = true;
        public static string SystemName = AppManager.Name;

        public const CultureID Language = CultureID.Brazil_Portuguese;
        public const CultureID LanguageNumbers = CultureID.Brazil_Portuguese;

        public static void Start()
        {
            LanguageManager.SetLanguage(Language);
            LanguageManager.SetLanguageNumbers(LanguageNumbers);
            //AppManager.Start();

            LoadOptions();

            //Banco.Load();

            MainBaseForm.DebugMode = Options.DebugMode;
            MainBaseForm.AutoCenterWindow = Options.AutoCenterWindow;
            MainBaseForm.AutoResizeWindow = Options.AutoResizeWindow;

            DebugManager.Enable = Options.DebugMode;
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
    }
}