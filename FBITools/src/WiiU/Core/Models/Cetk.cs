using FBITools.Properties;

namespace FBITools.WiiU
{
    public static class Cetk
    {
        public static byte[] BaseFile
        {
            get { return Resources.WiiUcetk; }
        }

        public static string CommonKey
        {
            get { return "0323FFC337C286242E8EF8F5813711EC"; }
        }

        public static string Database
        {
            get { return @"Data\WiiUDatabase.db"; }
        }

        public static string FilePath
        {
            get { return @"Data\cetk"; }
        }
    }
}