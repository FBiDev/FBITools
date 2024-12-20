namespace FBITools
{
    public class MainController
    {
        #region Entrada
        public MainController(MainForm pageForm)
        {
            Session.SetFormIcon();
            Session.MainForm = pageForm;
            Session.MainForm.StatusBarEnable = false;

            Session.MainForm.Shown += ShownForm;

            var contentPage = new MainContentForm();
            Session.MainForm.SetMainFormContent(contentPage);
        }

        private void ShownForm(object sender, System.EventArgs e)
        {
            Theme.SetTheme();
            Session.MainForm.CenterWindow();
        }
        #endregion
    }
}