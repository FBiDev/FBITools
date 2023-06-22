using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FBITools
{
    public partial class CopyStateForm : Form
    {
        public CopyStateForm()
        {
            InitializeComponent();
            TopLevel = false;

            lblSaveStateCopy.TextChanged += lblCopySaveState_TextChanged;

            dlgSaveStateGet.ValidateNames = true;
            dlgSaveStateGet.CheckFileExists = true;
            dlgSaveStateGet.CheckPathExists = true;
            dlgSaveStateGet.FileName = "";

            dlgSaveStateSave.Filter = "All Files (*.*)|*.*";

            if (MainCommon.LoadConfigFile())
            {
                UpdateSaveStateOrigin();
                UpdateSaveStateDestination();
            }
        }

        async void lblCopySaveState_TextChanged(object sender, EventArgs e)
        {
            await Task.Delay(2000);
            lblSaveStateCopy.Text = "";
        }

        void btnCopyStateFile_Click(object sender, EventArgs e)
        {
            if (dlgSaveStateGet.ShowDialog() == DialogResult.OK)
            {
                BIND.cfg.SaveState_Origin = dlgSaveStateGet.FileName;
                UpdateSaveStateOrigin();
            }
        }

        void btnSaveSaveState_Click(object sender, EventArgs e)
        {
            if (dlgSaveStateSave.ShowDialog() == DialogResult.OK)
            {
                BIND.cfg.SaveState_Destination = dlgSaveStateSave.FileName;
                UpdateSaveStateDestination();
            }
        }

        void btnCopySaveState_Click(object sender, EventArgs e)
        {
            if (IsSaveStateCopyInvalid())
            {
                lblSaveStateCopy.Text = "Save State Failed!";
                return;
            }

            CopySaveState();
            lblSaveStateCopy.Text = "Save State Copied!";
            MainCommon.UpdateConfigFile();
        }

        void UpdateSaveStateOrigin()
        {
            txtSaveStateOrigin.Text = BIND.cfg.SaveState_Origin;

            dlgSaveStateGet.InitialDirectory = Path.GetDirectoryName(BIND.cfg.SaveState_Origin);
            dlgSaveStateGet.FileName = Path.GetFileName(BIND.cfg.SaveState_Origin);

            if (string.IsNullOrWhiteSpace(dlgSaveStateSave.FileName))
                dlgSaveStateSave.FileName = BIND.cfg.SaveState_Origin;
        }

        void UpdateSaveStateDestination()
        {
            txtSaveStateDestination.Text = BIND.cfg.SaveState_Destination;

            dlgSaveStateSave.InitialDirectory = Path.GetDirectoryName(BIND.cfg.SaveState_Destination);
            dlgSaveStateSave.FileName = Path.GetFileName(BIND.cfg.SaveState_Destination);
        }

        bool IsSaveStateCopyInvalid()
        {
            return string.IsNullOrWhiteSpace(BIND.cfg.SaveState_Origin)
            || string.IsNullOrWhiteSpace(BIND.cfg.SaveState_Destination)
            || BIND.cfg.SaveState_Origin == BIND.cfg.SaveState_Destination;
        }

        void CopySaveState()
        {
            File.Copy(BIND.cfg.SaveState_Origin, BIND.cfg.SaveState_Destination, true);
        }
    }
}