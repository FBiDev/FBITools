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
            lblResult.TextChanged += lblResult_TextChanged;

            dlgOrigin.ValidateNames = true;
            dlgOrigin.CheckFileExists = true;
            dlgOrigin.CheckPathExists = true;
            dlgOrigin.FileName = "";

            dlgDestination.Filter = "All Files (*.*)|*.*";

            if (MainController.ConfigLoaded)
            {
                UpdateOrigin();
                UpdateDestination();
            }
        }

        static void btnOrigin_Click(object sender, EventArgs e)
        {
            if (dlgOrigin.ShowDialog() == DialogResult.OK)
            {
                Session.options.SaveState_Origin = dlgOrigin.FileName.NormalizePath();
                UpdateOrigin();

                if (Session.options.SaveState_Destination == null) return;

                Session.options.SaveState_Destination = (Path.Combine(Path.GetDirectoryName(txtDestination.Text),
                                                                      dlgOrigin.FileName)).NormalizePath();
                UpdateDestination();
            }
        }

        static void UpdateOrigin()
        {
            txtOrigin.Text = Session.options.SaveState_Origin;

            dlgOrigin.InitialDirectory = Path.GetDirectoryName(Session.options.SaveState_Origin);
            dlgOrigin.FileName = Path.GetFileName(Session.options.SaveState_Origin);

            if (string.IsNullOrWhiteSpace(dlgDestination.FileName))
                dlgDestination.FileName = Session.options.SaveState_Origin;
        }

        static void btnDestination_Click(object sender, EventArgs e)
        {
            if (dlgDestination.ShowDialog() == DialogResult.OK)
            {
                Session.options.SaveState_Destination = dlgDestination.FileName.NormalizePath();
                UpdateDestination();
            }
        }

        static void UpdateDestination()
        {
            txtDestination.Text = Session.options.SaveState_Destination;

            dlgDestination.InitialDirectory = Path.GetDirectoryName(Session.options.SaveState_Destination);
            dlgDestination.FileName = Path.GetFileName(Session.options.SaveState_Destination);
        }

        static void btnCopy_Click(object sender, EventArgs e)
        {
            if (IsCopyInvalid())
            {
                lblResult.Text = "Save State Copy Failed!";
                return;
            }

            CopySaveState();
            lblResult.Text = "Save State Copied!";
            MainController.UpdateConfigFile();
        }

        static bool IsCopyInvalid()
        {
            return string.IsNullOrWhiteSpace(Session.options.SaveState_Origin)
            || string.IsNullOrWhiteSpace(Session.options.SaveState_Destination)
            || Session.options.SaveState_Origin == Session.options.SaveState_Destination;
        }

        static void CopySaveState()
        {
            File.Copy(Session.options.SaveState_Origin, Session.options.SaveState_Destination, true);
        }

        static async void lblResult_TextChanged(object sender, EventArgs e)
        {
            await TaskController.Delay(4);
            lblResult.Text = "";
        }
    }
}