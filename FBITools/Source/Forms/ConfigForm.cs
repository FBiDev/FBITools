namespace FBITools
{
    public partial class ConfigForm : GNX.Desktop.ContentBaseForm
    {
        public ConfigForm()
        {
            InitializeComponent();
            var _ = new ConfigController(this);
        }
    }
}