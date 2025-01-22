using System;

namespace FBITools
{
    public class MainController
    {
        public MainController(MainForm page)
        {
            Session.SetDefaultPageIcon();
            Session.MainPage = page;
            ////Session.MainPage.StatusBarEnable = true;

            Session.MainPage.Shown += Page_Shown;

            var mainContentPage = new MainContentForm();
            Session.MainPage.SetMainContentPage(mainContentPage);
        }

        private void Page_Shown(object sender, EventArgs e)
        {
            Theme.SetTheme();
            Session.MainPage.CenterWindow();
        }
    }
}