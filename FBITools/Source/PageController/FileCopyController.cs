using System;
using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public partial class FileCopyController
    {
        private FileBackup file;

        public FileCopyController(FileCopyForm page)
        {
            Page = page;
            Page.Load += Page_Load;
            Page.Shown += Page_Shown;
        }

        private void Page_Load(object sender, EventArgs e)
        {
            file = new FileBackup();

            CarregarCombos();

            LoadOptions();
        }

        private void Page_Shown(object sender, EventArgs ev)
        {
            WarningLabel.TextChanged += WarningLabel_TextChanged;

            OriginButton.Click += (s, e) =>
            {
                if (file.PickOrigin())
                {
                    UpdateOrigin();
                }
            };

            DestinationButton.Click += (s, e) =>
            {
                if (file.PickDestination())
                {
                    UpdateDestination();
                }
            };

            CustomDestinationCheckBox.CheckedChanged += (s, e) =>
            {
                file.CustomDestination = CustomDestinationCheckBox.Checked;
            };

            TypeComboBox.SelectedIndexChanged += (s, e) => UpdateType();

            CopyButton.Click += (s, e) =>
            {
                SaveOptions();

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
                WarningLabel.Text = file.SuccessMessage;
            };

            file.InvalidFile += () =>
            {
                WarningLabel.ForeColorType = LabelType.danger;
                WarningLabel.Text = file.ErrorMessage;
            };

            file.TimerRunningChanged += () =>
            {
                FormManager.EnableFormControls(!file.TimerIsRunning, InputTable);

                WarningLabel.ForeColorType = LabelType.primary;
                WarningLabel.Text = file.SuccessMessage;

                CopyButton.Text = file.ButtonMessage;
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

        private void LoadOptions()
        {
            if (Options.IsLoaded)
            {
                file.OriginPath = Session.Options.FileCopy_Origin;
                file.DestinationPath = Session.Options.FileCopy_Destination;
                file.CustomDestination = Session.Options.FileCopy_CustomDestination;
                CustomDestinationCheckBox.Checked = Session.Options.FileCopy_CustomDestination;

                TypeComboBox.SelectedValue = Session.Options.FileCopy_Type;
                file.TimerValue = Session.Options.FileCopy_Timer;
                TimerComboBox.SelectedValue = Session.Options.FileCopy_Timer;
            }

            UpdateOrigin();
            UpdateDestination();
            UpdateType();
        }

        private void UpdateOrigin()
        {
            OriginTextBox.Text = file.OriginPath;
            DestinationTextBox.Text = file.DestinationPath;
        }

        private void UpdateDestination()
        {
            DestinationTextBox.Text = file.DestinationPath;
        }

        private void UpdateType()
        {
            TimerComboBox.Enabled = file.IsTimer;
            CopyButton.Text = file.ButtonMessage;
        }

        private void SaveOptions()
        {
            Session.Options.FileCopy_Origin = file.OriginPath;
            Session.Options.FileCopy_Destination = file.DestinationPath;
            Session.Options.FileCopy_CustomDestination = file.CustomDestination;
            Session.Options.FileCopy_Type = TypeComboBox.SelectedValueInt;
            Session.Options.FileCopy_Timer = file.TimerValue;
        }
    }
}