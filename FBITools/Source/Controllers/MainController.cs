using GNX;

namespace FBITools
{
    public static class MainController
    {
        public static bool ConfigLoaded;

        public static void Init(MainForm formDesign)
        {
            Session.SetIcon();
            Session.mainForm = formDesign;
            Session.mainForm.StatusBar = false;
            Session.mainForm.Shown += form_Shown;
            //Session.mainForm.KeyPreview = true;

            ConfigLoaded = LoadConfigFile();

            Session.mainForm.SetMainFormContent(new MainContentForm());
        }

        static void form_Shown(object sender, System.EventArgs e)
        {
            if (Session.options.DarkMode)
                ToggleDarkMode();

            Session.mainForm.CenterWindow();
        }

        #region Common
        public static void ToggleDarkMode()
        {
            Session.options.DarkMode = Theme.ToggleDarkMode();
            UpdateConfigFile();
        }

        public static bool LoadConfigFile()
        {
            return Json.Load(ref Session.options, Session.options.File);
        }

        public static bool UpdateConfigFile()
        {
            return Json.Save(Session.options, Session.options.File);
        }
        #endregion
    }
}