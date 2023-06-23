namespace FBITools
{
    public partial class MainController
    {
        static MainForm form { get { return (MainForm)BIND.mainForm; } }

        static FlatPanelA pnlContentL { get { return form.pnlContentL; } }
        static FlatButtonA btnSaveStateTab { get { return form.btnSaveStateTab; } }
        static FlatButtonA btnMemoryCardTab { get { return form.btnMemoryCardTab; } }
    }
}