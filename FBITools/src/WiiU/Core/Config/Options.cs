using App.Serialization;

namespace FBITools.WiiU
{
    public static class Options
    {
        [JsonIgnore]
        public static readonly string WiiUDatabaseFile = Cetk.Database;
    }
}