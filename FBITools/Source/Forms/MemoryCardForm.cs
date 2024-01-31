namespace FBITools
{
    public partial class MemoryCardForm : GNX.Desktop.ContentBaseForm
    {
        public MemoryCardForm()
        {
            InitializeComponent();
            var _ = new MemoryCardController(this);
        }
    }
}