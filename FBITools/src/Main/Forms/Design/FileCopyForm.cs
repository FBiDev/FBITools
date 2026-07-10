using System;
using App.Core.Desktop;

namespace FBITools
{
    public partial class FileCopyForm : ContentBaseForm
    {
        #region InitializeForm
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

        private void OnFormShown(object sender, EventArgs e)
        {
            WarningLabel.TextChanged += ClearLabelText;

            OriginButton.Click += OnOriginButtonClick;
            DestinationButton.Click += OnDestinationButtonClick;
            CustomDestinationCheckBox.CheckedChanged += OnCustomDestinationCheckBoxChanged;
            TypeComboBox.SelectedIndexChanged += OnTypeComboBoxSelectedIndexChanged;
            CopyButton.Click += OnCopyButtonClick;

            _controller.StatusChanged += OnControllerStatusChanged;
            _controller.TimerStateChanged += OnControllerTimerStateChanged;
        }
        #endregion

        #region InitializeControls
        private void InitializeControls()
        {
            OriginTextBox.Text = _controller.OriginPath;
            DestinationTextBox.Text = _controller.DestinationPath;
            CustomDestinationCheckBox.Checked = Session.Options.FileCopyCustomDestination;
            TypeComboBox.SelectedValue = Session.Options.FileCopyType;
            TimerComboBox.SelectedValue = Session.Options.FileCopyTimer;
            UpdateType();
        }
        #endregion

        #region UserEvents
        private static async void ClearLabelText(object sender, EventArgs e)
        {
            var label = (FlatLabel)sender;
            await label.ClearTextAfterDelay(4);
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

        private void OnOriginButtonClick(object sender, EventArgs e)
        {
            if (_controller.PickOrigin())
            {
                UpdateOrigin();
            }
        }

        private void OnDestinationButtonClick(object sender, EventArgs e)
        {
            if (_controller.PickDestination())
            {
                UpdateDestination();
            }
        }

        private void OnCustomDestinationCheckBoxChanged(object sender, EventArgs e)
        {
            _controller.SetCustomDestination(CustomDestinationCheckBox.Checked);
        }

        private void OnTypeComboBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            _controller.SetType(TypeComboBox.SelectedValueInt);
            UpdateType();
        }

        private void OnCopyButtonClick(object sender, EventArgs e)
        {
            _controller.SaveOptions();

            if (_controller.Copy())
            {
                UpdateType();
            }
        }

        private void OnControllerStatusChanged(LabelType type, string message)
        {
            WarningLabel.ForeColorType = type;
            WarningLabel.Text = message;
        }

        private void OnControllerTimerStateChanged(bool isRunning, string buttonText)
        {
            FormManager.EnableFormControls(!isRunning, InputTable);
            CopyButton.Text = buttonText;
        }
        #endregion
    }
}