using System;
using System.Net;
using App.Core.Desktop;
using System.Threading.Tasks;

namespace FBITools
{
    public static class Network
    {
        private static WebClientExtend Client { get; set; }

        public static bool UseProxy { get { return Browser.UseProxy; } }

        public static void Load()
        {
            Browser.UseProxy = Environment.MachineName.Equals("cohab-ct0157", StringComparison.InvariantCultureIgnoreCase);
            Browser.DefaultProxy = new WebProxy
            {
                Address = new Uri("http://cohab-proxy.cohabct.com.br:3128"),
                BypassProxyOnLocal = true,
                BypassList = new string[] { },
                Credentials = new NetworkCredential("fbirnfeld", "zumbie")
            };

            Client = new WebClientExtend();

            Client.Headers.Clear();

            Client.Headers.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.7");
            Client.Headers.Add("Accept-Encoding", "gzip, deflate, br, zstd");
            Client.Headers.Add("Accept-Language", "en-US,en;q=0.9,pt;q=0.8,fr;q=0.7");
            Client.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/149.0.0.0 Safari/537.36 Edg/149.0.0.0");
        }

        public static async Task<string> DownloadString(string url)
        {
            return await Client.DownloadString(url);
        }

        public static async Task<byte[]> DownloadData(string url)
        {
            return await Client.DownloadData(url);
        }
    }
}
