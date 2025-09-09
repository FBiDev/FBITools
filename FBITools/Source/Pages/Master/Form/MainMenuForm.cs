namespace FBITools
{
    public partial class MainMenuForm : App.Core.Desktop.ContentBaseForm
    {
        public MainMenuForm()
        {
            InitializeComponent();
            var _ = new MainMenuController(this);
        }
    }
}