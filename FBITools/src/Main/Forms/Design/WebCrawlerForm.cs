using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using App.Core.Desktop;

namespace FBITools
{
    public partial class WebCrawlerForm : ContentBaseForm
    {
        #region InitializeForm
        private readonly WebCrawlerController _controller;

        public WebCrawlerForm()
        {
            InitializeComponent();

            Session.WebCrawlerPage = this;

            Load += OnFormLoad;
            Shown += OnFormShown;
            GotFocus += OnFormGotFocus;

            _controller = new WebCrawlerController();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            SitesComboBox.ValueMember = "Value";
            SitesComboBox.DisplayMember = "Text";
            SitesComboBox.DataSource = _controller.GetSites();

            UrlComboBox.ValueMember = "Value";
            UrlComboBox.DisplayMember = "Value";
        }

        private void OnFormShown(object sender, EventArgs ev)
        {
            RegisterShownEvents();
            BindStatusBar();
        }

        private void RegisterShownEvents()
        {
            UrlComboBox.SelectedIndexChanged += OnUrlComboBoxSelectedIndexChanged;

            SitesComboBox.SelectedIndexChanged += OnSitesComboBoxSelectedIndexChanged;
            SitesComboBox.SelectedIndex = 1;

            CrawlerButton.Click += OnCrawlerButtonClick;
            WgetButton.Click += OnWgetButtonClick;

            ResultGrid.AutoGenerateColumns = true;
            ResultGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ResultGrid.DataBindingComplete += OnResultGridDataBindingComplete;
            ResultGrid.CellFormatting += OnResultGridCellFormatting;
        }

        private void OnFormGotFocus(object sender, EventArgs e)
        {
            UrlComboBox.Focus();
        }

        private void BindStatusBar()
        {
            ResultGrid.Statusbar = ResultStatusBar;
        }
        #endregion

        #region UserEvents
        private static void Execute(string exeCmd)
        {
            Process.Start("wt", "--size 60,20 -w _q cmd /K " + exeCmd);
        }

        private void OnSitesComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.ChangeSite(sender);

            FolderTextBox.Text = _controller.LocalPath;

            UrlComboBox.DataSource = _controller.GetUrls().ToList();
            UrlComboBox.SelectedIndex = 0;
        }

        private void OnUrlComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.ChangeLocalPath(sender);
            FolderTextBox.Text = _controller.LocalPath;
        }

        private void OnCrawlerButtonClick(object sender, EventArgs e)
        {
            WarningLabel.Text = @"Executando...";

            var roms = _controller.GetItems((KeyValuePair<string, string>)UrlComboBox.SelectedItem);

            ResultGrid.DataSource = roms;
            var sortColumn = ResultGrid.Columns["Found"];

            if (sortColumn != null)
            {
                ResultGrid.Sort(sortColumn, ListSortDirection.Ascending);
            }

            WarningLabel.Text = _controller.GetItemsReport();

            UrlComboBox.Focus();
        }

        private void OnWgetButtonClick(object sender, EventArgs e)
        {
            var command = "cd /d D:\\Fazendo\\wget-1.21.4-win64\\ && .\\wget.exe ";

            if (Network.UseProxy)
            {
                command = "cd /d C:\\WGET && .\\wget.exe ";
            }

            if (string.IsNullOrWhiteSpace(WgetNamesTextBox.Text) == false)
            {
                var regexWords = Uri.EscapeDataString(WgetNamesTextBox.Text).Replace("%7C", "|");
                command += "--regex-type=pcre --accept-regex=\"(?i)(" + regexWords + ")\" ";
            }

            // Form.UrlComboBox.SelectedValue.ToString()
            command += "-m -np -c -e robots=off -R \"index.html*\" \"" + WebCrawlerController.TempUrl + "\"";

            Execute(command);
        }

        private void OnResultGridDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn col in ResultGrid.Columns)
            {
                if (col.ValueType == typeof(DateTime))
                {
                    col.DefaultCellStyle.Format = "dd-MMM-yyyy HH:mm";
                }
            }
        }

        private void OnResultGridCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (ResultGrid.Columns[e.ColumnIndex].Name != "FileSize" || !(e.Value is long))
            {
                return;
            }

            e.Value = Archive.FormatSize((long)e.Value);
            e.FormattingApplied = true;
        }

        private void OnResultGridSortCompare(object sender, DataGridViewSortCompareEventArgs e)
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
        #endregion
    }
}