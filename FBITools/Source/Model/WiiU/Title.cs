using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using FBITools.WiiU.Dao;

namespace FBITools.WiiU
{
    public class Title
    {
        private static readonly TitleDao DAO = new TitleDao();

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

        public static async Task<List<Title>> Search(Title obj)
        {
            return await DAO.Search(obj);
        }

        public static async Task<List<Title>> List()
        {
            return await DAO.List();
        }

        public static async Task<Title> Find(Title obj)
        {
            return await DAO.Find(obj);
        }

        public override string ToString()
        {
            return Name + " - " + Region;
        }
    }
}