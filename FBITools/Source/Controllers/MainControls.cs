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
        FlatButtonA btnTabImageResize { get { return form.btnTabImageResize; } }
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

        FlatTableLayoutPanelA tblInput { get { return form.tblInput; } }
        FlatLabelA lblWarning { get { return form.lblWarning; } }

        FlatButtonA btnOrigin { get { return form.btnOrigin; } }
        FlatTextBoxA txtOrigin { get { return form.txtOrigin; } }

        FlatButtonA btnDestination { get { return form.btnDestination; } }
        FlatTextBoxA txtDestination { get { return form.txtDestination; } }

        FlatComboBoxA cboType { get { return form.cboType; } }
        FlatComboBoxA cboTimer { get { return form.cboTimer; } }

        FlatButtonA btnCopy { get { return form.btnCopy; } }
    }

    public partial class MemoryCardController
    {
        MemoryCardForm form
        {
            get { return Session.MemoryCardForm; }
            set { Session.MemoryCardForm = value; }
        }

        FlatTableLayoutPanelA tblInput { get { return form.tblInput; } }
        FlatLabelA lblWarning { get { return form.lblWarning; } }

        FlatButtonA btnOrigin { get { return form.btnOrigin; } }
        FlatTextBoxA txtOrigin { get { return form.txtOrigin; } }
        FlatButtonA btnDestination { get { return form.btnDestination; } }
        FlatTextBoxA txtDestination { get { return form.txtDestination; } }
        FlatComboBoxA cboTimer { get { return form.cboTimer; } }

        FlatButtonA btnBackup { get { return form.btnBackup; } }
    }

    public partial class ImageResizeController
    {
        ImageResizeForm form
        {
            get { return Session.ImageResizeForm; }
            set { Session.ImageResizeForm = value; }
        }

        FlatTableLayoutPanelA tblInput { get { return form.tblInput; } }
        FlatLabelA lblWarning { get { return form.lblWarning; } }

        FlatButtonA btnOrigin { get { return form.btnOrigin; } }
        FlatTextBoxA txtOrigin { get { return form.txtOrigin; } }
        FlatButtonA btnDestination { get { return form.btnDestination; } }
        FlatTextBoxA txtDestination { get { return form.txtDestination; } }

        FlatComboBoxA cboEncoder { get { return form.cboEncoder; } }
        FlatComboBoxA cboResizeMode { get { return form.cboResizeMode; } }
        FlatComboBoxA cboSizes { get { return form.cboSizes; } }

        FlatComboBoxA cboAnchor { get { return form.cboAnchor; } }
        FlatComboBoxA cboInterpolation { get { return form.cboInterpolation; } }

        FlatComboBoxA cboMatteColor { get { return form.cboMatteColor; } }
        FlatComboBoxA cboColorProfile { get { return form.cboColorProfile; } }

        FlatComboBoxA cboSharpen { get { return form.cboSharpen; } }
        FlatComboBoxA cboBlendingMode { get { return form.cboBlendingMode; } }
        FlatComboBoxA cboHybridMode { get { return form.cboHybridMode; } }

        FlatComboBoxA cboPngFilter { get { return form.cboPngFilter; } }
        FlatComboBoxA cboPngInterlace { get { return form.cboPngInterlace; } }

        FlatComboBoxA cboJpgQuality { get { return form.cboJpgQuality; } }
        FlatComboBoxA cboJpgChromaSubsample { get { return form.cboJpgChromaSubsample; } }

        FlatButtonA btnResize { get { return form.btnResize; } }
        FlatPictureBoxA picDrop { get { return form.picDrop; } }
        FlatPictureBoxA picResized { get { return form.picResized; } }
    }
}