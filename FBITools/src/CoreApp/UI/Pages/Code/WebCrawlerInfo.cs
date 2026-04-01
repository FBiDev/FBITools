using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public class WebCrawlerInfo
    {
        private const string MyRientLostLevelURL = "https://myrient.erista.me/files/Lost%20Level/Archive/";
        private const string MyRientNoIntroURL = "https://myrient.erista.me/files/No-Intro/";
        private const string MyRientRAURL = "https://myrient.erista.me/files/RetroAchievements/";
        private const string MyRientRedumpURL = "https://myrient.erista.me/files/Redump/";

        private static Dictionary<string, string> allFolders;

        public static async Task<string> GetURLHtml(string url)
        {
            return await Browser.DownloadString(url);
        }

        public static bool CheckFile(string folder, string fileName)
        {
            return File.Exists(Path.Combine(folder, fileName));
        }

        public static DateTime ConvertDate(string date)
        {
            var newDate = Cast.ToDateTime(date);
            return newDate;
        }

        public static long ConvertSize(string size)
        {
            if (size.Contains("TiB"))
            {
                var newSize = size.Replace(" TiB", string.Empty);
                var newSizeDouble = Cast.ToDouble(newSize);
                var newSizeInt = newSizeDouble * 1024 * 1024 * 1024 * 1024;
                return Convert.ToInt64(newSizeInt);
            }
            else if (size.Contains("GiB"))
            {
                var newSize = size.Replace(" GiB", string.Empty);
                var newSizeDouble = Cast.ToDouble(newSize);
                var newSizeInt = newSizeDouble * 1024 * 1024 * 1024;
                return Convert.ToInt64(newSizeInt);
            }
            else if (size.Contains("MiB"))
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

        public static Dictionary<string, string> GetMyrientFolders()
        {
            allFolders = new Dictionary<string, string> { };

            var lostLevelFolders = GetLostLevelFolders();
            var noIntroFolders = GetNoIntroFolders();
            var raFolders = GetRAFolders();
            var redumpFolders = GetRedumpFolders();

            //AddLostLevelFoldersToList(lostLevelFolders);
            AddNoIntroFoldersToList(noIntroFolders);
            //AddFoldersToList(raFolders, MyRientRAURL);
            //AddFoldersToList(redumpFolders, MyRientRedumpURL);

            allFolders = allFolders.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            return allFolders;
        }

        public static List<string> GetLostLevelFolders()
        {
            return File.ReadAllLines("Data/MyRient_LostLevel_Folders.txt").ToList();
        }

        public static List<string> GetNoIntroFolders()
        {
            return File.ReadAllLines("Data/MyRient_No-Intro_Folders.txt").ToList();
        }

        public static List<string> GetRAFolders()
        {
            return File.ReadAllLines("Data/MyRient_RA_Folders.txt").ToList();
        }

        public static List<string> GetRedumpFolders()
        {
            return File.ReadAllLines("Data/MyRient_Redump_Folders.txt").ToList();
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