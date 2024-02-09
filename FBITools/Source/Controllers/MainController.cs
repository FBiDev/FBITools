namespace FBITools
{
    public class MainController
    {
        #region Entrada
        public MainController(MainForm form)
        {
            Session.SetFormIcon();
            Session.MainForm = form;
            Session.MainForm.StatusBarEnable = false;

            Session.MainForm.Shown += form_Shown;
            //Session.MainForm.KeyPreview = true;

            var content = new MainContentForm();
            Session.MainForm.SetMainFormContent(content);
        }

        void form_Shown(object sender, System.EventArgs e)
        {
            Theme.SetTheme();
            Session.MainForm.CenterWindow();
        }
        #endregion
    }
}