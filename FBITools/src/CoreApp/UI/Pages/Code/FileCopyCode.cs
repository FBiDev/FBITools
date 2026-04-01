using System;
using App.Core.Desktop;

namespace FBITools
{
    public class FileCopyCode : PageCode
    {
        private readonly FileCopyController controller;

        public FileCopyCode()
        {
            Session.FileCopyPage = this;

            base.UI = UI = new FileCopyUI();
            UI.Load += OnFormLoad;
            UI.Shown += OnFormShown;

            controller = new FileCopyController();
        }

        public new FileCopyUI UI { get; set; }

        private void OnFormLoad(object sender, EventArgs e)
        {
            controller.LoadOptions();
            controller.LoadComboBoxData(UI.TypeComboBox, UI.TimerComboBox);
            InitializeControls();
        }

        private void InitializeControls()
        {
            UI.OriginTextBox.Text = controller.OriginPath;
            UI.DestinationTextBox.Text = controller.DestinationPath;
            UI.CustomDestinationCheckBox.Checked = Session.Options.FileCopy_CustomDestination;
            UI.TypeComboBox.SelectedValue = Session.Options.FileCopy_Type;
            UI.TimerComboBox.SelectedValue = Session.Options.FileCopy_Timer;
            UpdateType();
        }

        private void OnFormShown(object sender, EventArgs e)
        {
            UI.WarningLabel.TextChanged += ClearLabelText;

            UI.OriginButton.Click += OriginButton_Click;
            UI.DestinationButton.Click += DestinationButton_Click;
            UI.CustomDestinationCheckBox.CheckedChanged += CustomDestinationCheckBox_CheckedChanged;
            UI.TypeComboBox.SelectedIndexChanged += TypeComboBox_SelectedIndexChanged;
            UI.CopyButton.Click += CopyButton_Click;

            controller.StatusChanged += Service_StatusChanged;
            controller.TimerStateChanged += Service_TimerStateChanged;
        }

        private async void ClearLabelText(object sender, EventArgs e)
        {
            var label = (FlatLabel)sender;
            await label.ClearTextAfterDelay(4);
        }

        private void OriginButton_Click(object sender, EventArgs e)
        {
            if (controller.PickOrigin())
            {
                UpdateOrigin();
            }
        }

        private void DestinationButton_Click(object sender, EventArgs e)
        {
            if (controller.PickDestination())
            {
                UpdateDestination();
            }
        }

        private void CustomDestinationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            controller.SetCustomDestination(UI.CustomDestinationCheckBox.Checked);
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            controller.SetType(UI.TypeComboBox.SelectedValueInt);
            UpdateType();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            controller.SaveOptions();

            if (controller.Copy())
            {
                UpdateType();
            }
        }

        private void UpdateOrigin()
        {
            UI.OriginTextBox.Text = controller.OriginPath;
            UI.DestinationTextBox.Text = controller.DestinationPath;
        }

        private void UpdateDestination()
        {
            UI.DestinationTextBox.Text = controller.DestinationPath;
        }

        private void UpdateType()
        {
            UI.TimerComboBox.Enabled = controller.IsTimer;
            UI.CopyButton.Text = controller.ButtonMessage;
        }

        private void Service_StatusChanged(string message, LabelType type)
        {
            UI.WarningLabel.ForeColorType = type;
            UI.WarningLabel.Text = message;
        }

        private void Service_TimerStateChanged(bool isRunning, string buttonText)
        {
            FormManager.EnableFormControls(!isRunning, UI.InputTable);
            UI.CopyButton.Text = buttonText;
        }
    }
}