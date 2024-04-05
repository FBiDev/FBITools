using System;
using System.Linq;
using FBITools.Properties;
using System.IO;

namespace FBITools
{
    public class HexFile
    {
        public static byte[] WiiUcetk { get { return Resources.WiiUcetk; } }
        public static string WiiUcetkOldValue { get { return "0323FFC337C286242E8EF8F5813711EC"; } }

        public byte[] Content { get; set; }

        public HexFile(byte[] fileByteArray)
        {
            Content = fileByteArray;
        }

        public string ConvertToString()
        {
            return BitConverter.ToString(Content).Replace("-", "");
        }

        public byte[] ConvertToByteArray(string strHex)
        {
            return Enumerable.Range(0, strHex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(strHex.Substring(x, 2), 16))
                             .ToArray();
        }

        public void ChangeValue(string oldValue, string newValue)
        {
            var strHex = ConvertToString();
            Content = ConvertToByteArray(strHex.Replace(oldValue, newValue));
        }

        public void Save(string newFileName)
        {
            File.WriteAllBytes(newFileName, Content);
        }

        public void SaveWiiUcetk()
        {
            Save(@"Data\cetk");
        }
    }
}