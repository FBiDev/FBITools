using System;
using System.IO;
using System.Windows.Forms;
using GNX;

namespace FBITools
{
    public partial class SaveStateController
    {
        public static void Init(SaveStateForm formView)
        {
            form = formView;

            btnOrigin.Click += btnOrigin_Click;
            btnDestination.Click += btnDestination_Click;
            btnCopy.Click += btnCopy_Click;
            lblWarning.TextChanged += lblResult_TextChanged;

            dlgOrigin.ValidateNames = true;
            dlgOrigin.CheckFileExists = true;
            dlgOrigin.CheckPathExists = true;
            dlgOrigin.FileName = "";

            dlgDestination.Filter = "All Files (*.*)|*.*";

            if (Options.Loaded)
            {
                UpdateOrigin();
                UpdateDestination();
            }
        }

        static void btnOrigin_Click(object sender, EventArgs e)
        {
            if (dlgOrigin.ShowDialog() == DialogResult.OK)
            {
                Session.Options.SaveState_Origin = dlgOrigin.FileName.NormalizePath();
                UpdateOrigin();

                if (Session.Options.SaveState_Destination == null) return;

                Session.Options.SaveState_Destination = (Path.Combine(Path.GetDirectoryName(txtDestination.Text),
                                                                      dlgOrigin.FileName)).NormalizePath();
                UpdateDestination();
            }
        }

        static void UpdateOrigin()
        {
            txtOrigin.Text = Session.Options.SaveState_Origin;

            dlgOrigin.InitialDirectory = Path.GetDirectoryName(Session.Options.SaveState_Origin);
            dlgOrigin.FileName = Path.GetFileName(Session.Options.SaveState_Origin);

            if (string.IsNullOrWhiteSpace(dlgDestination.FileName))
                dlgDestination.FileName = dlgOrigin.FileName;
        }

        static void btnDestination_Click(object sender, EventArgs e)
        {
            if (dlgDestination.ShowDialog() == DialogResult.OK)
            {
                Session.Options.SaveState_Destination = dlgDestination.FileName.NormalizePath();
                UpdateDestination();
            }
        }

        static void UpdateDestination()
        {
            txtDestination.Text = Session.Options.SaveState_Destination;

            dlgDestination.InitialDirectory = Path.GetDirectoryName(Session.Options.SaveState_Destination);
            dlgDestination.FileName = Path.GetFileName(Session.Options.SaveState_Destination);
        }

        static void btnCopy_Click(object sender, EventArgs e)
        {
            if (IsCopyInvalid())
            {
                lblWarning.Text = "Save State Copy Failed!";
                return;
            }

            CopySaveState();
            lblWarning.Text = "Save State Copied!";
            Session.UpdateOptions();
        }

        static bool IsCopyInvalid()
        {
            return string.IsNullOrWhiteSpace(Session.Options.SaveState_Origin)
            || string.IsNullOrWhiteSpace(Session.Options.SaveState_Destination)
            || Session.Options.SaveState_Origin == Session.Options.SaveState_Destination;
        }

        static void CopySaveState()
        {
            File.Copy(Session.Options.SaveState_Origin, Session.Options.SaveState_Destination, true);
        }

        static async void lblResult_TextChanged(object sender, EventArgs e)
        {
            await TaskController.Delay(4);
            lblWarning.Text = "";
        }
    }
}