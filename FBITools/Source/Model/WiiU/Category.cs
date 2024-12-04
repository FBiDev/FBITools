using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using FBITools.WiiU.Dao;

namespace FBITools.WiiU
{
    public class Category
    {
        private static readonly CategoryDao DAO = new CategoryDao();

        [Field("ID")]
        public int ID { get; set; }

        [Field("Name")]
        public string Name { get; set; }

        public static async Task<List<Category>> List()
        {
            return await DAO.Search(null);
        }

        public static async Task<List<Category>> Search(Category obj)
        {
            obj = obj ?? new Category();
            return await DAO.Search(obj);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}