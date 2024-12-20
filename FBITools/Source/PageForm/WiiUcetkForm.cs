namespace FBITools.WiiU
{
    public partial class WiiUcetkForm : App.Core.Desktop.ContentBaseForm
    {
        public WiiUcetkForm()
        {
            InitializeComponent();
            var _ = new WiiUcetkController(this);
        }
    }
}