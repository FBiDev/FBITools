namespace FBITools
{
    public partial class MemoryCardForm : GNX.ContentBaseForm
    {
        public MemoryCardForm()
        {
            InitializeComponent();
            MemoryCardController.Init(this);
        }
    }
}