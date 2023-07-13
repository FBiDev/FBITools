using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using GNX;

namespace FBITools
{
    public partial class SaveStateController
    {
        public static void Init(Form formDesign)
        {
            Session.saveStateForm = formDesign;

            btnSaveStateOrigin.Click += btnSaveStateOrigin_Click;
            btnSaveSaveDestination.Click += btnSaveSaveState_Click;
            btnSaveStateCopy.Click += btnSaveStateCopy_Click;
            lblSaveStateCopy.TextChanged += lblSaveStateCopy_TextChanged;

            dlgSaveStateGet.ValidateNames = true;
            dlgSaveStateGet.CheckFileExists = true;
            dlgSaveStateGet.CheckPathExists = true;
            dlgSaveStateGet.FileName = "";

            dlgSaveStateSave.Filter = "All Files (*.*)|*.*";

            if (MainContentController.LoadConfigFile())
            {
                UpdateSaveStateOrigin();
                UpdateSaveStateDestination();
            }
        }

        static void btnSaveStateOrigin_Click(object sender, EventArgs e)
        {
            if (dlgSaveStateGet.ShowDialog() == DialogResult.OK)
            {
                Session.options.SaveState_Origin = dlgSaveStateGet.FileName.NormalizePath();
                UpdateSaveStateOrigin();
            }
        }

        static void btnSaveSaveState_Click(object sender, EventArgs e)
        {
            if (dlgSaveStateSave.ShowDialog() == DialogResult.OK)
            {
                Session.options.SaveState_Destination = dlgSaveStateSave.FileName.NormalizePath();
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
            MainContentController.UpdateConfigFile();
        }

        static async void lblSaveStateCopy_TextChanged(object sender, EventArgs e)
        {
            await Task.Delay(2000);
            lblSaveStateCopy.Text = "";
        }

        static void UpdateSaveStateOrigin()
        {
            txtSaveStateOrigin.Text = Session.options.SaveState_Origin;

            dlgSaveStateGet.InitialDirectory = Path.GetDirectoryName(Session.options.SaveState_Origin);
            dlgSaveStateGet.FileName = Path.GetFileName(Session.options.SaveState_Origin);

            if (string.IsNullOrWhiteSpace(dlgSaveStateSave.FileName))
                dlgSaveStateSave.FileName = Session.options.SaveState_Origin;
        }

        static void UpdateSaveStateDestination()
        {
            txtSaveStateDestination.Text = Session.options.SaveState_Destination;

            dlgSaveStateSave.InitialDirectory = Path.GetDirectoryName(Session.options.SaveState_Destination);
            dlgSaveStateSave.FileName = Path.GetFileName(Session.options.SaveState_Destination);
        }

        static bool IsSaveStateCopyInvalid()
        {
            return string.IsNullOrWhiteSpace(Session.options.SaveState_Origin)
            || string.IsNullOrWhiteSpace(Session.options.SaveState_Destination)
            || Session.options.SaveState_Origin == Session.options.SaveState_Destination;
        }

        static void CopySaveState()
        {
            File.Copy(Session.options.SaveState_Origin, Session.options.SaveState_Destination, true);
        }
    }
}