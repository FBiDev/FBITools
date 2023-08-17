namespace FBITools
{
    public partial class MainForm : GNX.Desktop.MainBaseForm
    {
        public MainForm()
        {
            InitializeComponent();
            MainController.Init(this);
        }
    }
}