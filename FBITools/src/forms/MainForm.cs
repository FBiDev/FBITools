using GNX;

namespace FBITools
{
    public partial class MainForm : FormBase
    {
        public MainForm()
        {
            InitializeComponent();
            MainController.Init(this);
        }
    }
}