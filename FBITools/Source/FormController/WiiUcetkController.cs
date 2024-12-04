using System;
using System.Linq;
using System.Threading.Tasks;
using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public partial class WiiUcetkController
    {
        private ListBind<WiiU.Title> titles = new ListBind<WiiU.Title>();
        private ListBind<WiiU.Title> titlesFilter = new ListBind<WiiU.Title>();

        public WiiUcetkController(WiiUcetkForm pageForm)
        {
            Page = pageForm;
            Page.Shown += ShownForm;
            Page.GotFocus += (s, e) => TitleIDTextBox.Focus();
            Page.FinalLoadOnceAsync += CarregarCamposAsync;
        }

        private void ShownForm(object sender, EventArgs ev)
        {
            WarningLabel.TextChanged += WarningLabel_TextChanged;
            GenerateCetkButton.Click += GenerateCetkButton_Click;

            TitleIDTextBox.TextChanged += (s, e) => SearchTitles().TryAwait();
            TitleNameTextBox.TextChanged += (s, e) => SearchTitles().TryAwait();
            ListRegionCheckedList.ItemCheck += (s, e) => SearchTitles().TryAwait();
            ListCategoryCheckedList.ItemCheck += (s, e) => SearchTitles().TryAwait();

            TitlesGrid.Statusbar = TitlesStatusBar;
        }

        private async void WarningLabel_TextChanged(object sender, EventArgs e)
        {
            await TaskController.Delay(4);
            WarningLabel.Text = string.Empty;
        }

        private async Task CarregarCamposAsync()
        {
            ListRegionCheckedList.Items.AddRange((await WiiU.Region.List()).Select(x => x.Name).ToArray());
            ListRegionCheckedList.SetItemsChecked(true);

            ListCategoryCheckedList.Items.AddRange((await WiiU.Category.List()).Select(x => x.Name).ToArray());
            ListCategoryCheckedList.SetItemsChecked(true);

            titles = new ListBind<WiiU.Title>(await WiiU.Title.Search(new WiiU.Title()));
            titlesFilter = titles;
            SetDataSource(titlesFilter);
        }

        private Task SearchTitles()
        {
            string searchID = TitleIDTextBox.Text;
            string searchName = TitleNameTextBox.Text;

            ////if (searchID.Length == 0 && searchName.Length == 0)
            ////{
            ////    SetDataSource(titles);
            ////    return Task.CompletedTask;
            ////}

            titlesFilter = new ListBind<WiiU.Title>();

            foreach (WiiU.Title obj in titles)
            {
                bool id = obj.ID.HasValue() && obj.ID.Length >= searchID.Length && obj.ID.Substring(0, searchID.Length) == searchID.ToUpper();
                bool title = obj.Name.ContainsExtend(searchName);
                var region = ListRegionCheckedList.GetItemChecked(obj.Region);
                var type = ListCategoryCheckedList.GetItemChecked(obj.Category);

                if (id && title && region && type)
                {
                    titlesFilter.Add(obj);
                }
            }

            SetDataSource(titlesFilter);
            return Task.CompletedTask;
        }

        private void SetDataSource(ListBind<WiiU.Title> list)
        {
            TitlesGrid.DataSource = list;
            GenerateCetkButton.Enabled = list.Count > 0;
        }

        private void GenerateCetkButton_Click(object sender, EventArgs e)
        {
            if (TitlesGrid.SelectedRows.AnyRow() == false)
            {
                return;
            }

            var title = TitlesGrid.GetCurrentRowObject<WiiU.Title>();
            var cetck = new HexFile(WiiU.Cetk.BaseFile);
            cetck.Replace(WiiU.Cetk.CommonKey, title.Key);
            cetck.Save(WiiU.Cetk.FilePath);

            WarningLabel.Text = "cetk " + title + " Saved!";
        }
    }
}