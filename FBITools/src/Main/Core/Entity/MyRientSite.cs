using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public sealed class MyRientSite : WebCrawlerSite
    {
        private const string MyRientLostLevelURL = "https://myrient.erista.me/files/Lost%20Level/Archive/";
        private const string MyRientNoIntroURL = "https://myrient.erista.me/files/No-Intro/";
        private const string MyRientRAURL = "https://myrient.erista.me/files/RetroAchievements/";
        private const string MyRientRedumpURL = "https://myrient.erista.me/files/Redump/";

        private static Dictionary<string, string> allFolders;

        public MyRientSite()
        {
            LocalPath = Network.UseProxy ? @"C:\WGET\myrient.erista.me\files\No-Intro\" : @"D:\Fazendo\wget-1.21.4-win64\myrient.erista.me\files\No-Intro\";
            HtmlItems = new List<string>();
        }

        protected override string Host
        {
            get { return "https://myrient.erista.me/files/"; }
        }

        public override string LocalPath { get; protected set; }

        public override string HtmlTable { get; protected set; }

        public override List<string> HtmlItems { get; protected set; }

        public override string GetItemName(string html)
        {
            return html.GetBetween("\">", "</a>").HtmlDecode() + SufixItemName;
        }

        public override string GetItemSize(string html)
        {
            return html.GetBetween("<div class=\"meta\"> <span>", "</span>");
        }

        public override string GetItemDate(string html)
        {
            return html.GetBetween("</span> <span>", "</span> </div>");
        }

        public override string SufixItemName
        {
            get { return string.Empty; }
        }

        public override void RemoveItems()
        {
            if (HtmlItems.Count > 0)
            {
                HtmlItems.RemoveRange(0, 3);
            }
        }

        public override DataList<Rom> Items { get; set; }

        public override Dictionary<string, string> GetUrls()
        {
            return GetMyrientFolders();
        }

        public override async void SetHtml(string path)
        {
            Html = await Network.DownloadString(path);
            HtmlTable = Html.GetBetween("<ul class=\"list\">", "</ul>", true);
            HtmlItems = HtmlTable.GetBetweenList("<a class=\"file\" href=\"", "</span> </div>", true);
        }

        ///

        private static Dictionary<string, string> GetMyrientFolders()
        {
            allFolders = new Dictionary<string, string> { };

            var lostLevelFolders = GetLostLevelFolders();
            var noIntroFolders = GetNoIntroFolders();
            var raFolders = GetRAFolders();
            var redumpFolders = GetRedumpFolders();

            //// AddLostLevelFoldersToList(lostLevelFolders);
            AddNoIntroFoldersToList(noIntroFolders);
            ////AddFoldersToList(raFolders, MyRientRAURL);
            //// AddFoldersToList(redumpFolders, MyRientRedumpURL);

            allFolders = allFolders.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            return allFolders;
        }

        private static List<string> GetLostLevelFolders()
        {
            return File.ReadAllLines("data/MyRient_LostLevel_Folders.txt").ToList();
        }

        private static List<string> GetNoIntroFolders()
        {
            return File.ReadAllLines("data/MyRient_No-Intro_Folders.txt").ToList();
        }

        private static List<string> GetRAFolders()
        {
            return File.ReadAllLines("data/MyRient_RA_Folders.txt").ToList();
        }

        private static List<string> GetRedumpFolders()
        {
            return File.ReadAllLines("data/MyRient_Redump_Folders.txt").ToList();
        }

        private static void AddLostLevelFoldersToList(List<string> folders)
        {
            foreach (var f in folders)
            {
                var key = Uri.EscapeDataString(f);
                key = Path.Combine(MyRientLostLevelURL, key.TrimEnd('/') + "/");

                var newFolders = new List<string>();
                var folder = f;
                newFolders.Add(folder);

                allFolders.Add(key, folder);
            }
        }

        private static void AddNoIntroFoldersToList(List<string> folders)
        {
            foreach (var f in folders)
            {
                var key = Uri.EscapeDataString(f);
                key = Path.Combine(MyRientNoIntroURL, key.TrimEnd('/') + "/");

                var newFolders = new List<string>();
                //var folder = "NoIntro - " + f;
                var folder = f;
                newFolders.Add(folder);

                allFolders.Add(key, folder);
            }
        }

        private static void AddFoldersToList(List<string> folders, string urlBase)
        {
            foreach (var f in folders)
            {
                var key = Uri.EscapeDataString(f);
                key = Path.Combine(urlBase, key.TrimEnd('/') + "/");

                allFolders.Add(key, f);
            }
        }
    }
}
