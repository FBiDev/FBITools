using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace FBITools.WiiU
{
    public class Title
    {
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
        [Field("Type")]
        public string Type { get; set; }

        [Display(AutoGenerateField = false)]
        [Field("Key")]
        public string Key { get; set; }

        static readonly TitleDao DAO = new TitleDao();

        public Title()
        {
            ID = Name = Key = string.Empty;
        }

        public async static Task<List<Title>> Search(Title obj)
        {
            if (obj == null) obj = new Title { };
            return await DAO.Search(obj);
        }

        public override string ToString()
        {
            return Name + " - " + Region;
        }
    }
}