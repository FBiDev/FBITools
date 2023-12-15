namespace FBITools
{
    public partial class ConfigForm : GNX.Desktop.ContentBaseForm
    {
        public ConfigForm()
        {
            InitializeComponent();
            ConfigController.Init(this);
        }
    }
}