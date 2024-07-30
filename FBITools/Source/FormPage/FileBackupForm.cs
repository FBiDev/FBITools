namespace FBITools
{
    public partial class FileBackupForm : App.Core.Desktop.ContentBaseForm
    {
        public FileBackupForm()
        {
            InitializeComponent();
            var _ = new FileBackupController(this);
        }
    }
}