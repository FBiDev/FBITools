using System.Windows.Forms;

namespace FBITools
{
    public partial class SaveStateController
    {
        static SaveStateForm form { get { return (SaveStateForm)BIND.saveStateForm; } }

        static FlatButtonA btnSaveStateOrigin { get { return form.btnSaveStateOrigin; } }
        static FlatTextBoxA txtSaveStateOrigin { get { return form.txtSaveStateOrigin; } }
        static FlatButtonA btnSaveSaveDestination { get { return form.btnSaveSaveDestination; } }
        static FlatTextBoxA txtSaveStateDestination { get { return form.txtSaveStateDestination; } }
        static FlatButtonA btnSaveStateCopy { get { return form.btnSaveStateCopy; } }
        static FlatLabelA lblSaveStateCopy { get { return form.lblSaveStateCopy; } }

        static OpenFileDialog dlgSaveStateGet { get { return form.dlgSaveStateGet; } }
        static SaveFileDialog dlgSaveStateSave { get { return form.dlgSaveStateSave; } }
    }
}