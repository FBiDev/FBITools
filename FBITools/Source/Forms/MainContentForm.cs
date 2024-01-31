namespace FBITools
{
    public partial class MainContentForm : GNX.Desktop.ContentBaseForm
    {
        public MainContentForm()
        {
            InitializeComponent();
            var _ = new MainContentController(this);
        }
    }
}