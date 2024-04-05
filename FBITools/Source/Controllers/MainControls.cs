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

        FlatButtonA btnTabFileCopy { get { return form.btnTabFileCopy; } }
        FlatButtonA btnTabFileBackup { get { return form.btnTabFileBackup; } }
        FlatButtonA btnTabImageResize { get { return form.btnTabImageResize; } }
        FlatButtonA btnVbCsharp { get { return form.btnVbCsharp; } }
        FlatButtonA btnWiiUcetk { get { return form.btnWiiUcetk; } }
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

    public partial class FileCopyController
    {
        FileCopyForm form
        {
            get { return Session.FileCopyForm; }
            set { Session.FileCopyForm = value; }
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

    public partial class FileBackupController
    {
        FileBackupForm form
        {
            get { return Session.FileBackupForm; }
            set { Session.FileBackupForm = value; }
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

    public partial class VbToCsharpController
    {
        VbToCsharpForm form
        {
            get { return Session.VbToCsharpForm; }
            set { Session.VbToCsharpForm = value; }
        }

        FlatLabelA lblWarning { get { return form.lblWarning; } }

        FlatTextBoxA txtInput { get { return form.txtInput; } }

        FlatButtonA btnConvert { get { return form.btnConvert; } }
        FlatButtonA btnCopyResult { get { return form.btnCopyResult; } }
        FlatButtonA btnClear { get { return form.btnClear; } }

        FlatTextBoxA txtOutput { get { return form.txtOutput; } }
    }

    public partial class WiiUcetkController
    {
        WiiUcetkForm form
        {
            get { return Session.WiiUcetkForm; }
            set { Session.WiiUcetkForm = value; }
        }

        FlatLabelA lblWarning { get { return form.lblWarning; } }

        FlatMaskedTextBoxA txtTitleID { get { return form.txtTitleID; } }
        FlatTextBoxA txtTitleName { get { return form.txtTitleName; } }

        FlatButtonA btnGenerateCetk { get { return form.btnGenerateCetk; } }

        FlatLabelA lblTitlesTotal { get { return form.lblTitlesTotal; } }
        FlatDataGridA dgvTitles { get { return form.dgvTitles; } }
    }
}