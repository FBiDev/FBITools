using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace FBITools.WiiU
{
    public class Category
    {
        [Field("ID")]
        public int ID { get; set; }

        [Field("Name")]
        public string Name { get; set; }

        static readonly CategoryDao DAO = new CategoryDao();

        public async static Task<List<Category>> List()
        {
            return await DAO.Search(null);
        }

        public async static Task<List<Category>> Search(Category obj)
        {
            if (obj == null) obj = new Category { };
            return await DAO.Search(obj);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}