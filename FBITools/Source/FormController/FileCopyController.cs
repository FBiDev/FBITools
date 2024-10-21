using System;
using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public partial class FileCopyController
    {
        FileBackup file;

        public FileCopyController(FileCopyForm formView)
        {
            form = formView;
            form.Shown += form_Shown;
        }

        void form_Shown(object sender, EventArgs ev)
        {
            lblWarning.TextChanged += lblWarning_TextChanged;

            file = new FileBackup
            {
                CustomName = true
            };

            CarregarCombos();

            if (Options.IsLoaded)
            {
                file.OriginPath = Session.Options.FileCopy_Origin;
                file.DestinationPath = Session.Options.FileCopy_Destination;
                file.TimerValue = Session.Options.FileCopy_Timer;

                cboType.SelectedValue = Session.Options.FileCopy_Type;
                cboTimer.SelectedValue = Session.Options.FileCopy_Timer;

                PreencherCampos();
            }

            btnOrigin.Click += (s, e) => { if (file.PickOrigin()) PreencherCampos(); };

            btnDestination.Click += (s, e) => { if (file.PickDestination()) PreencherCampos(); };

            cboType.SelectedIndexChanged += (s, e) => { PreencherCampos(); };

            cboTimer.SelectedIndexChanged += (s, e) => { PreencherCampos(); };

            btnCopy.Click += (s, e) =>
            {
                if (file.Copy())
                {
                    Session.Options.Update();
                    if (file.TimerIsRunning)
                    {
                        file.StartBackupTimer().TryAwait();
                    }
                }
            };

            file.Copied += () =>
            {
                lblWarning.ForeColorType = LabelType.success;
                lblWarning.Text = "File Copied!";
            };

            file.InvalidFile += () =>
            {
                lblWarning.ForeColorType = LabelType.danger;
                lblWarning.Text = "File Copy Failed!";
            };

            file.TimerRunningChanged += () =>
            {
                FormManager.EnableFormControls(!file.TimerIsRunning, tblInput);

                lblWarning.ForeColorType = LabelType.primary;

                if (file.TimerIsRunning)
                {
                    lblWarning.Text = "File Backup Started!";
                    btnCopy.Text = "Backup Stop";
                }
                else
                {
                    lblWarning.Text = "File Backup Stopped!";
                    btnCopy.Text = "Backup Start";
                }
            };
        }

        async void lblWarning_TextChanged(object sender, EventArgs e)
        {
            await TaskController.Delay(4);
            lblWarning.Text = "";
        }

        void CarregarCombos()
        {
            file.LoadTypes(cboType);
            file.LoadTimer(cboTimer);
        }

        void PreencherCampos()
        {
            txtOrigin.Text = file.OriginPath;
            txtDestination.Text = file.DestinationPath;

            Session.Options.FileCopy_Origin = file.OriginPath;
            Session.Options.FileCopy_Destination = file.DestinationPath;
            Session.Options.FileCopy_Type = cboType.SelectedValueInt;
            Session.Options.FileCopy_Timer = file.TimerValue;

            cboTimer.Enabled = cboType.SelectedValueInt == 2;
            if (cboTimer.Enabled)
                btnCopy.Text = "Backup Start";
            else
                btnCopy.Text = "Copy";
        }
    }
}