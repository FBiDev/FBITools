using System;

namespace FBITools
{
    public class MainCode
    {
        public MainCode()
        {
            Session.MainPage = this;

            Session.SetDefaultPageIcon();
            ////Session.MainPage.StatusBarEnable = true;

            UI = new MainUI();
            UI.Shown += Page_Shown;

            var mainContentPage = new MainContentCode().UI;
            UI.SetMainContentPage(mainContentPage);
        }

        public MainUI UI { get; set; }

        private void Page_Shown(object sender, EventArgs e)
        {
            Theme.SetTheme();
            UI.CenterWindow();
        }
    }
}