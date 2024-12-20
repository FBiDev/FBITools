using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using FBITools.WiiU.Dao;

namespace FBITools.WiiU
{
    public class Region
    {
        private static readonly RegionDao DAO = new RegionDao();

        public Region()
        {
            Name = string.Empty;
        }

        [Field("ID")]
        public int ID { get; set; }

        [Field("Name")]
        public string Name { get; set; }

        public static async Task<List<Region>> Search(Region obj)
        {
            return await DAO.Search(obj);
        }

        public static async Task<List<Region>> List()
        {
            return await DAO.List();
        }

        public static async Task<Region> Find(Region obj)
        {
            return await DAO.Find(obj);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}