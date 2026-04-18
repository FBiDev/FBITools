using System.Collections.Generic;
using System.Threading.Tasks;
using FBITools.WiiU.Repository;

namespace FBITools.WiiU
{
    public class CategoryService
    {
        private readonly CategoryRepository _repository;

        public CategoryService()
        {
            _repository = new CategoryRepository();
        }

        public async Task<List<Category>> List()
        {
            return await _repository.List();
        }

        public async Task<List<Category>> Search(Category obj)
        {
            return await _repository.Search(obj);
        }

        public async Task<Category> Find(Category obj)
        {
            return await _repository.Find(obj);
        }
    }
}