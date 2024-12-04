using System;
using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public partial class FileCopyController
    {
        private FileBackup file;

        public FileCopyController(FileCopyForm formView)
        {
            Page = formView;
            Page.Shown += ShownForm;
        }

        private void ShownForm(object sender, EventArgs ev)
        {
            WarningLabel.TextChanged += WarningLabel_TextChanged;

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

                TypeComboBox.SelectedValue = Session.Options.FileCopy_Type;
                TimerComboBox.SelectedValue = Session.Options.FileCopy_Timer;

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

            TypeComboBox.SelectedIndexChanged += (s, e) => { PreencherCampos(); };

            TimerComboBox.SelectedIndexChanged += (s, e) => { PreencherCampos(); };

            CopyButton.Click += (s, e) =>
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
                WarningLabel.Text = "File Copy Failed!";
            };

            file.TimerRunningChanged += () =>
            {
                FormManager.EnableFormControls(!file.TimerIsRunning, InputTable);

                WarningLabel.ForeColorType = LabelType.primary;

                if (file.TimerIsRunning)
                {
                    WarningLabel.Text = "File Backup Started!";
                    CopyButton.Text = "Backup Stop";
                }
                else
                {
                    WarningLabel.Text = "File Backup Stopped!";
                    CopyButton.Text = "Backup Start";
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
            file.LoadTypes(TypeComboBox);
            file.LoadTimer(TimerComboBox);
        }

        private void PreencherCampos()
        {
            OriginTextBox.Text = file.OriginPath;
            DestinationTextBox.Text = file.DestinationPath;

            Session.Options.FileCopy_Origin = file.OriginPath;
            Session.Options.FileCopy_Destination = file.DestinationPath;
            Session.Options.FileCopy_Type = TypeComboBox.SelectedValueInt;
            Session.Options.FileCopy_Timer = file.TimerValue;

            TimerComboBox.Enabled = TypeComboBox.SelectedValueInt == 2;

            CopyButton.Text = TimerComboBox.Enabled ? "Backup Start" : "Copy";
        }
    }
}