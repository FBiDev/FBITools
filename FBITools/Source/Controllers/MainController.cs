namespace FBITools
{
    public class MainController
    {
        #region Entrada
        public MainController(MainForm formDesign)
        {
            Session.SetFormIcon();
            Session.MainForm = formDesign;
            Session.MainForm.StatusBarEnable = false;

            Session.MainForm.Shown += form_Shown;
            //Session.mainForm.KeyPreview = true;

            Session.MainForm.SetMainFormContent(new MainContentForm());
        }

        void form_Shown(object sender, System.EventArgs e)
        {
            Theme.SetTheme();
            Session.MainForm.CenterWindow();
        }
        #endregion
    }
}