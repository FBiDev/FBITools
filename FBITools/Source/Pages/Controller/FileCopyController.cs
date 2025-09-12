using System;
using App.Core.Desktop;

namespace FBITools
{
    public partial class FileCopyController
    {
        private readonly FileCopyService service;

        public FileCopyController(FileCopyForm page)
        {
            service = new FileCopyService();

            Page = page;
            Page.Load += OnFormLoad;
            Page.Shown += OnFormShown;
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            service.LoadOptions();
            service.LoadComboBoxData(TypeComboBox, TimerComboBox);
            InitializeControls();
        }

        private void InitializeControls()
        {
            OriginTextBox.Text = service.OriginPath;
            DestinationTextBox.Text = service.DestinationPath;
            CustomDestinationCheckBox.Checked = Session.Options.FileCopy_CustomDestination;
            TypeComboBox.SelectedValue = Session.Options.FileCopy_Type;
            TimerComboBox.SelectedValue = Session.Options.FileCopy_Timer;
            UpdateType();
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            WarningLabel.TextChanged += ClearLabelText;

            OriginButton.Click += OriginButton_Click;
            DestinationButton.Click += DestinationButton_Click;
            CustomDestinationCheckBox.CheckedChanged += CustomDestinationCheckBox_CheckedChanged;
            TypeComboBox.SelectedIndexChanged += TypeComboBox_SelectedIndexChanged;
            CopyButton.Click += CopyButton_Click;

            service.StatusChanged += Service_StatusChanged;
            service.TimerStateChanged += Service_TimerStateChanged;
        }

        private async void ClearLabelText(object sender, EventArgs e)
        {
            var label = (FlatLabel)sender;
            await label.ClearTextAfterDelay(4);
        }

        private void OriginButton_Click(object sender, EventArgs e)
        {
            if (service.PickOrigin())
            {
                UpdateOrigin();
            }
        }

        private void DestinationButton_Click(object sender, EventArgs e)
        {
            if (service.PickDestination())
            {
                UpdateDestination();
            }
        }

        private void CustomDestinationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            service.SetCustomDestination(CustomDestinationCheckBox.Checked);
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            service.SetType(TypeComboBox.SelectedValueInt);
            UpdateType();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            service.SaveOptions();

            if (service.Copy())
            {
                UpdateType();
            }
        }

        private void UpdateOrigin()
        {
            OriginTextBox.Text = service.OriginPath;
            DestinationTextBox.Text = service.DestinationPath;
        }

        private void UpdateDestination()
        {
            DestinationTextBox.Text = service.DestinationPath;
        }

        private void UpdateType()
        {
            TimerComboBox.Enabled = service.IsTimer;
            CopyButton.Text = service.ButtonMessage;
        }

        private void Service_StatusChanged(string message, LabelType type)
        {
            WarningLabel.ForeColorType = type;
            WarningLabel.Text = message;
        }

        private void Service_TimerStateChanged(bool isRunning, string buttonText)
        {
            FormManager.EnableFormControls(!isRunning, InputTable);
            CopyButton.Text = buttonText;
        }
    }
}