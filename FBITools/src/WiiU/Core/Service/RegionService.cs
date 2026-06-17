using System.Collections.Generic;
using System.Threading.Tasks;
using FBITools.WiiU.Repository;

namespace FBITools.WiiU
{
    public class RegionService
    {
        private readonly RegionRepository _repository;

        public RegionService()
        {
            _repository = new RegionRepository();
        }

        public async Task<List<Region>> List()
        {
            return await _repository.List();
        }

        public async Task<List<Region>> Search(Region obj)
        {
            return await _repository.Search(obj);
        }

        public async Task<Region> Find(Region obj)
        {
            return await _repository.Find(obj);
        }
    }
}