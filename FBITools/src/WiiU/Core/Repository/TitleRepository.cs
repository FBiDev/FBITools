using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using App.Core;
using FBITools.Properties;

namespace FBITools.WiiU.Repository
{
    public static class TitleRepository
    {
        #region " _Select "
        public static async Task<List<Title>> List()
        {
            return await Select();
        }
        #endregion

        #region " _Load "
        private static async Task<List<Title>> Select()
        {
            var sql = new SqlQuery(Resources.sql_WiiUTitle_List);

            return Load(await DatabaseWiiU.ExecutarSelect(sql));
        }

        private static List<Title> Load(DataTable table)
        {
            return table.ProcessRows<Title>((row, lst) =>
            {
                var entity = new Title
                {
                    Id = row.Value<string>("TitleID"),
                    Name = row.Value<string>("Name"),
                    Region = row.Value<string>("Region"),
                    Category = row.Value<string>("Category"),
                    Key = row.Value<string>("TitleKey")
                };

                lst.Add(entity);
            });
        }
        #endregion
    }
}