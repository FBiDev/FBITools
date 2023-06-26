namespace FBITools
{
    public partial class MainForm : GNX.MainBaseForm
    {
        public MainForm()
        {
            InitializeComponent();
            MainController.Init(this);
        }
    }
}