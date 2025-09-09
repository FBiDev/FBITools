namespace FBITools.WiiU
{
    public partial class WiiUForm : App.Core.Desktop.ContentBaseForm
    {
        public WiiUForm()
        {
            InitializeComponent();
            var _ = new WiiUController(this);
        }
    }
}