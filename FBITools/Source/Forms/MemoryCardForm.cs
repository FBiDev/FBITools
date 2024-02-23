namespace FBITools
{
    public partial class MemoryCardForm : App.Core.Desktop.ContentBaseForm
    {
        public MemoryCardForm()
        {
            InitializeComponent();
            var _ = new MemoryCardController(this);
        }
    }
}