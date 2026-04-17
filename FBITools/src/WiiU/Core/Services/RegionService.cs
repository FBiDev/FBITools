using System.Collections.Generic;
using System.Threading.Tasks;
using FBITools.WiiU.Repository;

namespace FBITools.WiiU
{
    public class RegionService
    {
        private readonly RegionRepository dao;

        public RegionService()
        {
            dao = new RegionRepository();
        }

        public async Task<List<Region>> List()
        {
            return await dao.List();
        }

        public async Task<List<Region>> Search(Region obj)
        {
            return await dao.Search(obj);
        }

        public async Task<Region> Find(Region obj)
        {
            return await dao.Find(obj);
        }
    }
}