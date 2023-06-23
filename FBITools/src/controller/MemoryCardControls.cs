using System.Windows.Forms;

namespace FBITools
{
    public partial class MemoryCardController
    {
        static MemoryCardForm form { get { return (MemoryCardForm)BIND.memoryCardForm; } }

        static FlatPanelA pnlMcOrigin { get { return form.pnlMcOrigin; } }
        static FlatPanelA pnlMcDestination { get { return form.pnlMcDestination; } }
        static FlatPanelA pnlMcTimer { get { return form.pnlMcTimer; } }

        static FlatButtonA btnMcOrigin { get { return form.btnMcOrigin; } }
        static FlatTextBoxA txtMcOrigin { get { return form.txtMcOrigin; } }

        static FlatButtonA btnMcDestination { get { return form.btnMcDestination; } }
        static FlatTextBoxA txtMcDestination { get { return form.txtMcDestination; } }

        static FlatComboBoxA cboMcTimer { get { return form.cboMcTimer; } }

        static FlatButtonA btnMcBackup { get { return form.btnMcBackup; } }
        static FlatLabelA lblMcBackup { get { return form.lblMcBackup; } }

        static OpenFileDialog dlgMcOrigin { get { return form.dlgMcOrigin; } }
        static SaveFileDialog dlgMcDestination { get { return form.dlgMcDestination; } }
    }
}