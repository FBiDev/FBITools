using System.Collections.Generic;
using System.Threading.Tasks;
using FBITools.WiiU.Dao;

namespace FBITools.WiiU
{
    public class CategoryService
    {
        private readonly CategoryDao dao;

        public CategoryService()
        {
            dao = new CategoryDao();
        }

        public async Task<List<Category>> List()
        {
            return await dao.List();
        }

        public async Task<List<Category>> Search(Category obj)
        {
            return await dao.Search(obj);
        }

        public async Task<Category> Find(Category obj)
        {
            return await dao.Find(obj);
        }
    }
}