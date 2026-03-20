using System.ComponentModel;

namespace FBITools.WiiU
{
    public class Title
    {
        public Title()
        {
            ID = Name = Key = string.Empty;
        }

        [Style(Width = 120, FontName = "Courier New")]
        [Field("TitleID")]
        public string ID { get; set; }

        [Style(AutoSizeMode = ColumnAutoSizeMode.Fill)]
        [Field("Name")]
        public string Name { get; set; }

        [Style(Width = 70, Align = ColumnAlign.Center)]
        [Field("Region")]
        public string Region { get; set; }

        [Style(Width = 110, Align = ColumnAlign.Center)]
        [Field("Category")]
        public string Category { get; set; }

        [Display(AutoGenerateField = false)]
        [Field("TitleKey")]
        public string Key { get; set; }

        public override string ToString()
        {
            return Name + " - " + Region;
        }
    }
}