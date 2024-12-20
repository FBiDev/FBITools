namespace FBITools
{
    public class MainController
    {
        #region Entrada
        public MainController(MainForm page)
        {
            Session.SetFormIcon();
            Session.MainForm = page;
            Session.MainForm.StatusBarEnable = false;

            Session.MainForm.Shown += Page_Shown;

            var contentPage = new MainContentForm();
            Session.MainForm.SetMainFormContent(contentPage);
        }

        private void Page_Shown(object sender, System.EventArgs e)
        {
            Theme.SetTheme();
            Session.MainForm.CenterWindow();
        }
        #endregion
    }
}