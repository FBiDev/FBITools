using System;

namespace FBITools
{
    public partial class MainMenuCode
    {
        public MainMenuCode()
        {
            Session.MainMenuPage = this;

            UI = new MainMenuUI();
            UI.Shown += Page_Shown;
            UI.KeyPreview = true;
        }

        public MainMenuUI UI { get; set; }

        private void Page_Shown(object sender, EventArgs ev)
        {
            UI.FileCopyTabButton.Click += (s, e) => Session.MainContentPage.SetContent(s, Session.FileCopyPage);
            UI.ImageResizeTabButton.Click += (s, e) => Session.MainContentPage.SetContent(s, Session.ImageResizePage);
            UI.VbCsharpTabButton.Click += (s, e) => Session.MainContentPage.SetContent(s, Session.VbToCsharpPage);
            UI.WiiUTabButton.Click += (s, e) => Session.MainContentPage.SetContent(s, Session.WiiUPage);
            UI.WebCrawlerButton.Click += (s, e) => Session.MainContentPage.SetContent(s, Session.WebCrawlerPage);

            UI.ConfigTabButton.Click += (s, e) => Session.MainContentPage.SetContent(s, Session.ConfigPage);

            UI.FileCopyTabButton.PerformClick();
        }
    }
}