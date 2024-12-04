using System.Collections.Generic;
using System.Threading.Tasks;
using App.Core;
using App.Core.Desktop;
using FBITools.Properties;

namespace FBITools.WiiU.Dao
{
    public class TitleDao : DatabaseDao
    {
        #region " _Select "
        public async Task<List<Title>> Search(Title obj)
        {
            var sql = Resources.sql_WiiUTitle_List;
            var parameters = GetFilters(obj);

            return Load<List<Title>>(await BancoWiiU.ExecutarSelect(sql, parameters));
        }

        public async Task<Title> Find(Title obj)
        {
            return (await Search(obj)).FirstOrNew();
        }
        #endregion

        #region " _Parameters "
        private List<SqlParameter> GetFilters(Title obj)
        {
            return new List<SqlParameter>
            {
                ////new SqlParameter("@name", obj.Name)
            };
        }
        #endregion
    }
}