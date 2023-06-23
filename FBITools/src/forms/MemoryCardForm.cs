using System.Windows.Forms;

namespace FBITools
{
    public partial class MemoryCardForm : Form
    {
        public MemoryCardForm()
        {
            InitializeComponent();
            MemoryCardController.Init(this);
        }
    }
}