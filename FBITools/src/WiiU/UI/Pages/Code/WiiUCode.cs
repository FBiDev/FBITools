using System;
using System.Threading.Tasks;
using App.Core;
using App.Core.Desktop;

namespace FBITools.WiiU
{
    public class WiiUCode : PageCode
    {
        private TitleService titleService;
        private RegionService regionService;
        private CategoryService categoryService;

        #region InitializeForm
        public WiiUCode()
        {
            Session.WiiUPage = this;

            base.UI = UI = new WiiUUI();
            UI.Shown += OnFormShown;
            UI.FinalLoadOnceAsync += InitializeControls;
            UI.GotFocus += (s, e) => UI.TitleIDTextBox.Focus();

            titleService = new TitleService();
            regionService = new RegionService();
            categoryService = new CategoryService();
        }

        public new WiiUUI UI { get; set; }

        private void OnFormShown(object sender, EventArgs ev)
        {
            RegisterShownEvents();
            BindStatusBar();
        }

        private void RegisterShownEvents()
        {
            UI.WarningLabel.TextChanged += ClearLabelText;
            UI.GenerateCetkButton.Click += OnGenerateCetkClicked;

            UI.TitleIDTextBox.TextChanged += UpdateFilterTitles;
            UI.TitleNameTextBox.TextChanged += UpdateFilterTitles;
        }

        private void BindStatusBar()
        {
            UI.TitlesGrid.Statusbar = UI.TitlesStatusBar;
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
            UI.RegionCheckedList.DataSource = await regionService.List();
            UI.RegionCheckedList.SetItemsChecked(true);

            UI.CategoryCheckedList.DataSource = await categoryService.List();
            UI.CategoryCheckedList.SetItemsChecked(true);
        }

        private void RegisterControlsEvents()
        {
            UI.RegionCheckedList.ItemCheck += UpdateFilterTitles;
            UI.CategoryCheckedList.ItemCheck += UpdateFilterTitles;
        }

        private void UpdateGrid(DataList<Title> list)
        {
            UI.TitlesGrid.DataSource = list;
            UI.GenerateCetkButton.Enabled = list.Count > 0;
        }

        private async Task FilterTitles()
        {
            await titleService.FilterTitles(
                UI.TitleIDTextBox.Text,
                UI.TitleNameTextBox.Text,
                region => UI.RegionCheckedList.IsItemChecked(region),
                category => UI.CategoryCheckedList.IsItemChecked(category));

            UpdateGrid(titleService.GetFilteredTitles());
        }
        #endregion

        #region UserEvents
        private async void ClearLabelText(object sender, EventArgs e)
        {
            var label = (FlatLabel)sender;
            await label.ClearTextAfterDelay(4);
        }

        private async void UpdateFilterTitles(object sender, EventArgs e)
        {
            await FilterTitles();
        }

        private void OnGenerateCetkClicked(object sender, EventArgs e)
        {
            if (UI.TitlesGrid.SelectedRows.AnyRow() == false)
            {
                return;
            }

            var currentTitle = UI.TitlesGrid.GetCurrentRowObject<Title>();

            if (titleService.GenerateCetk(currentTitle))
            {
                UI.WarningLabel.Text = "cetk " + currentTitle + " Saved!";
            }
            else
            {
                UI.WarningLabel.Text = "cetk " + currentTitle + " Failed!";
            }
        }
        #endregion
    }
}