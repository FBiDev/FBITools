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
        private readonly TitleRepository _repository;

        private DataList<Title> _allTitles;
        private DataList<Title> _filteredTitles;

        public TitleService()
        {
            _repository = new TitleRepository();
        }

        public async Task<List<Title>> List()
        {
            return await _repository.List();
        }

        public async Task<List<Title>> Search(Title obj)
        {
            return await _repository.Search(obj);
        }

        public async Task<Title> Find(Title obj)
        {
            return await _repository.Find(obj);
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
                obj.ID.IsNotEmpty() &&
                obj.ID.Length >= id.Length &&
                obj.ID.Contains(id) &&
                //obj.ID.Substring(0, id.Length) == id.ToUpper() &&
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

        private async Task ListOrdered()
        {
            _allTitles = new DataList<Title>((await List()).OrderBy(x => x.Name).ToList());
        }
    }
}