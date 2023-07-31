using System.Windows.Forms;
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
            Session.mainForm.StatusBar = true;
            Session.mainForm.Shown += form_Shown;

            Session.mainForm.KeyPreview = true;
            Session.mainForm.KeyDown += form_KeyDown;

            Session.mainForm.SetMainFormContent(new MainContentForm());

            ConfigLoaded = LoadConfigFile();
        }

        static void form_Shown(object sender, System.EventArgs e)
        {
            Theme.SetTheme(GNX.Theme.eTheme.Dark);
        }

        static void form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.A) return;

            Theme.DarkMode();
        }

        #region Common
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