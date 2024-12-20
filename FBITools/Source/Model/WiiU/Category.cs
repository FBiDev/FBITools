using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using FBITools.WiiU.Dao;

namespace FBITools.WiiU
{
    public class Category
    {
        private static readonly CategoryDao DAO = new CategoryDao();

        public Category()
        {
            Name = string.Empty;
        }

        [Field("ID")]
        public int ID { get; set; }

        [Field("Name")]
        public string Name { get; set; }

        public static async Task<List<Category>> Search(Category obj)
        {
            return await DAO.Search(obj);
        }

        public static async Task<List<Category>> List()
        {
            return await DAO.List();
        }

        public static async Task<Category> Find(Category obj)
        {
            return await DAO.Find(obj);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}