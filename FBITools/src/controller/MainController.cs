namespace FBITools
{
    public static class MainController
    {
        public static MainContentForm content;

        public static void Init(MainForm formDesign)
        {
            Session.SetIcon();
            Theme.SetTheme(GNX.Theme.eTheme.Light);

            Session.mainForm = formDesign;
            Session.mainForm.StatusBar = true;
            Session.mainForm.Init();

            content = new MainContentForm();
            Session.mainForm.SetContentForm(content);
        }
    }
}