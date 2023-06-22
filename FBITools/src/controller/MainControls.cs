namespace FBITools
{
    public partial class MainCommon
    {
        static MainForm form { get { return (MainForm)BIND.form; } }

        //Main
        static FlatPanelA pnlContentL { get { return form.pnlContentL; } }
        static FlatButtonA btnCopyState { get { return form.btnSaveStateTab; } }
        static FlatButtonA btnSaveMemoryCard { get { return form.btnMemoryCardTab; } }


    }
}