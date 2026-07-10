using System.Collections.Generic;
using System.IO;
using App.Core.Desktop;

namespace FBITools
{
    public enum WebSite
    {
        MyRient,
        LoLRoms
    }

    public abstract class WebCrawlerSite
    {
        //var temp = "https://myrient.erista.me/files/No-Intro/";
        //temp = "https://myrient.erista.me/dats/Lost%20Level/Archive/";
        //temp = "https://lolroms.com/Atari/2600";

        protected string Html = string.Empty;

        public int Id { get; set; }

        public string Title { get; set; }

        protected abstract string Host { get; }

        public abstract string LocalPath { get; protected set; }

        public abstract string HtmlTable { get; protected set; }

        public abstract List<string> HtmlItems { get; protected set; }

        public abstract string GetItemName(string html);

        public abstract string GetItemSize(string html);

        public abstract string GetItemDate(string html);

        public abstract string SufixItemName { get; }

        public abstract void RemoveItems();

        public abstract DataList<Rom> Items { get; set; }

        public abstract Dictionary<string, string> GetUrls();

        protected Dictionary<string, string> SetUrls(string path)
        {
            var lines = File.ReadAllLines(path);
            var dictionary = new Dictionary<string, string>();

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) { continue; }

                var parts = line.Split(new[] { ',' }, 2);

                //var key = Uri.EscapeDataString(parts[0]);
                var key = Path.Combine(Host, parts[0].TrimEnd('/'));

                if (parts.Length == 1)
                {
                    dictionary[key] = parts[0];
                    continue;
                }

                dictionary[key] = parts[1];
            }

            return dictionary;
        }

        public abstract void SetHtml(string path);
    }
}