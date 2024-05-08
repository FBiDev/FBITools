using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace FBITools.WiiU
{

    public class Region
    {
        [Field("Id")]
        public int Id { get; set; }

        [Field("Name")]
        public string Name { get; set; }

        static readonly RegionDao DAO = new RegionDao();

        public async static Task<List<Region>> List()
        {
            return await DAO.Search(null);
        }

        public async static Task<List<Region>> Search(Region obj)
        {
            if (obj == null) obj = new Region { };
            return await DAO.Search(obj);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}