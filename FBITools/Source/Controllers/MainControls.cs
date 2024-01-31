using System.Windows.Forms;

namespace FBITools
{
    public partial class MainContentController
    {
        MainContentForm form
        {
            get { return Session.MainContentForm; }
            set { Session.MainContentForm = value; }
        }

        FlatPanelA pnlContentL { get { return form.pnlContentL; } }
        FlatPanelA pnlContentR { get { return form.pnlContentR; } }
        FlatPanelA pnlContentRInside { get { return form.pnlContentRInside; } }

        FlatButtonA btnTabSaveState { get { return form.btnTabSaveState; } }
        FlatButtonA btnTabMemoryCard { get { return form.btnTabMemoryCard; } }
        FlatButtonA btnTabConfig { get { return form.btnTabConfig; } }
    }

    public partial class ConfigController
    {
        ConfigForm form
        {
            get { return Session.ConfigForm; }
            set { Session.ConfigForm = value; }
        }

        FlatCheckBoxA chkDarkMode { get { return form.chkDarkMode; } }
        FlatCheckBoxA chkAutoCenterWindow { get { return form.chkAutoCenterWindow; } }
        FlatCheckBoxA chkAutoResizeWindow { get { return form.chkAutoResizeWindow; } }
        FlatCheckBoxA chkDebugMode { get { return form.chkDebugMode; } }
    }

    public partial class SaveStateController
    {
        SaveStateForm form
        {
            get { return Session.SaveStateForm; }
            set { Session.SaveStateForm = value; }
        }

        FlatButtonA btnOrigin { get { return form.btnOrigin; } }
        FlatTextBoxA txtOrigin { get { return form.txtOrigin; } }

        FlatButtonA btnDestination { get { return form.btnDestination; } }
        FlatTextBoxA txtDestination { get { return form.txtDestination; } }

        FlatCheckBoxA chkOverwrite { get { return form.chkOverwrite; } }
        FlatCheckBoxA chkBackup { get { return form.chkBackup; } }

        FlatButtonA btnCopy { get { return form.btnCopy; } }
        FlatLabelA lblWarning { get { return form.lblWarning; } }
    }

    public partial class MemoryCardController
    {
        MemoryCardForm form
        {
            get { return Session.MemoryCardForm; }
            set { Session.MemoryCardForm = value; }
        }

        FlatButtonA btnOrigin { get { return form.btnOrigin; } }
        FlatTextBoxA txtOrigin { get { return form.txtOrigin; } }
        FlatButtonA btnDestination { get { return form.btnDestination; } }
        FlatTextBoxA txtDestination { get { return form.txtDestination; } }
        FlatComboBoxA cboTimer { get { return form.cboTimer; } }

        FlatTableLayoutPanelA tblInput { get { return form.tblInput; } }
        FlatButtonA btnBackup { get { return form.btnBackup; } }
        FlatLabelA lblWarning { get { return form.lblWarning; } }

        OpenFileDialog dlgOrigin { get { return form.dlgOrigin; } }
        SaveFileDialog dlgDestination { get { return form.dlgDestination; } }
    }
}