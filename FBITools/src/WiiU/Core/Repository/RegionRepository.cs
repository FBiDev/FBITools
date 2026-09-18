using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using App.Core;
using FBITools.Properties;

namespace FBITools.WiiU.Repository
{
    public static class RegionRepository
    {
        #region " _Select "
        public static async Task<List<Region>> List()
        {
            return await Select();
        }
        #endregion

        #region " _Load "
        private static async Task<List<Region>> Select()
        {
            var sql = new SqlQuery(Resources.sql_WiiURegion_List);

            return Load(await DatabaseWiiU.ExecutarSelect(sql));
        }

        private static List<Region> Load(DataTable table)
        {
            return table.ProcessRows<Region>((row, lst) =>
            {
                var entity = new Region
                {
                    Id = row.Value<int>("ID"),
                    Name = row.Value<string>("Name"),
                };

                lst.Add(entity);
            });
        }
        #endregion
    }
}