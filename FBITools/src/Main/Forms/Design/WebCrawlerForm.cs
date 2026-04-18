using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public partial class WebCrawlerForm : ContentBaseForm
    {
        public WebCrawlerForm()
        {
            InitializeComponent();

            Session.WebCrawlerPage = this;

            Shown += OnFormShown;
            GotFocus += OnFormGotFocus;

            Browser.UseProxy = Environment.MachineName.Equals("cohab-ct0157", StringComparison.InvariantCultureIgnoreCase);
            Browser.DefaultProxy = new WebProxy
            {
                Address = new Uri("http://cohab-proxy.cohabct.com.br:3128"),
                BypassProxyOnLocal = true,
                BypassList = new string[] { },
                Credentials = new NetworkCredential("fbirnfeld", "zumbie")
            };
        }

        private static void Execute(string exeCmd)
        {
            Process.Start("wt", "--size 60,20 -w _q cmd /K " + exeCmd);
        }

        private void OnFormShown(object sender, EventArgs ev)
        {
            RegisterShownEvents();
            BindStatusBar();

            FolderTextBox.Text = @"D:\Fazendo\wget-1.21.4-win64\myrient.erista.me\files\No-Intro\";

            if (Browser.UseProxy)
            {
                FolderTextBox.Text = @"C:\WGET\myrient.erista.me\files\No-Intro\";
            }

            URLComboBox.DataSource = new BindingSource(WebCrawlerController.GetMyrientFolders(), null);
            URLComboBox.DisplayMember = "Value";
            URLComboBox.ValueMember = "Key";
        }

        private void RegisterShownEvents()
        {
            CrawButton.Click += CrawButton_Click;
            WgetURLButton.Click += WgetURLButton_Click;

            ResultGrid.AutoGenerateColumns = true;
            ResultGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ResultGrid.DataBindingComplete += ResultGrid_DataBindingComplete;
            ResultGrid.CellFormatting += ResultGrid_CellFormatting;

            // ResultGrid.SortCompare += ResultGrid_SortCompare;
            // ResultGrid.AddBooleanColumn("FoundX");
            // ResultGrid.SetBooleanColumns(new List<string>() { "FoundX" });
            // ResultGrid.Columns["FileSize"].ValueType = typeof(int);
            // ResultGrid.Columns["Date"].ValueType = typeof(DateTime);
            // ResultGrid.Columns["Date"].DefaultCellStyle.Format = "dd-MMM-yyyy HH:mm";
        }

        private void BindStatusBar()
        {
            ResultGrid.Statusbar = ResultStatusBar;
        }

        private void OnFormGotFocus(object sender, EventArgs e)
        {
            URLComboBox.Focus();
        }

        private async void CrawButton_Click(object sender, EventArgs e)
        {
            WarningLabel.Text = "Executando...";

            // URLComboBox.SelectedValue.ToString()
            var temp = "https://myrient.erista.me/files/No-Intro/";
            temp = "https://myrient.erista.me/dats/Lost%20Level/Archive/";
            var html = await WebCrawlerController.GetURLHtml(temp);

            var htmlTable = html.GetBetween("<table id=\"list\">", "</table>", true);
            var romList = htmlTable.GetBetweenList("<tr><td class=\"link\"><a href=\"", "</td></tr>", true);

            if (romList.Count > 0)
            {
                romList.RemoveRange(0, 3);
            }

            var myrientRomList = new DataList<MyrientRom>();

            var folderTitle = URLComboBox.SelectedText.Replace("NoIntro - ", string.Empty);
            var currentFolder = Path.Combine(FolderTextBox.Text, folderTitle);

            foreach (var rom in romList)
            {
                var name = rom.GetBetween("title=\"", "\"");
                name = name.HtmlDecode();

                var date = rom.GetBetween("<td class=\"date\">", "</td></tr>");
                var size = rom.GetBetween("<td class=\"size\">", "</td>");

                var currentRom = new MyrientRom
                {
                    Found = WebCrawlerController.CheckFile(currentFolder, name),
                    FileName = name,
                    FileSize = WebCrawlerController.ConvertSize(size),
                    Date = WebCrawlerController.ConvertDate(date)
                };

                myrientRomList.Add(currentRom);

                // Form.ResultGrid.Rows.Add(currentRom.Found, currentRom.FileName, currentRom.FileSize, currentRom.Date);
            }

            ResultGrid.DataSource = myrientRomList;
            ResultGrid.Sort(ResultGrid.Columns["Found"], ListSortDirection.Ascending);

            var totalFound = myrientRomList.Count(x => x.Found);

            var folderTotalFiles = 0;
            if (Directory.Exists(currentFolder))
            {
                folderTotalFiles = Directory.EnumerateFiles(currentFolder, "*", SearchOption.AllDirectories).Count();
            }

            var totalSize = myrientRomList.Sum(x => x.FileSize);
            var currentSize = myrientRomList.Where(x => x.Found).Sum(x => x.FileSize);
            var totalSizeConverted = Archive.CalculateSize(totalSize);
            var currentSizeConverted = Archive.CalculateSize(currentSize);

            WarningLabel.Text = "Folder: " + folderTotalFiles + " - Good: " + totalFound + " - Bad: " + (myrientRomList.Count - totalFound) + " - TotalSize: " + currentSizeConverted + " / " + totalSizeConverted;

            URLComboBox.Focus();
        }

        private void WgetURLButton_Click(object sender, EventArgs e)
        {
            var command = "cd /d D:\\Fazendo\\wget-1.21.4-win64\\ && .\\wget.exe ";
            if (Browser.UseProxy)
            {
                command = "cd /d C:\\WGET && .\\wget.exe ";
            }

            if (string.IsNullOrWhiteSpace(WgetNamesTextBox.Text) == false)
            {
                var regexWords = Uri.EscapeDataString(WgetNamesTextBox.Text).Replace("%7C", "|");
                command += "--regex-type=pcre --accept-regex=\"(?i)(" + regexWords + ")\" ";
            }

            // Form.URLComboBox.SelectedValue.ToString()
            command += "-m -np -c -e robots=off -R \"index.html*\" \"" + WebCrawlerController.TempUrl + "\"";

            Execute(command);
        }

        private void ResultGrid_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn col in ResultGrid.Columns)
            {
                if (col.ValueType == typeof(DateTime))
                {
                    col.DefaultCellStyle.Format = "dd-MMM-yyyy HH:mm";
                }
            }
        }

        private void ResultGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (ResultGrid.Columns[e.ColumnIndex].Name != "FileSize" || !(e.Value is long))
            {
                return;
            }

            var valor = (long)e.Value;

            if (valor >= (long)1024 * 1024 * 1024 * 1024)
            {
                var mb = valor / (1024.0 * 1024.0 * 1024.0 * 1024.0);
                e.Value = mb.ToString("0.0") + " TB";
            }
            else if (valor >= 1024 * 1024 * 1024)
            {
                var mb = valor / (1024.0 * 1024.0 * 1024.0);
                e.Value = mb.ToString("0.0") + " GB";
            }
            else if (valor >= 1024 * 1024)
            {
                var mb = valor / (1024.0 * 1024.0);
                e.Value = mb.ToString("0.0") + " MB";
            }
            else if (valor >= 1024.0)
            {
                var kb = valor / 1024.0;
                e.Value = kb.ToString("0.0") + " KB";
            }
            else
            {
                e.Value = valor.ToString("0.0") + " B";
            }

            e.FormattingApplied = true;
        }

        private void ResultGrid_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            var valor1 = e.CellValue1 != null ? e.CellValue1.ToString() : string.Empty;
            var valor2 = e.CellValue2 != null ? e.CellValue2.ToString() : string.Empty;

            var v1Especial = valor1.Length == 0 || !char.IsLetterOrDigit(valor1[0]);
            var v2Especial = valor2.Length == 0 || !char.IsLetterOrDigit(valor2[0]);

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
                e.SortResult = string.Compare(valor1, valor2, StringComparison.OrdinalIgnoreCase);
            }

            e.Handled = true;
        }
    }
}