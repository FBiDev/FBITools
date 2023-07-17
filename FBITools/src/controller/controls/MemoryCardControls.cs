using System.Windows.Forms;

namespace FBITools
{
    public partial class MemoryCardController
    {
        static MemoryCardForm form { get { return (MemoryCardForm)Session.memoryCardForm; } }

        static FlatPanelA pnlOrigin { get { return form.pnlOrigin; } }
        static FlatButtonA btnOrigin { get { return form.btnOrigin; } }
        static FlatTextBoxA txtOrigin { get { return form.txtOrigin; } }

        static FlatPanelA pnlDestination { get { return form.pnlDestination; } }
        static FlatButtonA btnDestination { get { return form.btnDestination; } }
        static FlatTextBoxA txtDestination { get { return form.txtDestination; } }

        static FlatPanelA pnlTimer { get { return form.pnlTimer; } }
        static FlatComboBoxA cboTimer { get { return form.cboTimer; } }

        static FlatButtonA btnBackup { get { return form.btnBackup; } }
        static FlatLabelA lblResult { get { return form.lblResult; } }

        static OpenFileDialog dlgOrigin { get { return form.dlgOrigin; } }
        static SaveFileDialog dlgDestination { get { return form.dlgDestination; } }
    }
}