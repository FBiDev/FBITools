namespace FBITools
{
    public partial class SaveStateForm : GNX.Desktop.ContentBaseForm
    {
        public SaveStateForm()
        {
            InitializeComponent();
            var _ = new SaveStateController(this);
        }
    }
}