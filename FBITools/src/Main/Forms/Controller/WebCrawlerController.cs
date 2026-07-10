using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public class WebCrawlerController
    {
        public const string TempUrl = "https://lolroms.com/Atari/2600";
        private const bool CountAftermarketPrivate = true;

        private static WebCrawlerSite _currentSite;

        public string LocalPath { get; private set; }

        public List<DropItem> GetSites()
        {
            return Util.EnumToDropItems<WebSite>();
        }

        public void ChangeSite(object sender)
        {
            switch ((WebSite)((ComboBox)sender).SelectedValue)
            {
                case WebSite.LoLRoms: _currentSite = new LolRomsSite(); break;
                case WebSite.MyRient: _currentSite = new MyRientSite(); break;
            }
        }

        public void ChangeLocalPath(object sender)
        {
            var combo = (ComboBox)sender;
            if (combo.SelectedItem == null) { return; }

            var folder = ((KeyValuePair<string, string>)combo.SelectedItem).Value;
            LocalPath = _currentSite.LocalPath + folder;
        }

        public Dictionary<string, string> GetUrls()
        {
            return _currentSite == null ? null : _currentSite.GetUrls();
        }

        public DataList<Rom> GetItems(KeyValuePair<string, string> path)
        {
            _currentSite.SetHtml(path.Key);
            _currentSite.Items = new DataList<Rom>();

            try
            {
                foreach (var rom in _currentSite.HtmlItems)
                {
                    var name = _currentSite.GetItemName(rom);
                    var size = _currentSite.GetItemSize(rom);
                    var date = _currentSite.GetItemDate(rom);

                    var currentRom = new Rom
                    {
                        Found = Archive.Exists(LocalPath, name),
                        FileName = name,
                        FileSize = Archive.CalculateSize(size),
                        Date = Cast.ToDateTime(date)
                    };

                    if (CountAftermarketPrivate)
                    {
                        currentRom.Found = Archive.Exists(LocalPath, name) ||
                            Archive.Exists(LocalPath + " (Aftermarket)", name) ||
                            Archive.Exists(LocalPath + " (Private)", name);
                    }

                    _currentSite.Items.Add(currentRom);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }

            return _currentSite.Items;
        }

        public string GetItemsReport()
        {
            var roms = _currentSite.Items;
            var totalFound = roms.Count(x => x.Found);

            var folderTotalFiles = Archive.GetFiles(LocalPath).Count();

            if (CountAftermarketPrivate)
            {
                folderTotalFiles += Archive.GetFiles(LocalPath + " (Aftermarket)").Count();
                folderTotalFiles += Archive.GetFiles(LocalPath + " (Private)").Count();
            }

            var totalSize = roms.Sum(x => x.FileSize);
            var currentSize = roms.Where(x => x.Found).Sum(x => x.FileSize);
            var totalSizeConverted = Archive.FormatSize(totalSize);
            var currentSizeConverted = Archive.FormatSize(currentSize);

            var text = @"Folder: " + folderTotalFiles + @" - Good: " + totalFound + @" - Bad: " + (roms.Count - totalFound) + @" - TotalSize: " + currentSizeConverted + @" / " + totalSizeConverted;
            return text;
        }
    }
}