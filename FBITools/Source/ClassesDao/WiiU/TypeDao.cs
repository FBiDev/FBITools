using System.Collections.Generic;
using System.Threading.Tasks;
using App.Core;
using App.Core.Desktop;
using FBITools.Properties;

namespace FBITools.WiiU
{
    public class TypeDao : DatabaseDao
    {
        #region " _Parameters "
        List<SqlParameter> GetFilters(Type obj)
        {
            return new List<SqlParameter>
            {
                //new SqlParameter("@name", obj.Name)
            };
        }
        #endregion

        #region " _Select "
        public async Task<List<Type>> Search(Type obj)
        {
            var sql = Resources.sql_WiiUType_List;
            var parameters = GetFilters(obj);

            return Load<List<Type>>(await BancoWiiU.ExecutarSelect(sql, parameters));
        }

        public async Task<Type> Find(Type obj)
        {
            return (await Search(obj)).FirstOrNew();
        }
        #endregion
    }
}