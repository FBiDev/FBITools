using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using App.Core;
using FBITools.Properties;

namespace FBITools.WiiU.Repository
{
    public static class CategoryRepository
    {
        #region " _Select "
        public static async Task<List<Category>> List()
        {
            return await Select();
        }
        #endregion

        #region " _Load "
        private static async Task<List<Category>> Select()
        {
            var sql = new SqlQuery(Resources.sql_WiiUCategory_List);

            return Load(await DatabaseWiiU.ExecutarSelect(sql));
        }

        private static List<Category> Load(DataTable table)
        {
            return table.ProcessRows<Category>((row, lst) =>
            {
                var entity = new Category
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