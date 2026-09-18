using System.Collections.Generic;
using System.Threading.Tasks;
using FBITools.WiiU.Repository;

namespace FBITools.WiiU
{
    public static class RegionService
    {
        public static async Task<List<Region>> List()
        {
            return await RegionRepository.List();
        }
    }
}