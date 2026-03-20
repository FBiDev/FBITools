using System;
using System.Threading.Tasks;
using App.Core;
using App.Core.Desktop;
using System.Net;
using System.IO;
using System.ComponentModel;

namespace FBITools
{
    public class MyrientRom
    {
        public MyrientRom() { }
        [Display(IsBool = IsBool.Yes, AutoGenerateField = true)]
        public bool Found { get; set; }
        public string FileName { get; set; }
        public string FileSize { get; set; }
        public DateTime Date { get; set; }
    }

    public class WebCrawlerCode : PageCode
    {
        public WebClientExtend Client { get; set; }

        public WebCrawlerCode()
        {
            Session.WebCrawlerPage = this;

            base.UI = UI = new WebCrawlerUI();
            UI.Shown += OnFormShown;
            UI.GotFocus += OnFormGotFocus;

            UI.UrlTextBox.Text = "https://myrient.erista.me/files/No-Intro/Atari%20-%20Atari%20Jaguar%20%28J64%29/";
            UI.FolderTextBox.Text = @"C:\Users\fbirnfeld\Downloads\temp";

            UI.ResultGrid.AutoGenerateColumns = false;

            Browser.UseProxy = Environment.MachineName.Equals("cohab-ct0157", StringComparison.InvariantCultureIgnoreCase);
            Browser.DefaultProxy = new WebProxy
            {
                Address = new Uri("http://cohab-proxy.cohabct.com.br:3128"),
                BypassProxyOnLocal = true,
                BypassList = new string[] { },
                Credentials = new NetworkCredential("fbirnfeld", "zumbie")
            };
        }

        public new WebCrawlerUI UI { get; set; }

        private void OnFormShown(object sender, EventArgs ev)
        {
            RegisterShownEvents();
            BindStatusBar();
        }

        private void RegisterShownEvents()
        {
            UI.CrawButton.Click += CrawButton_Click;
        }

        private void BindStatusBar()
        {
            UI.ResultGrid.Statusbar = UI.ResultStatusBar;
        }

        private void OnFormGotFocus(object sender, EventArgs e)
        {
            UI.UrlTextBox.Focus();
        }

        private async void CrawButton_Click(object sender, EventArgs e)
        {
            UI.WarningLabel.Text = "Executando...";

            var html = await getURLHtml(UI.UrlTextBox.Text);

            var htmlTable = html.GetBetween("<table id=\"list\">", "</table>", true);
            var romList = htmlTable.GetBetweenList("<tr><td class=\"link\"><a href=\"", "</td></tr>", true);
            romList.RemoveRange(0, 3);

            var MyrientRomList = new DataList<MyrientRom>();

            foreach (var rom in romList)
            {
                var name = rom.GetBetween("title=\"", "\"");

                var date = rom.GetBetween("<td class=\"date\">", "</td></tr>");
                var size = rom.GetBetween("<td class=\"size\">", "</td>");

                var currentRom = new MyrientRom
                {
                    Found = CheckFile(name),
                    FileName = name,
                    FileSize = size,
                    Date = ConvertDate(date)
                };

                MyrientRomList.Add(currentRom);
            }

            UI.ResultGrid.DataSource = MyrientRomList;

            UI.WarningLabel.Text = "Finalizado";
        }

        private async Task<string> getURLHtml(string url)
        {
            return await Browser.DownloadString(url);
        }

        private bool CheckFile(string fileName)
        {
            return File.Exists(Path.Combine(UI.FolderTextBox.Text, fileName));
        }

        private DateTime ConvertDate(string date)
        {
            var newDate = Cast.ToDateTime(date);
            return newDate;
        }

        private int ConvertSize(string size)
        {
            return 0;
        }
    }
}