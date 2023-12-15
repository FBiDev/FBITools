namespace FBITools
{
    public static class MainController
    {
        #region Entrada
        public static void Init(MainForm formDesign)
        {
            Session.SetFormIcon();
            Session.MainForm = formDesign;
            Session.MainForm.StatusBarEnable = false;

            Session.MainForm.Shown += form_Shown;
            //Session.mainForm.KeyPreview = true;

            Session.MainForm.SetMainFormContent(new MainContentForm());
        }

        static void form_Shown(object sender, System.EventArgs e)
        {
            Theme.SetTheme();
            Session.MainForm.CenterWindow();
        }
        #endregion
    }
}