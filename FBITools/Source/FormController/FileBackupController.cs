using System;
using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public partial class FileBackupController
    {
        FileBackup file;

        public FileBackupController(FileBackupForm formView)
        {
            form = formView;
            form.Shown += form_Shown;
        }

        void form_Shown(object sender, EventArgs ev)
        {
            lblWarning.TextChanged += lblWarning_TextChanged;

            file = new FileBackup
            {
                CustomName = true,
                Timer = true
            };

            CarregarCombos();

            if (Options.IsLoaded)
            {
                file.OriginPath = Session.Options.FileBackup_Origin;
                file.DestinationPath = Session.Options.FileBackup_Destination;
                file.TimerValue = Session.Options.FileBackup_Timer;

                cboTimer.SelectedValue = Session.Options.FileBackup_Timer;

                PreencherCampos();
            }

            btnOrigin.Click += (s, e) => { if (file.PickOrigin()) PreencherCampos(); };

            btnDestination.Click += (s, e) => { if (file.PickDestination()) PreencherCampos(); };

            cboTimer.SelectedIndexChanged += (s, e) => { PreencherCampos(); };

            btnBackup.Click += (s, e) =>
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
                lblWarning.Text = "File Backup Failed!";
            };

            file.TimerRunningChanged += () =>
            {
                FormManager.EnableFormControls(!file.TimerIsRunning, tblInput);

                lblWarning.ForeColorType = LabelType.primary;

                if (file.TimerIsRunning)
                {
                    lblWarning.Text = "File Backup Started!";
                    btnBackup.Text = "Backup Stop";
                }
                else
                {
                    lblWarning.Text = "File Backup Stopped!";
                    btnBackup.Text = "Backup Start";
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
            file.LoadTimer(cboTimer);
        }

        void PreencherCampos()
        {
            txtOrigin.Text = file.OriginPath;
            txtDestination.Text = file.DestinationPath;

            Session.Options.FileBackup_Origin = file.OriginPath;
            Session.Options.FileBackup_Destination = file.DestinationPath;
            Session.Options.FileBackup_Timer = file.TimerValue;

            if (cboTimer.Enabled)
                btnBackup.Text = "Backup Start";
            else
                btnBackup.Text = "Copy";
        }
    }
}