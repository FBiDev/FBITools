using System;
using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public partial class FileBackupController
    {
        private FileBackup file;

        public FileBackupController(FileBackupForm pageForm)
        {
            Page = pageForm;
            Page.Shown += ShownForm;
        }

        private void ShownForm(object sender, EventArgs ev)
        {
            WarningLabel.TextChanged += WarningLabel_TextChanged;

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

                TimerComboBox.SelectedValue = Session.Options.FileBackup_Timer;

                PreencherCampos();
            }

            OriginButton.Click += (s, e) =>
            {
                if (file.PickOrigin())
                {
                    PreencherCampos();
                }
            };

            DestinationButton.Click += (s, e) =>
            {
                if (file.PickDestination())
                {
                    PreencherCampos();
                }
            };

            TimerComboBox.SelectedIndexChanged += (s, e) => { PreencherCampos(); };

            BackupButton.Click += (s, e) =>
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
                WarningLabel.ForeColorType = LabelType.success;
                WarningLabel.Text = "File Copied!";
            };

            file.InvalidFile += () =>
            {
                WarningLabel.ForeColorType = LabelType.danger;
                WarningLabel.Text = "File Backup Failed!";
            };

            file.TimerRunningChanged += () =>
            {
                FormManager.EnableFormControls(!file.TimerIsRunning, InputTable);

                WarningLabel.ForeColorType = LabelType.primary;

                if (file.TimerIsRunning)
                {
                    WarningLabel.Text = "File Backup Started!";
                    BackupButton.Text = "Backup Stop";
                }
                else
                {
                    WarningLabel.Text = "File Backup Stopped!";
                    BackupButton.Text = "Backup Start";
                }
            };
        }

        private async void WarningLabel_TextChanged(object sender, EventArgs e)
        {
            await TaskController.Delay(4);
            WarningLabel.Text = string.Empty;
        }

        private void CarregarCombos()
        {
            file.LoadTimer(TimerComboBox);
        }

        private void PreencherCampos()
        {
            OriginTextBox.Text = file.OriginPath;
            DestinationTextBox.Text = file.DestinationPath;

            Session.Options.FileBackup_Origin = file.OriginPath;
            Session.Options.FileBackup_Destination = file.DestinationPath;
            Session.Options.FileBackup_Timer = file.TimerValue;

            BackupButton.Text = TimerComboBox.Enabled ? "Backup Start" : "Copy";
        }
    }
}