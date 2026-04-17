using System;
using App.Core.Desktop;

namespace FBITools
{
    public partial class MainMenuForm : ContentBaseForm
    {
        public MainMenuForm()
        {
            InitializeComponent();

            Session.MainMenuPage = this;

            Shown += Page_Shown;
            KeyPreview = true;
        }

        private void Page_Shown(object sender, EventArgs ev)
        {
            FileCopyTabButton.Click += (s, e) => Session.MainContentPage.SetContent(s, Session.FileCopyPage);
            ImageResizeTabButton.Click += (s, e) => Session.MainContentPage.SetContent(s, Session.ImageResizePage);
            VbCsharpTabButton.Click += (s, e) => Session.MainContentPage.SetContent(s, Session.VbToCsharpPage);
            WiiUTabButton.Click += (s, e) => Session.MainContentPage.SetContent(s, Session.WiiUPage);
            WebCrawlerButton.Click += (s, e) => Session.MainContentPage.SetContent(s, Session.WebCrawlerPage);

            ConfigTabButton.Click += (s, e) => Session.MainContentPage.SetContent(s, Session.ConfigPage);

            FileCopyTabButton.PerformClick();
        }
    }
}