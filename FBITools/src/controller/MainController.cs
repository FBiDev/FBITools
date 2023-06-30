namespace FBITools
{
    public static class MainController
    {
        public static MainContentForm content;

        public static void Init(MainForm formDesign)
        {
            Session.SetIcon();
            Theme.SetTheme(Theme.eTheme.Dark);

            Session.mainForm = formDesign;
            Session.mainForm.StatusBar = true;
            Session.mainForm.Init(Session.mainForm);

            content = new MainContentForm();
            Session.mainForm.SetContentForm(content);
        }
    }
}