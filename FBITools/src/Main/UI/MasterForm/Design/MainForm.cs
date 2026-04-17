using System;
using App.Core.Desktop;

namespace FBITools
{
    public partial class MainForm : MainBaseForm
    {
        public MainForm()
        {
            InitializeComponent();

            Session.MainPage = this;

            Session.SetDefaultPageIcon();
            ////Session.MainPage.StatusBarEnable = true;

            Shown += Page_Shown;

            var mainContentPage = new MainContentForm();
            SetMainContentPage(mainContentPage);
        }

        private async void Page_Shown(object sender, EventArgs e)
        {
            Theme.SetTheme();
            await CenterWindow();
        }
    }
}