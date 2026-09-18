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
            return html.GetBetween("class='fileicon'>", "</a>").Trim().HtmlDecode() + SufixItemName;
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
            HtmlTable = Html.GetBetween("<ul class=\"list\">", "</ul>", true);
            HtmlItems = HtmlTable.GetBetweenList("<li class='filei'>", "</li>");

            _files = new List<string>();
            return Task.CompletedTask;
        }

        public override bool FindFile(string path, string name)
        {
            if (_files.Count != 0)
            {
                return FindFileName(name);
            }

            var afterm = path + " (Aftermarket)";
            var privat = path + " (Private)";

            if (Directory.Exists(path))
            {
                _files = Directory.GetFiles(path).ToList();
            }

            if (Directory.Exists(afterm))
            {
                _files.AddRange(Directory.GetFiles(afterm).ToList());
            }

            if (Directory.Exists(privat))
            {
                _files.AddRange(Directory.GetFiles(privat).ToList());
            }
            
            return FindFileName(name);
        }

        private bool FindFileName(string name)
        {
            return _files.Select(Path.GetFileName).Any(fileName => fileName == name);

            // return Files.Select(file => Path.GetFileName(file.Trim('\'')).Replace("'", string.Empty)).Any(fileName => fileName == name);
        }
    }
}