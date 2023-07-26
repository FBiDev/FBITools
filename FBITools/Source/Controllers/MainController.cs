namespace FBITools
{
    public static class MainController
    {
        public static MainContentForm content;

        public static void Init(MainForm formDesign)
        {
            Session.SetIcon();
            Session.mainForm = formDesign;
            Session.mainForm.StatusBar = true;
            Session.mainForm.Shown += mainForm_Shown;

            content = new MainContentForm();
            Session.mainForm.SetMainFormContent(content);
        }

        static void mainForm_Shown(object sender, System.EventArgs e)
        {
            Theme.SetTheme(GNX.Theme.eTheme.Dark);
        }
    }
}