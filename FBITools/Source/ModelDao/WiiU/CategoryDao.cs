using System.Collections.Generic;
using System.Threading.Tasks;
using App.Core;
using App.Core.Desktop;
using FBITools.Properties;

namespace FBITools.WiiU.Dao
{
    public class CategoryDao : DatabaseDao
    {
        #region " _Select "
        public async Task<List<Category>> Search(Category obj)
        {
            var sql = Resources.sql_WiiUCategory_List;
            var parameters = GetFilters(obj);

            return Load<List<Category>>(await BancoWiiU.ExecutarSelect(sql, parameters));
        }

        public async Task<Category> Find(Category obj)
        {
            return (await Search(obj)).FirstOrNew();
        }
        #endregion

        #region " _Parameters "
        private List<SqlParameter> GetFilters(Category obj)
        {
            return new List<SqlParameter>
            {
                ////new SqlParameter("@name", obj.Name)
            };
        }
        #endregion
    }
}