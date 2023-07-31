namespace FBITools
{
    public partial class MainContentController
    {
        static MainContentForm form
        {
            get { return Session.mainContentForm; }
            set { Session.mainContentForm = value; }
        }

        static FlatPanelA pnlContentL { get { return form.pnlContentL; } }
        static FlatPanelA pnlContentR { get { return form.pnlContentR; } }
        static FlatButtonA btnSaveStateTab { get { return form.btnSaveStateTab; } }
        static FlatButtonA btnMemoryCardTab { get { return form.btnMemoryCardTab; } }
    }
}