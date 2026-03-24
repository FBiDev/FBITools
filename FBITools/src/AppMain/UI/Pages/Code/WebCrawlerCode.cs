using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core;
using App.Core.Desktop;
using System.Diagnostics;
using System.Text;
using System.Globalization;

namespace FBITools
{
    public class MyrientRom
    {
        public MyrientRom()
        {
        }

        [Display(IsBool = IsBool.Yes, AutoGenerateField = true)]
        public bool Found { get; set; }

        [Style(AutoSizeMode = ColumnAutoSizeMode.Fill)]
        public string FileName { get; set; }

        [Style(Align = ColumnAlign.Right, AutoSizeMode = ColumnAutoSizeMode.AllCells)]
        public long FileSize { get; set; }

        [Style(AutoSizeMode = ColumnAutoSizeMode.AllCells)]
        public DateTime Date { get; set; }
    }

    public class WebCrawlerCode : PageCode
    {
        public WebCrawlerCode()
        {
            Session.WebCrawlerPage = this;

            base.UI = UI = new WebCrawlerUI();
            UI.Shown += OnFormShown;
            UI.GotFocus += OnFormGotFocus;

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

            UI.FolderTextBox.Text = @"C:\WGET\myrient.erista.me\files\No-Intro\";

            UI.URLComboBox.DataSource = new BindingSource(WebCrawlerInfo.GetMyrientFolders(), null);
            UI.URLComboBox.DisplayMember = "Value";
            UI.URLComboBox.ValueMember = "Key";
        }

        private void RegisterShownEvents()
        {
            UI.CrawButton.Click += CrawButton_Click;
            UI.WgetURLButton.Click += WgetURLButton_Click;

            UI.ResultGrid.AutoGenerateColumns = true;
            UI.ResultGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UI.ResultGrid.DataBindingComplete += ResultGrid_DataBindingComplete;
            UI.ResultGrid.CellFormatting += ResultGrid_CellFormatting;

            // UI.ResultGrid.SortCompare += ResultGrid_SortCompare;
            // UI.ResultGrid.AddBooleanColumn("FoundX");
            // UI.ResultGrid.SetBooleanColumns(new List<string>() { "FoundX" });
            // UI.ResultGrid.Columns["FileSize"].ValueType = typeof(int);
            // UI.ResultGrid.Columns["Date"].ValueType = typeof(DateTime);
            // UI.ResultGrid.Columns["Date"].DefaultCellStyle.Format = "dd-MMM-yyyy HH:mm";
        }

        private void BindStatusBar()
        {
            UI.ResultGrid.Statusbar = UI.ResultStatusBar;
        }

        private void OnFormGotFocus(object sender, EventArgs e)
        {
            UI.URLComboBox.Focus();
        }

        private async void CrawButton_Click(object sender, EventArgs e)
        {
            UI.WarningLabel.Text = "Executando...";
            //
            var temp = "https://myrient.erista.me/files/No-Intro/";
            var html = await WebCrawlerInfo.GetURLHtml(UI.URLComboBox.SelectedValue.ToString());

            var htmlTable = html.GetBetween("<table id=\"list\">", "</table>", true);
            var romList = htmlTable.GetBetweenList("<tr><td class=\"link\"><a href=\"", "</td></tr>", true);

            if (romList.Count > 0)
            {
                romList.RemoveRange(0, 3);
            }

            var myrientRomList = new DataList<MyrientRom>();

            var folderTitle = UI.URLComboBox.SelectedText.Replace("NoIntro - ", "");
            var currentFolder = Path.Combine(UI.FolderTextBox.Text, folderTitle);

            foreach (var rom in romList)
            {
                var name = rom.GetBetween("title=\"", "\"");
                name = name.HtmlDecode();

                var date = rom.GetBetween("<td class=\"date\">", "</td></tr>");
                var size = rom.GetBetween("<td class=\"size\">", "</td>");

                var currentRom = new MyrientRom
                {
                    Found = WebCrawlerInfo.CheckFile(currentFolder, name),
                    FileName = name,
                    FileSize = WebCrawlerInfo.ConvertSize(size),
                    Date = WebCrawlerInfo.ConvertDate(date)
                };

                myrientRomList.Add(currentRom);

                // UI.ResultGrid.Rows.Add(currentRom.Found, currentRom.FileName, currentRom.FileSize, currentRom.Date);
            }

            UI.ResultGrid.DataSource = myrientRomList;
            UI.ResultGrid.Sort(UI.ResultGrid.Columns["Found"], ListSortDirection.Ascending);

            var totalFound = myrientRomList.Where(x => x.Found).Count();

            var folderTotalFiles = 0;
            if (Directory.Exists(currentFolder))
            {
                folderTotalFiles = Directory.EnumerateFiles(currentFolder, "*", SearchOption.AllDirectories).Count();
            }

            UI.WarningLabel.Text = "Folder: " + folderTotalFiles + " - Found: " + totalFound + " - Not: " + (myrientRomList.Count - totalFound);
        }

        private void WgetURLButton_Click(object sender, EventArgs e)
        {
            var command = "cd C:\\WGET && .\\wget.exe ";

            if (string.IsNullOrWhiteSpace(UI.WgetNamesTextBox.Text) == false)
            {
                var regexWords = Uri.EscapeDataString(UI.WgetNamesTextBox.Text).Replace("%7C", "|");
                command += "--accept-regex=\"(" + regexWords + ")\" ";
            }

            command += "-m -np -c -e robots=off -R \"index.html*\" \"" + UI.URLComboBox.SelectedValue.ToString() + "\"";

            Execute(command);

        }

        public static void Execute(string exeCmd)
        {
            Process.Start("wt", "--size 60,20 -w _q cmd /K " + exeCmd);
        }

        private void ResultGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn col in UI.ResultGrid.Columns)
            {
                if (col.ValueType == typeof(DateTime))
                {
                    col.DefaultCellStyle.Format = "dd-MMM-yyyy HH:mm";
                }
            }
        }

        private void ResultGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (UI.ResultGrid.Columns[e.ColumnIndex].Name == "FileSize"
                && e.Value != null && e.Value is long)
            {
                long valor = (long)e.Value;

                if (valor >= 1024 * 1024 * 1024)
                {
                    double mb = valor / (1024.0 * 1024.0 * 1024.0);
                    e.Value = mb.ToString("0.0") + " GB";
                }
                else if (valor >= 1024 * 1024)
                {
                    double mb = valor / (1024.0 * 1024.0);
                    e.Value = mb.ToString("0.0") + " MB";
                }
                else if (valor >= 1024.0)
                {
                    double kb = valor / 1024.0;
                    e.Value = kb.ToString("0.0") + " KB";
                }
                else
                {
                    e.Value = valor.ToString("0.0") + " B";
                }

                e.FormattingApplied = true;
            }
        }

        private void ResultGrid_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            string valor1 = e.CellValue1 != null ? e.CellValue1.ToString() : string.Empty;
            string valor2 = e.CellValue2 != null ? e.CellValue2.ToString() : string.Empty;

            bool v1Especial = valor1.Length == 0 || !char.IsLetterOrDigit(valor1[0]);
            bool v2Especial = valor2.Length == 0 || !char.IsLetterOrDigit(valor2[0]);

            if (v1Especial && !v2Especial)
            {
                e.SortResult = 1;
            }
            else if (!v1Especial && v2Especial)
            {
                e.SortResult = -1;
            }
            else
            {
                e.SortResult = string.Compare(valor1, valor2, true);
            }

            e.Handled = true;
        }
    }
}