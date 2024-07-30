using FBITools.Properties;

namespace FBITools.WiiU
{
    public static class Cetk
    {
        public static string CommonKey { get { return "0323FFC337C286242E8EF8F5813711EC"; } }
        public static byte[] BaseFile { get { return Resources.WiiUcetk; } }
        public static string FilePath { get { return @"Data\cetk"; } }
        public static string Database { get { return @"Data\WiiUDatabase.db"; } }
    }
}