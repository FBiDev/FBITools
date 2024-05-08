using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace FBITools.WiiU
{
    public class Type
    {
        [Field("Id")]
        public int Id { get; set; }

        [Field("Name")]
        public string Name { get; set; }

        static readonly TypeDao DAO = new TypeDao();

        public async static Task<List<Type>> List()
        {
            return await DAO.Search(null);
        }

        public async static Task<List<Type>> Search(Type obj)
        {
            if (obj == null) obj = new Type { };
            return await DAO.Search(obj);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}