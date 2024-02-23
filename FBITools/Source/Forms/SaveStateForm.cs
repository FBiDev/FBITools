namespace FBITools
{
    public partial class SaveStateForm : App.Core.Desktop.ContentBaseForm
    {
        public SaveStateForm()
        {
            InitializeComponent();
            var _ = new SaveStateController(this);
        }
    }
}