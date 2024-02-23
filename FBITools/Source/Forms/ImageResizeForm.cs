namespace FBITools
{
    public partial class ImageResizeForm : App.Core.Desktop.ContentBaseForm
    {
        public ImageResizeForm()
        {
            InitializeComponent();
            var _ = new ImageResizeController(this);
        }
    }
}