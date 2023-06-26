namespace FBITools
{
    public partial class MainContentController
    {
        static MainContentForm form { get { return (MainContentForm)BIND.mainContentForm; } }

        static FlatPanelA pnlContentL { get { return form.pnlContentR; } }
        static FlatButtonA btnSaveStateTab { get { return form.btnSaveStateTab; } }
        static FlatButtonA btnMemoryCardTab { get { return form.btnMemoryCardTab; } }
    }
}