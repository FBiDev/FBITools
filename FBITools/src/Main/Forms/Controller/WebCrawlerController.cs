using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public class WebCrawlerController
    {
        public const string WgetUrl = "https://lolroms.com/Atari/2600";
        private static WebCrawlerSite _currentSite;

        public string LocalPath { get; private set; }

        public List<DropItem> GetSites()
        {
            return Enums.ToDropItemsNumbered<WebSite>();
        }

        public void ChangeSite(object sender)
        {
            switch ((WebSite)((ComboBox)sender).SelectedValue)
            {
                case WebSite.LoLRoms: _currentSite = new LolRomsSite();
                    break;
                case WebSite.MyRient: _currentSite = new MyRientSite();
                    break;
                default: _currentSite = null;
                    break;
            }
        }

        public void ChangeLocalPath(object sender)
        {
            var combo = (ComboBox)sender;

            if (combo.SelectedItem == null)
            {
                return;
            }

            var folder = ((KeyValuePair<string, string>)combo.SelectedItem).Value;
            LocalPath = _currentSite.LocalPath + folder;
        }

        public Dictionary<string, string> GetUrls()
        {
            return _currentSite == null ? null : _currentSite.GetUrls();
        }

        public async Task<DataList<Rom>> GetItems(KeyValuePair<string, string> path)
        {
            await Task.Run(async () =>
            {
                await _currentSite.SetHtml(path.Key);

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
                            //Found = Archive.Exists(LocalPath, name),
                            FileName = name,
                            FileSize = Archive.CalculateSize(size),
                            Date = Cast.ToDateTime(date)
                        };

                        currentRom.Found = _currentSite.FindFile(LocalPath, name);

                        _currentSite.Items.Add(currentRom);
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                    throw;
                }
            });

            return _currentSite.Items;
        }

        public string GetItemsReport()
        {
            if (_currentSite.Items == null)
            {
                _currentSite.Items = new DataList<Rom>();
            }

            IEnumerable<string> folderFiles;

            var pathname = LocalPath.Split('\\').Last();

            switch (pathname)
            {
                case "Atari - Atari 7800":
                    folderFiles = GetFolderFiles(LocalPath,
                        new[] { " (A78)", " (BIN)" });
                    break;
                case "Atari - Atari Jaguar":
                    folderFiles = GetFolderFiles(LocalPath,
                        new[] { " (ABS)", " (COF)", " (J64)", " (JAG)", " (ROM)" });
                    break;
                case "Atari - Atari Lynx":
                    folderFiles = GetFolderFiles(LocalPath,
                        new[] { " (BLL)", " (LNX)", " (LYX)" });
                    break;
                case "Toshiba - Pasopia":
                    folderFiles = GetFolderFiles(LocalPath,
                        new[] { " (BIN)", " (WAV)" });
                    break;
                default:
                    folderFiles = GetFolderFiles(LocalPath);
                    break;
            }

            var roms = _currentSite.Items;
            var totalFound = roms.Count(x => x.Found);

            var totalSize = roms.Sum(x => x.FileSize);
            var totalSizeConverted = Archive.FormatSize(totalSize);

            var currentSize = roms.Where(x => x.Found).Sum(x => x.FileSize);
            var currentSizeConverted = Archive.FormatSize(currentSize);

            var folderTotalFiles = folderFiles.DistinctFileNames().Count();

            var notFound = roms.Count - totalFound;
            var notFoundStr = string.Empty;
            if (notFound > 0)
            {
                notFoundStr = "B(-" + notFound + ") ";
            }

            var extraFile = folderTotalFiles - totalFound;
            var extraFileStr = string.Empty;
            if (extraFile > 0)
            {
                extraFileStr = "X(+" + extraFile + ") ";
            }

            var text = extraFileStr + notFoundStr + @"Folder: " + folderTotalFiles + @" - Found: " + totalFound + @" - TotalSize: " + currentSizeConverted + @" / " + totalSizeConverted;
            return text;
        }

        private IEnumerable<string> GetFolderFiles(string basePath, IEnumerable<string> extraPath = null)
        {
            extraPath = extraPath ?? new List<string> { string.Empty };

            var files = Archive.GetFiles(basePath);

            foreach (var path in extraPath)
            {
                if (path.IsNotEmpty())
                {
                    files = files.Concat(Archive.GetFiles(basePath + path));
                }

                if (!_currentSite.CountAftermarketPrivate)
                {
                    continue;
                }

                var afterm = basePath + path + " (Aftermarket)";
                var privat = basePath + path + " (Private)";

                files = files.Concat(Archive.GetFiles(afterm));
                files = files.Concat(Archive.GetFiles(privat));
            }

            return files;
        }
    }
}