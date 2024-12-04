using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using FBITools.WiiU.Dao;

namespace FBITools.WiiU
{
    public class Region
    {
        private static readonly RegionDao DAO = new RegionDao();

        [Field("ID")]
        public int ID { get; set; }

        [Field("Name")]
        public string Name { get; set; }

        public static async Task<List<Region>> List()
        {
            return await DAO.Search(null);
        }

        public static async Task<List<Region>> Search(Region obj)
        {
            obj = obj ?? new Region();
            return await DAO.Search(obj);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}