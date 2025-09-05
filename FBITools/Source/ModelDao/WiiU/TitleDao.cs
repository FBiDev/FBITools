using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using App.Core;
using FBITools.Properties;

namespace FBITools.WiiU.Dao
{
    public class TitleDao : DaoBase
    {
        #region " _Select "
        public async Task<List<Title>> List()
        {
            return await Select();
        }

        public async Task<List<Title>> Search(Title obj)
        {
            return await Select(obj);
        }

        public async Task<Title> Find(Title obj)
        {
            return (await Select(obj)).FirstOrNew();
        }
        #endregion

        #region " _Actions "
        public async Task<List<Title>> Select(Title obj = null)
        {
            obj = obj ?? new Title();

            var sql = new SqlQuery(Resources.sql_WiiUTitle_List, DatabaseAction.Select);

            return Load(await BancoWiiU.ExecutarSelect(sql));
        }
        #endregion

        #region " _Load "
        private List<Title> Load(DataTable table)
        {
            return table.ProcessRows<Title>((row, lst) =>
            {
                var entity = new Title
                {
                    ID = row.Value<string>("TitleID"),
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