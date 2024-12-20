using System.Collections.Generic;
using System.Threading.Tasks;
using App.Core;
using App.Core.Desktop;
using FBITools.Properties;

namespace FBITools.WiiU.Dao
{
    public class RegionDao : DatabaseDao
    {
        #region " _Select "
        public async Task<List<Region>> Search(Region obj)
        {
            obj = obj ?? new Region();

            var sql = Resources.sql_WiiURegion_List;
            var parameters = GetFilters(obj);

            return Load<List<Region>>(await BancoWiiU.ExecutarSelect(sql, parameters));
        }

        public async Task<List<Region>> List()
        {
            return await Search(null);
        }

        public async Task<Region> Find(Region obj)
        {
            return (await Search(obj)).FirstOrNew();
        }
        #endregion

        #region " _Parameters "
        private List<SqlParameter> GetFilters(Region obj)
        {
            return new List<SqlParameter>
            {
                ////new SqlParameter("@name", obj.Name)
            };
        }
        #endregion
    }
}