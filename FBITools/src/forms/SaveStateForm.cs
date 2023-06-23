using System.Windows.Forms;

namespace FBITools
{
    public partial class SaveStateForm : Form
    {
        public SaveStateForm()
        {
            InitializeComponent();
            SaveStateController.Init(this);
        }
    }
}