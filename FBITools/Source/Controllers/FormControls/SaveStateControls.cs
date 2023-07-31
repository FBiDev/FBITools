using System.Windows.Forms;

namespace FBITools
{
    public partial class SaveStateController
    {
        static SaveStateForm form
        {
            get { return Session.saveStateForm; }
            set { Session.saveStateForm = value; }
        }

        static FlatButtonA btnOrigin { get { return form.btnOrigin; } }
        static FlatTextBoxA txtOrigin { get { return form.txtOrigin; } }

        static FlatButtonA btnDestination { get { return form.btnDestination; } }
        static FlatTextBoxA txtDestination { get { return form.txtDestination; } }

        static FlatButtonA btnCopy { get { return form.btnCopy; } }
        static FlatLabelA lblResult { get { return form.lblResult; } }

        static OpenFileDialog dlgOrigin { get { return form.dlgOrigin; } }
        static SaveFileDialog dlgDestination { get { return form.dlgDestination; } }
    }
}