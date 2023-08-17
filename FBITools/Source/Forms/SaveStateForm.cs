namespace FBITools
{
    public partial class SaveStateForm : GNX.Desktop.ContentBaseForm
    {
        public SaveStateForm()
        {
            InitializeComponent();
            SaveStateController.Init(this);
        }
    }
}