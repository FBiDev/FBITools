namespace FBITools
{
    public partial class MainContentForm : GNX.Desktop.ContentBaseForm
    {
        public MainContentForm()
        {
            InitializeComponent();
            MainContentController.Init(this);
        }
    }
}