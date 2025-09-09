using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using App.Core;
using FBITools.Properties;

namespace FBITools.WiiU.Dao
{
    public class CategoryDao : DaoBase
    {
        #region " _Select "
        public async Task<List<Category>> List()
        {
            return await Select();
        }

        public async Task<List<Category>> Search(Category obj)
        {
            return await Select(obj);
        }

        public async Task<Category> Find(Category obj)
        {
            return (await Select(obj)).FirstOrNew();
        }
        #endregion

        #region " _Actions "
        public async Task<List<Category>> Select(Category obj = null)
        {
            obj = obj ?? new Category();

            var sql = new SqlQuery(Resources.sql_WiiUCategory_List, DatabaseAction.Select);

            return Load(await BancoWiiU.ExecutarSelect(sql));
        }
        #endregion

        #region " _Load "
        private List<Category> Load(DataTable table)
        {
            return table.ProcessRows<Category>((row, lst) =>
            {
                var entity = new Category
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