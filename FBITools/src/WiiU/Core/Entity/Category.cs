using System.ComponentModel;

namespace FBITools.WiiU
{
    public class Category
    {
        public Category()
        {
            Name = string.Empty;
        }

        [Field("ID")]
        public int Id { get; set; }

        [Field("Name")]
        public string Name { private get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}