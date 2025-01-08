using System;
using System.Linq;
using System.Threading.Tasks;
using App.Core;
using App.Core.Desktop;

namespace FBITools.WiiU
{
    public partial class WiiUcetkController
    {
        private ListBind<Title> titles;
        private ListBind<Title> titlesFilter;

        public WiiUcetkController(WiiUcetkForm page)
        {
            Page = page;
            Page.Shown += Page_Shown;
            Page.GotFocus += (s, e) => TitleIDTextBox.Focus();
            Page.FinalLoadOnceAsync += Controls_Load;
        }

        private void Page_Shown(object sender, EventArgs ev)
        {
            WarningLabel.TextChanged += WarningLabel_TextChanged;
            GenerateCetkButton.Click += GenerateCetkButton_Click;

            TitleIDTextBox.TextChanged += (s, e) => SearchTitles().TryAwait();
            TitleNameTextBox.TextChanged += (s, e) => SearchTitles().TryAwait();

            TitlesGrid.Statusbar = TitlesStatusBar;
        }

        private async void WarningLabel_TextChanged(object sender, EventArgs e)
        {
            await TaskController.Delay(4);
            WarningLabel.Text = string.Empty;
        }

        private async Task Controls_Load()
        {
            RegionCheckedList.DataSource = await Region.List();
            RegionCheckedList.SetItemsChecked(true);

            CategoryCheckedList.DataSource = await Category.List();
            CategoryCheckedList.SetItemsChecked(true);

            RegionCheckedList.ItemCheck += (s, e) => SearchTitles().TryAwait();
            CategoryCheckedList.ItemCheck += (s, e) => SearchTitles().TryAwait();

            titles = new ListBind<Title>((await Title.List()).OrderBy(x => x.Name).ToList());

            await SearchTitles();
        }

        private void GenerateCetkButton_Click(object sender, EventArgs e)
        {
            if (TitlesGrid.SelectedRows.AnyRow() == false)
            {
                return;
            }

            var title = TitlesGrid.GetCurrentRowObject<Title>();
            var cetck = new HexFile(Cetk.BaseFile);
            cetck.Replace(Cetk.CommonKey, title.Key);
            cetck.Save(Cetk.FilePath);

            WarningLabel.Text = "cetk " + title + " Saved!";
        }

        private void SetGridDataSource(ListBind<Title> list)
        {
            TitlesGrid.DataSource = list;
            GenerateCetkButton.Enabled = list.Count > 0;
        }

        private Task SearchTitles()
        {
            string searchID = TitleIDTextBox.Text;
            string searchName = TitleNameTextBox.Text;

            titlesFilter = new ListBind<Title>();

            foreach (Title obj in titles)
            {
                bool id = obj.ID.HasValue() && obj.ID.Length >= searchID.Length && obj.ID.Substring(0, searchID.Length) == searchID.ToUpper();
                var title = obj.Name.ContainsExtend(searchName);
                var region = RegionCheckedList.IsItemChecked(obj.Region);
                var category = CategoryCheckedList.IsItemChecked(obj.Category);

                if (id && title && region && category)
                {
                    titlesFilter.Add(obj);
                }
            }

            SetGridDataSource(titlesFilter);
            return Task.CompletedTask;
        }
    }
}