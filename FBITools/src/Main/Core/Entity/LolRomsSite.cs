using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public sealed class LolRomsSite : WebCrawlerSite
    {
        private List<string> _files;

        public LolRomsSite()
        {
            LocalPath = Network.UseProxy ? @"C:\WGET\myrient.erista.me\files\No-Intro\" :
                            @"D:\Fazendo\wget-1.21.4-win64\myrient.erista.me\files\No-Intro\";

            CountAftermarketPrivate = true;
        }

        public override string LocalPath { get; protected set; }

        public override string HtmlTable { get; protected set; }

        public override List<string> HtmlItems { get; protected set; }

        public override string SufixItemName
        {
            get { return ".zip"; }
        }

        public override DataList<Rom> Items { get; set; }

        protected override string Host
        {
            get
            {
                return string.Empty;

                // return "https://lolroms.com/";
            }
        }

        public override string GetItemName(string html)
        {
            return html.GetBetween(".7z'>", "</a>").Trim().HtmlDecode() + SufixItemName;
        }

        public override string GetItemSize(string html)
        {
            var htmlName = html.GetBetween("<div class='meta'>", "</div>", true);
            return htmlName.GetBetween("<span>", "</span>");
        }

        public override string GetItemDate(string html)
        {
            var htmlDate = html.GetBetween("<div class='meta'>", "</div>", true);
            htmlDate = htmlDate.GetBetween("</span>", "</div>");
            return htmlDate.GetBetween("<span>", "</span>");
        }

        public override void RemoveItems()
        {
        }

        public override Dictionary<string, string> GetUrls()
        {
            var folders = SetUrls("data/LolRomsFolders.txt");

            return folders.ToDictionary(item => item.Key + ".html", item => item.Value);
        }

        public override Task SetHtml(string path)
        {
            Html = Archive.ReadAll("data/lol/" + path);
            HtmlTable = Html.GetBetween("</ul>", "<script>", true);
            HtmlItems = HtmlTable.GetBetweenList("<li class='info'>", "</li>");

            _files = new List<string>();
            return Task.CompletedTask;
        }

        public override bool FindFile(string path, string name)
        {
            if (_files.Count != 0)
            {
                return FindFileName(name);
            }

            var pathname = path.Split('\\').Last();

            switch (pathname)
            {
                case "Atari - Atari 7800":
                    FindFileExtra(path,
                        new[] { " (A78)", " (BIN)" });
                    break;
                case "Atari - Atari Jaguar":
                    FindFileExtra(path,
                        new[] { " (ABS)", " (COF)", " (J64)", " (JAG)", " (ROM)" });
                    break;
                case "Atari - Atari Lynx":
                    FindFileExtra(path,
                        new[] { " (BLL)", " (LNX)", " (LYX)" });
                    break;
                case "Toshiba - Pasopia":
                    FindFileExtra(path,
                        new[] { " (BIN)", " (WAV)" });
                    break;
                default:
                    FindFileExtra(path);
                    break;
            }

            return FindFileName(name);
        }

        private void FindFileExtra(string basePath, IEnumerable<string> extraPath = null)
        {
            extraPath = extraPath ?? new List<string> { string.Empty };

            _files.AddRange(Archive.GetFiles(basePath));

            foreach (var path in extraPath)
            {
                if (path.IsNotEmpty())
                {
                    _files.AddRange(Archive.GetFiles(basePath + path));
                }

                if (!CountAftermarketPrivate)
                {
                    continue;
                }

                var afterm = basePath + path + " (Aftermarket)";
                var privat = basePath + path + " (Private)";

                _files.AddRange(Archive.GetFiles(afterm));
                _files.AddRange(Archive.GetFiles(privat));
            }
        }

        private bool FindFileName(string name)
        {
            return _files.Select(Path.GetFileName).Any(fileName => fileName == name);

            // return Files.Select(file => Path.GetFileName(file.Trim('\'')).Replace("'", string.Empty)).Any(fileName => fileName == name);
        }
    }
}