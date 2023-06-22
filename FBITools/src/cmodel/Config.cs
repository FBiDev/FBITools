using Newtonsoft.Json;

namespace FBITools
{
    public class Config
    {
        public string SaveState_Origin { get; set; }
        public string SaveState_Destination { get; set; }

        [JsonIgnore]
        public string File = "Config.json";
    }
}