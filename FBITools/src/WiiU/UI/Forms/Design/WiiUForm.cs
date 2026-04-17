using System;
using System.Threading.Tasks;
using App.Core.Desktop;

namespace FBITools.WiiU
{
    public partial class WiiUForm : ContentBaseForm
    {
        private TitleService titleService;
        private RegionService regionService;
        private CategoryService categoryService;

        #region InitializeForm
        public WiiUForm()
        {
            InitializeComponent();

            Session.WiiUPage = this;

            Shown += OnFormShown;
            FinalLoadOnceAsync += InitializeControls;
            GotFocus += (s, e) => TitleIDTextBox.Focus();

            titleService = new TitleService();
            regionService = new RegionService();
            categoryService = new CategoryService();
        }

        private void OnFormShown(object sender, EventArgs ev)
        {
            RegisterShownEvents();
            BindStatusBar();
        }

        private void RegisterShownEvents()
        {
            WarningLabel.TextChanged += ClearLabelText;
            GenerateCetkButton.Click += OnGenerateCetkClicked;

            TitleIDTextBox.TextChanged += UpdateFilterTitles;
            TitleNameTextBox.TextChanged += UpdateFilterTitles;
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
            RegionCheckedList.ItemCheck += UpdateFilterTitles;
            CategoryCheckedList.ItemCheck += UpdateFilterTitles;
        }

        private void UpdateGrid(DataList<Title> list)
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