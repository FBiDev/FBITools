namespace FBITools
{
    public partial class MemoryCardForm : GNX.Desktop.ContentBaseForm
    {
        public MemoryCardForm()
        {
            InitializeComponent();
            MemoryCardController.Init(this);
        }
    }
}