using System;
using App.Core.Desktop;

namespace FBITools
{
    public partial class FileCopyForm : ContentBaseForm
    {
        private readonly FileCopyController _controller;

        public FileCopyForm()
        {
            InitializeComponent();

            Session.FileCopyPage = this;

            Load += OnFormLoad;
            Shown += OnFormShown;

            _controller = new FileCopyController();
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            _controller.LoadOptions();
            _controller.LoadComboBoxData(TypeComboBox, TimerComboBox);
            InitializeControls();
        }

        private void InitializeControls()
        {
            OriginTextBox.Text = _controller.OriginPath;
            DestinationTextBox.Text = _controller.DestinationPath;
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

            _controller.StatusChanged += Service_StatusChanged;
            _controller.TimerStateChanged += Service_TimerStateChanged;
        }

        private async void ClearLabelText(object sender, EventArgs e)
        {
            var label = (FlatLabel)sender;
            await label.ClearTextAfterDelay(4);
        }

        private void OriginButton_Click(object sender, EventArgs e)
        {
            if (_controller.PickOrigin())
            {
                UpdateOrigin();
            }
        }

        private void DestinationButton_Click(object sender, EventArgs e)
        {
            if (_controller.PickDestination())
            {
                UpdateDestination();
            }
        }

        private void CustomDestinationCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _controller.SetCustomDestination(CustomDestinationCheckBox.Checked);
        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.SetType(TypeComboBox.SelectedValueInt);
            UpdateType();
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            _controller.SaveOptions();

            if (_controller.Copy())
            {
                UpdateType();
            }
        }

        private void UpdateOrigin()
        {
            OriginTextBox.Text = _controller.OriginPath;
            DestinationTextBox.Text = _controller.DestinationPath;
        }

        private void UpdateDestination()
        {
            DestinationTextBox.Text = _controller.DestinationPath;
        }

        private void UpdateType()
        {
            TimerComboBox.Enabled = _controller.IsTimer;
            CopyButton.Text = _controller.ButtonMessage;
        }

        private void Service_StatusChanged(LabelType type, string message)
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