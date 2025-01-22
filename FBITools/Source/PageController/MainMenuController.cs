using System;

namespace FBITools
{
    public partial class MainMenuController
    {
        public MainMenuController(MainMenuForm page)
        {
            Page = page;
            Page.Shown += Page_Shown;
            Page.KeyPreview = true;
        }

        private void Page_Shown(object sender, EventArgs ev)
        {
            FileCopyTabButton.Click += (s, e) => Session.MainContentController.SetContent(s, Session.FileCopyPage);
            ImageResizeTabButton.Click += (s, e) => Session.MainContentController.SetContent(s, Session.ImageResizePage);
            VbCsharpTabButton.Click += (s, e) => Session.MainContentController.SetContent(s, Session.VbToCsharpPage);
            WiiUcetkTabButton.Click += (s, e) => Session.MainContentController.SetContent(s, Session.WiiUCetkPage);

            ConfigTabButton.Click += (s, e) => Session.MainContentController.SetContent(s, Session.ConfigPage);

            FileCopyTabButton.PerformClick();
        }
    }
}