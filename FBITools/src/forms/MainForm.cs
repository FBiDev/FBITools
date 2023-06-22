using GNX;

namespace FBITools
{
    public partial class MainForm : FormBase
    {
        public MainForm()
        {
            InitializeComponent();
            MainCommon.Main_Init(this);
        }
    }
}