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
        public LolRomsSite()
        {
            LocalPath = Network.UseProxy ? @"C:\WGET\myrient.erista.me\files\No-Intro\" :
                            @"D:\Fazendo\wget-1.21.4-win64\myrient.erista.me\files\No-Intro\";
        }

        protected override string Host
        {
            get
            {
                return "";
                //return "https://lolroms.com/";
            }
        }

        public override string LocalPath { get; protected set; }

        public override string HtmlTable { get; protected set; }

        public override List<string> HtmlItems { get; protected set; }

        public override string GetItemName(string html)
        {
            return html.GetBetween("class='fileicon'>", "</a>").Trim().HtmlDecode() + SufixItemName;
        }

        public override string GetItemSize(string html)
        {
            return html.GetBetween("<div class='meta'><span>", "</span>");
        }

        public override string GetItemDate(string html)
        {
            return html.GetBetween("</span><span>", "</span></div>");
        }

        public override string SufixItemName
        {
            get { return ".zip"; }
        }

        public override void RemoveItems() { }

        public override DataList<Rom> Items { get; set; }

        public override Dictionary<string, string> GetUrls()
        {
            var folders = SetUrls("data/LolRomsFolders.txt");

            return folders.ToDictionary(item => item.Key + ".html", item => item.Value);
        }

        public override Task SetHtml(string path)
        {
            Html = Archive.ReadAll("data/lol/" + path);
            HtmlTable = Html.GetBetween("<ul class=\"list\">", "</ul>", true);
            HtmlItems = HtmlTable.GetBetweenList("<a class='file' href='", "</span></div>", true);

            Files = new List<string>();
            return Task.CompletedTask;
        }

        private List<string> Files;

        public override bool FindFile(string path, string name)
        {
            if (Files.Count == 0)
            {
                var afterm = path + " (Aftermarket)";
                var privat = path + " (Private)";

                if (Directory.Exists(path))
                {
                    Files = Directory.GetFiles(path).ToList();
                }

                if (Directory.Exists(afterm))
                {
                    Files.AddRange(Directory.GetFiles(afterm).ToList());
                }

                if (Directory.Exists(privat))
                {
                    Files.AddRange(Directory.GetFiles(privat).ToList());
                }
            }

            //return Files.Select(file => Path.GetFileName(file.Trim('\'')).Replace("'", string.Empty)).Any(fileName => fileName == name);
            return Files.Select(Path.GetFileName).Any(fileName => fileName == name);
        }
    }
}