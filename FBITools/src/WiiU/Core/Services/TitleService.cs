using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Core;
using App.Core.Desktop;
using FBITools.WiiU.DataAccess;

namespace FBITools.WiiU
{
    public class TitleService
    {
        private readonly TitleDao dao = new TitleDao();
        private DataList<Title> allTitles;
        private DataList<Title> filteredTitles;

        public TitleService()
        {
            dao = new TitleDao();
        }

        public async Task<List<Title>> List()
        {
            return await dao.List();
        }

        public async Task<List<Title>> Search(Title obj)
        {
            return await dao.Search(obj);
        }

        public async Task<Title> Find(Title obj)
        {
            return await dao.Find(obj);
        }

        public DataList<Title> GetFilteredTitles()
        {
            return filteredTitles;
        }

        public async Task FilterTitles(string id, string name, Func<string, bool> region, Func<string, bool> category)
        {
            if (allTitles.IsEmpty())
            {
                await LoadAllTitlesOrdered();
            }

            filteredTitles = new DataList<Title>(allTitles.Where(obj =>
                obj.ID.HasValue() &&
                obj.ID.Length >= id.Length &&
                obj.ID.Substring(0, id.Length) == id.ToUpper() &&
                obj.Name.ContainsExtend(name) &&
                region(obj.Region) &&
                category(obj.Category)).ToList());
        }

        public bool GenerateCetk(Title title)
        {
            try
            {
                var cetck = new HexFile(Cetk.BaseFile);
                cetck.Replace(Cetk.CommonKey, title.Key);
                cetck.Save(Cetk.FilePath);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private async Task LoadAllTitlesOrdered()
        {
            allTitles = new DataList<Title>((await List()).OrderBy(x => x.Name).ToList());
        }
    }
}