using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Core;
using App.Core.Desktop;
using FBITools.WiiU.Repository;

namespace FBITools.WiiU
{
    public class TitleService
    {
        private DataList<Title> _allTitles;
        private DataList<Title> _filteredTitles;

        public static bool GenerateCetk(Title title)
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

        public DataList<Title> GetFilteredTitles()
        {
            return _filteredTitles;
        }

        public async Task FilterTitles(string id, string name, Func<string, bool> region, Func<string, bool> category)
        {
            if (_allTitles.IsEmpty())
            {
                await ListOrdered();
            }

            _filteredTitles = new DataList<Title>(_allTitles.Where(obj =>
                obj.Id.IsNotEmpty() &&
                obj.Id.Length >= id.Length &&
                obj.Id.Contains(id) &&
                ////obj.Id.Substring(0, id.Length) == id.ToUpper() &&
                obj.Name.ContainsExtend(name) &&
                region(obj.Region) &&
                category(obj.Category)).ToList());
        }

        private static async Task<List<Title>> List()
        {
            return await TitleRepository.List();
        }

        private async Task ListOrdered()
        {
            _allTitles = new DataList<Title>((await List()).OrderBy(x => x.Name).ToList());
        }
    }
}