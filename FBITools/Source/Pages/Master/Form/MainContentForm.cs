namespace FBITools
{
    public partial class MainContentForm : App.Core.Desktop.ContentBaseForm
    {
        public MainContentForm()
        {
            InitializeComponent();
            Session.MainContentController = new MainContentController(this);
        }
    }
}