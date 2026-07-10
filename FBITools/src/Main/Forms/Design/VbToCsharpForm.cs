using System;
using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public partial class VbToCsharpForm : ContentBaseForm
    {
        #region InitializeForm
        private readonly VbToCsharpController _controller;

        public VbToCsharpForm()
        {
            InitializeComponent();

            Session.VbToCsharpPage = this;

            Shown += OnFormShown;
            GotFocus += OnFormGotFocus;

            _controller = new VbToCsharpController();
        }

        private void OnFormShown(object sender, EventArgs ev)
        {
            RegisterShownEvents();
        }

        private void RegisterShownEvents()
        {
            WarningLabel.TextChanged += ClearLabelText;
            ConvertButton.Click += OnConvertButtonClick;
            CopyResultButton.Click += OnCopyResult;
            ClearButton.Click += OnClear;
        }

        private void OnFormGotFocus(object sender, EventArgs e)
        {
            InputTextBox.Focus();
        }
        #endregion

        #region UserEvents
        private static async void ClearLabelText(object sender, EventArgs e)
        {
            var label = (FlatLabel)sender;
            await label.ClearTextAfterDelay(4);
        }

        private void OnConvertButtonClick(object sender, EventArgs e)
        {
            if (InputTextBox.Text.IsEmpty())
            {
                return;
            }

            InputTextBox.Focus();

            OutputTextBox.Text = _controller.Convert(InputTextBox.Text);
        }

        private void OnCopyResult(object sender, EventArgs e)
        {
            if (OutputTextBox.Text.IsEmpty())
            {
                return;
            }

            ClipboardSafe.SetText(OutputTextBox.Text);
            WarningLabel.Text = _controller.CopiedMessage;
            InputTextBox.Focus();
        }

        private void OnClear(object sender, EventArgs e)
        {
            InputTextBox.Text = string.Empty;
            OutputTextBox.Text = string.Empty;
            WarningLabel.Text = _controller.ClearedMessage;
            InputTextBox.Focus();
        }
        #endregion
    }
}