using System;
using System.Threading.Tasks;
using App.Core;
using App.Core.Desktop;

namespace FBITools.WiiU
{
    public partial class WiiUController
    {
        private TitleService titleService;
        private RegionService regionService;
        private CategoryService categoryService;

        #region InitializeForm
        public WiiUController(WiiUForm page)
        {
            titleService = new TitleService();
            regionService = new RegionService();
            categoryService = new CategoryService();

            Page = page;
            Page.Shown += OnFormShown;
            Page.FinalLoadOnceAsync += InitializeControls;
            Page.GotFocus += (s, e) => TitleIDTextBox.Focus();
        }

        private void OnFormShown(object sender, EventArgs ev)
        {
            RegisterShownEvents();
            BindStatusBar();
        }

        private void RegisterShownEvents()
        {
            WarningLabel.TextChanged += async (s, e) => await ClearWarningLabel(s, e);
            GenerateCetkButton.Click += OnGenerateCetkClicked;

            TitleIDTextBox.TextChanged += (s, e) => FilterTitles().TryAwait();
            TitleNameTextBox.TextChanged += (s, e) => FilterTitles().TryAwait();
        }

        private void BindStatusBar()
        {
            TitlesGrid.Statusbar = TitlesStatusBar;
        }
        #endregion

        #region InitializeControls
        private async Task InitializeControls()
        {
            await LoadControls();
            RegisterControlsEvents();
            await FilterTitles();
        }

        private async Task LoadControls()
        {
            RegionCheckedList.DataSource = await regionService.List();
            RegionCheckedList.SetItemsChecked(true);

            CategoryCheckedList.DataSource = await categoryService.List();
            CategoryCheckedList.SetItemsChecked(true);
        }

        private void RegisterControlsEvents()
        {
            RegionCheckedList.ItemCheck += (s, e) => FilterTitles().TryAwait();
            CategoryCheckedList.ItemCheck += (s, e) => FilterTitles().TryAwait();
        }

        private void UpdateGrid(ListBind<Title> list)
        {
            TitlesGrid.DataSource = list;
            GenerateCetkButton.Enabled = list.Count > 0;
        }

        private async Task FilterTitles()
        {
            await titleService.FilterTitles(
                TitleIDTextBox.Text,
                TitleNameTextBox.Text,
                region => RegionCheckedList.IsItemChecked(region),
                category => CategoryCheckedList.IsItemChecked(category));

            UpdateGrid(titleService.GetFilteredTitles());
        }
        #endregion

        #region UserEvents
        private async Task ClearWarningLabel(object sender, EventArgs e)
        {
            await TaskController.Delay(4);
            WarningLabel.Text = string.Empty;
        }

        private void OnGenerateCetkClicked(object sender, EventArgs e)
        {
            if (TitlesGrid.SelectedRows.AnyRow() == false)
            {
                return;
            }

            var currentTitle = TitlesGrid.GetCurrentRowObject<Title>();

            if (titleService.GenerateCetk(currentTitle))
            {
                WarningLabel.Text = "cetk " + currentTitle + " Saved!";
            }
            else
            {
                WarningLabel.Text = "cetk " + currentTitle + " Failed!";
            }
        }
        #endregion
    }
}