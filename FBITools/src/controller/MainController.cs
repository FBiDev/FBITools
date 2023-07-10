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

            content = new MainContentForm();
            Session.mainForm.SetContentForm(content);

            Theme.SetTheme(GNX.Theme.eTheme.Dark);
        }
    }
}