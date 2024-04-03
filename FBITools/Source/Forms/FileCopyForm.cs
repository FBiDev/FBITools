namespace FBITools
{
    public partial class FileCopyForm : App.Core.Desktop.ContentBaseForm
    {
        public FileCopyForm()
        {
            InitializeComponent();
            var _ = new FileCopyController(this);
        }
    }
}