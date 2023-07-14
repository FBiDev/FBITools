using System;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace FBITools
{
    public static class Json
    {
        public static bool Save(object obj, string filePath, Formatting format = Formatting.Indented)
        {
            try
            {
                var json_data = JsonConvert.SerializeObject(obj, format);
                json_data = json_data.Replace(@"\\", "/");

                File.WriteAllText(filePath, json_data, Encoding.UTF8);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Load<T>(ref T obj, string filePath) where T : class
        {
            if (File.Exists(filePath))
            {
                var json_data = File.ReadAllText(filePath);
                obj = JsonConvert.DeserializeObject<T>(json_data);
                return true;
            }
            return false;
        }
    }
}