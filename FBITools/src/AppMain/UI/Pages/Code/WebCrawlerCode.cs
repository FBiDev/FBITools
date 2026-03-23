using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core;
using App.Core.Desktop;

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

            UI.FolderTextBox.Text = @"C:\Users\fbirnfeld\Downloads\temp";

            UI.URLComboBox.DataSource = new BindingSource(WebCrawlerInfo.GetMyrientFolders(), null);
            UI.URLComboBox.DisplayMember = "Value";
            UI.URLComboBox.ValueMember = "Key";
        }

        private void RegisterShownEvents()
        {
            UI.CrawButton.Click += CrawButton_Click;

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
            var html = await GetURLHtml(UI.URLComboBox.SelectedValue.ToString());
            
            var htmlTable = html.GetBetween("<table id=\"list\">", "</table>", true);
            var romList = htmlTable.GetBetweenList("<tr><td class=\"link\"><a href=\"", "</td></tr>", true);

            if (romList.Count > 0)
            {
                romList.RemoveRange(0, 3);
            }

            var myrientRomList = new DataList<MyrientRom>();

            foreach (var rom in romList)
            {
                var name = rom.GetBetween("title=\"", "\"");
                name = name.HtmlDecode();

                var date = rom.GetBetween("<td class=\"date\">", "</td></tr>");
                var size = rom.GetBetween("<td class=\"size\">", "</td>");

                var currentRom = new MyrientRom
                {
                    Found = CheckFile(name),
                    FileName = name,
                    FileSize = ConvertSize(size),
                    Date = ConvertDate(date)
                };

                myrientRomList.Add(currentRom);

                // UI.ResultGrid.Rows.Add(currentRom.Found, currentRom.FileName, currentRom.FileSize, currentRom.Date);
            }

            UI.ResultGrid.DataSource = myrientRomList;
            UI.ResultGrid.Sort(UI.ResultGrid.Columns["Found"], ListSortDirection.Ascending);

            var totalFound = myrientRomList.Where(x => x.Found).Count();

            UI.WarningLabel.Text = "Finalizado - Found: " + totalFound + " Not Found: " + (myrientRomList.Count - totalFound);
        }

        private async Task<string> GetURLHtml(string url)
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

        private long ConvertSize(string size)
        {
            if (size.Contains("GiB"))
            {
                var newSize = size.Replace(" GiB", string.Empty);
                var newSizeDouble = Cast.ToDouble(newSize);
                var newSizeInt = newSizeDouble * 1024 * 1024 * 1024;
                return Convert.ToInt64(newSizeInt);
            }
            if (size.Contains("MiB"))
            {
                var newSize = size.Replace(" MiB", string.Empty);
                var newSizeDouble = Cast.ToDouble(newSize);
                var newSizeInt = newSizeDouble * 1024 * 1024;
                return Convert.ToInt32(newSizeInt);
            }
            else if (size.Contains("KiB"))
            {
                var newSize = size.Replace(" KiB", string.Empty);
                var newSizeDouble = Cast.ToDouble(newSize);
                var newSizeInt = newSizeDouble * 1024;
                return Convert.ToInt32(newSizeInt);
            }
            else if (size.Contains("B"))
            {
                var newSize = size.Replace(" B", string.Empty);
                return Convert.ToInt32(newSize);
            }
            else
            {
                return 0;
            }
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

        // ToDo
        // .\wget.exe -m -np -c -e robots=off -R "index.html*" "https://myrient.erista.me/files/Lost%20Level/Archive/003%20-%20Lost%20Level%20Archive%20-%20Nintendo%20-%20Super%20Famicom%20-%20SNES%20-%20MSU-1/"
        // .\wget.exe --accept-regex "/(Aftermarket|Unlicensed|Unl|prototype|Proto|Net Yaroze)[^/]*$" -m -np -c -e robots=off -R "index.html*" "https://myrient.erista.me/files/Lost%20Level/Archive/012%20-%20Lost%20Level%20Archive%20-%20Sony%20-%20PlayStation/"
        //                            "/[T-Z][^/]*$"
        // --accept-regex "/Perfect%20Diamond[^/]*$"
    }
}