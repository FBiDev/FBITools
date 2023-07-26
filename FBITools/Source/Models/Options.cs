using Newtonsoft.Json;

namespace FBITools
{
    public class Options
    {
        public string SaveState_Origin { get; set; }
        public string SaveState_Destination { get; set; }

        public string MemoryCard_Origin { get; set; }
        public string MemoryCard_Destination { get; set; }
        public int MemoryCard_Timer { get; set; }

        [JsonIgnore]
        public string File = "Options.json";
    }
}