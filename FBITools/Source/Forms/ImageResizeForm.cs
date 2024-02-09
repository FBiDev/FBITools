namespace FBITools
{
    public partial class ImageResizeForm : GNX.Desktop.ContentBaseForm
    {
        public ImageResizeForm()
        {
            InitializeComponent();
            var _ = new ImageResizeController(this);
        }
    }
}