namespace FBITools
{
    public static class MainController
    {
        public static MainContentForm content;

        public static void Init(MainForm formDesign)
        {
            BIND.SetIcon();
            GNX.Theme.DarkMode = false;

            BIND.mainForm = formDesign;
            BIND.mainForm.Init(BIND.mainForm);
            BIND.mainForm.StatusBar = false;

            content = new MainContentForm();
            BIND.mainForm.SetContentForm(content);
        }
    }
}