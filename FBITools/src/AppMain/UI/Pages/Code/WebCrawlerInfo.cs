using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FBITools
{
    public class WebCrawlerInfo
    {
        private const string MyRientLostLevelURL = "https://myrient.erista.me/files/Lost%20Level/Archive/";
        private const string MyRientRAURL = "https://myrient.erista.me/files/RetroAchievements/";
        private const string MyRientNoIntroURL = "https://myrient.erista.me/files/No-Intro/";

        private static Dictionary<string, string> allFolders;

        public static Dictionary<string, string> GetMyrientFolders()
        {
            allFolders = new Dictionary<string, string> { };

            var lostLevelFolders = GetLostLevelFolders();
            var raFolders = GetRAFolders();
            var noIntroFolders = GetNoIntroFolders();

            AddLostLevelFoldersToList(lostLevelFolders);
            AddFoldersToList(raFolders, MyRientRAURL);
            AddNoIntroFoldersToList(noIntroFolders);

            allFolders = allFolders.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            return allFolders;
        }

        public static List<string> GetLostLevelFolders()
        {
            return File.ReadAllLines("Data/MyRient_LostLevel_Folders.txt").ToList();
        }

        public static List<string> GetRAFolders()
        {
            return File.ReadAllLines("Data/MyRient_RA_Folders.txt").ToList();
        }

        public static List<string> GetNoIntroFolders()
        {
            return File.ReadAllLines("Data/MyRient_No-Intro_Folders.txt").ToList();
        }

        private static void AddLostLevelFoldersToList(List<string> folders)
        {
            foreach (var f in folders)
            {
                var key = Uri.EscapeDataString(f);
                key = Path.Combine(MyRientLostLevelURL, key.TrimEnd('/') + "/");

                var newFolders = new List<string>();
                var folder = f.Substring(6, (f.Length - 6));
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
                var folder = "NoIntro - " + f;
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