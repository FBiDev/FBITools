namespace FBITools
{
    public partial class MainContentForm : GNX.ContentBaseForm
    {
        public MainContentForm()
        {
            InitializeComponent();
            MainContentController.Init(this);
        }
    }
}