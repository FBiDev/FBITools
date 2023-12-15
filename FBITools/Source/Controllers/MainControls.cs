using System.Windows.Forms;

namespace FBITools
{
    public partial class MainContentController
    {
        static MainContentForm form
        {
            get { return Session.MainContentForm; }
            set { Session.MainContentForm = value; }
        }

        static FlatPanelA pnlContentL { get { return form.pnlContentL; } }
        static FlatPanelA pnlContentR { get { return form.pnlContentR; } }
        static FlatPanelA pnlContentRInside { get { return form.pnlContentRInside; } }

        static FlatButtonA btnTabSaveState { get { return form.btnTabSaveState; } }
        static FlatButtonA btnTabMemoryCard { get { return form.btnTabMemoryCard; } }
        static FlatButtonA btnTabConfig { get { return form.btnTabConfig; } }
    }

    public partial class ConfigController
    {
        static ConfigForm form
        {
            get { return Session.ConfigForm; }
            set { Session.ConfigForm = value; }
        }

        static FlatCheckBoxA chkDarkMode { get { return form.chkDarkMode; } }
        static FlatCheckBoxA chkDebugMode { get { return form.chkDebugMode; } }
    }

    public partial class SaveStateController
    {
        static SaveStateForm form
        {
            get { return Session.SaveStateForm; }
            set { Session.SaveStateForm = value; }
        }

        static FlatButtonA btnOrigin { get { return form.btnOrigin; } }
        static FlatTextBoxA txtOrigin { get { return form.txtOrigin; } }

        static FlatButtonA btnDestination { get { return form.btnDestination; } }
        static FlatTextBoxA txtDestination { get { return form.txtDestination; } }

        static FlatButtonA btnCopy { get { return form.btnCopy; } }
        static FlatLabelA lblWarning { get { return form.lblWarning; } }

        static OpenFileDialog dlgOrigin { get { return form.dlgOrigin; } }
        static SaveFileDialog dlgDestination { get { return form.dlgDestination; } }
    }

    public partial class MemoryCardController
    {
        static MemoryCardForm form
        {
            get { return Session.MemoryCardForm; }
            set { Session.MemoryCardForm = value; }
        }

        static FlatButtonA btnOrigin { get { return form.btnOrigin; } }
        static FlatTextBoxA txtOrigin { get { return form.txtOrigin; } }
        static FlatButtonA btnDestination { get { return form.btnDestination; } }
        static FlatTextBoxA txtDestination { get { return form.txtDestination; } }
        static FlatComboBoxA cboTimer { get { return form.cboTimer; } }

        static FlatTableLayoutPanelA tblInput { get { return form.tblInput; } }
        static FlatButtonA btnBackup { get { return form.btnBackup; } }
        static FlatLabelA lblWarning { get { return form.lblWarning; } }

        static OpenFileDialog dlgOrigin { get { return form.dlgOrigin; } }
        static SaveFileDialog dlgDestination { get { return form.dlgDestination; } }
    }
}