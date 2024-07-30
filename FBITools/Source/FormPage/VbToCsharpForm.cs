namespace FBITools
{
    public partial class VbToCsharpForm : App.Core.Desktop.ContentBaseForm
    {
        public VbToCsharpForm()
        {
            InitializeComponent();
            var _ = new VbToCsharpController(this);
        }
    }
}