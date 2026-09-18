using System.Collections.Generic;
using System.Threading.Tasks;
using FBITools.WiiU.Repository;

namespace FBITools.WiiU
{
    public static class CategoryService
    {
        public static async Task<List<Category>> List()
        {
            return await CategoryRepository.List();
        }
    }
}