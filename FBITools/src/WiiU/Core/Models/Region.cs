using System.ComponentModel;

namespace FBITools.WiiU
{
    public class Region
    {
        public Region()
        {
            Name = string.Empty;
        }

        [Field("ID")]
        public int ID { get; set; }

        [Field("Name")]
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}