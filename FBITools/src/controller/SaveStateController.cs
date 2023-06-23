using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBITools
{
    public partial class SaveStateController
    {
        public static void Init(Form formDesign)
        {
            BIND.saveStateForm = formDesign;
            form.TopLevel = false;
            //form.Init(form);
            //form.StatusBar = false;

            btnSaveStateOrigin.Click += btnSaveStateOrigin_Click;
            btnSaveSaveDestination.Click += btnSaveSaveState_Click;
            btnSaveStateCopy.Click += btnSaveStateCopy_Click;
            lblSaveStateCopy.TextChanged += lblSaveStateCopy_TextChanged;

            dlgSaveStateGet.ValidateNames = true;
            dlgSaveStateGet.CheckFileExists = true;
            dlgSaveStateGet.CheckPathExists = true;
            dlgSaveStateGet.FileName = "";

            dlgSaveStateSave.Filter = "All Files (*.*)|*.*";

            if (MainController.LoadConfigFile())
            {
                UpdateSaveStateOrigin();
                UpdateSaveStateDestination();
            }
        }

        static void btnSaveStateOrigin_Click(object sender, EventArgs e)
        {
            if (dlgSaveStateGet.ShowDialog() == DialogResult.OK)
            {
                BIND.cfg.SaveState_Origin = dlgSaveStateGet.FileName;
                UpdateSaveStateOrigin();
            }
        }

        static void btnSaveSaveState_Click(object sender, EventArgs e)
        {
            if (dlgSaveStateSave.ShowDialog() == DialogResult.OK)
            {
                BIND.cfg.SaveState_Destination = dlgSaveStateSave.FileName;
                UpdateSaveStateDestination();
            }
        }

        static void btnSaveStateCopy_Click(object sender, EventArgs e)
        {
            if (IsSaveStateCopyInvalid())
            {
                lblSaveStateCopy.Text = "Save State Failed!";
                return;
            }

            CopySaveState();
            lblSaveStateCopy.Text = "Save State Copied!";
            MainController.UpdateConfigFile();
        }

        static async void lblSaveStateCopy_TextChanged(object sender, EventArgs e)
        {
            await Task.Delay(2000);
            lblSaveStateCopy.Text = "";
        }

        static void UpdateSaveStateOrigin()
        {
            txtSaveStateOrigin.Text = BIND.cfg.SaveState_Origin;

            dlgSaveStateGet.InitialDirectory = Path.GetDirectoryName(BIND.cfg.SaveState_Origin);
            dlgSaveStateGet.FileName = Path.GetFileName(BIND.cfg.SaveState_Origin);

            if (string.IsNullOrWhiteSpace(dlgSaveStateSave.FileName))
                dlgSaveStateSave.FileName = BIND.cfg.SaveState_Origin;
        }

        static void UpdateSaveStateDestination()
        {
            txtSaveStateDestination.Text = BIND.cfg.SaveState_Destination;

            dlgSaveStateSave.InitialDirectory = Path.GetDirectoryName(BIND.cfg.SaveState_Destination);
            dlgSaveStateSave.FileName = Path.GetFileName(BIND.cfg.SaveState_Destination);
        }

        static bool IsSaveStateCopyInvalid()
        {
            return string.IsNullOrWhiteSpace(BIND.cfg.SaveState_Origin)
            || string.IsNullOrWhiteSpace(BIND.cfg.SaveState_Destination)
            || BIND.cfg.SaveState_Origin == BIND.cfg.SaveState_Destination;
        }

        static void CopySaveState()
        {
            File.Copy(BIND.cfg.SaveState_Origin, BIND.cfg.SaveState_Destination, true);
        }
    }
}