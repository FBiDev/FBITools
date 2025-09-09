using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using App.Core;
using FBITools.Properties;

namespace FBITools.WiiU.Dao
{
    public class RegionDao : DaoBase
    {
        #region " _Select "
        public async Task<List<Region>> List()
        {
            return await Select();
        }

        public async Task<List<Region>> Search(Region obj)
        {
            return await Select(obj);
        }

        public async Task<Region> Find(Region obj)
        {
            return (await Select(obj)).FirstOrNew();
        }
        #endregion

        #region " _Actions "
        public async Task<List<Region>> Select(Region obj = null)
        {
            obj = obj ?? new Region();

            var sql = new SqlQuery(Resources.sql_WiiURegion_List, DatabaseAction.Select);

            return Load(await BancoWiiU.ExecutarSelect(sql));
        }
        #endregion

        #region " _Load "
        private List<Region> Load(DataTable table)
        {
            return table.ProcessRows<Region>((row, lst) =>
            {
                var entity = new Region
                {
                    ID = row.Value<int>("ID"),
                    Name = row.Value<string>("Name"),
                };

                lst.Add(entity);
            });
        }
        #endregion
    }
}