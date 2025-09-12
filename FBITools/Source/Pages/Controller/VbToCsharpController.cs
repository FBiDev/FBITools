using System;
using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public partial class VbToCsharpController
    {
        private const string CopiedMessage = "Text Copied!";
        private const string ClearedMessage = "Text Cleared!";

        #region InitializeForm
        public VbToCsharpController(VbToCsharpForm page)
        {
            Page = page;
            Page.Shown += OnFormShown;
            Page.GotFocus += OnFormGotFocus;
        }

        private void OnFormShown(object sender, EventArgs ev)
        {
            RegisterShownEvents();
        }

        private void RegisterShownEvents()
        {
            WarningLabel.TextChanged += ClearLabelText;
            ConvertButton.Click += ConvertButton_Click;
            CopyResultButton.Click += OnCopyResult;
            ClearButton.Click += OnClear;
        }

        private void OnFormGotFocus(object sender, EventArgs e)
        {
            InputTextBox.Focus();
        }
        #endregion

        #region UserEvents
        private async void ClearLabelText(object sender, EventArgs e)
        {
            var label = (FlatLabel)sender;
            await label.ClearTextAfterDelay(4);
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (InputTextBox.Text.IsEmpty())
            {
                return;
            }

            InputTextBox.Focus();

            OutputTextBox.Text = VbToCsharpService.Convert(InputTextBox.Text);
        }

        private void OnCopyResult(object sender, EventArgs e)
        {
            if (OutputTextBox.Text.HasValue())
            {
                ClipboardSafe.SetText(OutputTextBox.Text);
                WarningLabel.Text = CopiedMessage;
                InputTextBox.Focus();
            }
        }

        private void OnClear(object sender, EventArgs e)
        {
            InputTextBox.Text = string.Empty;
            OutputTextBox.Text = string.Empty;
            WarningLabel.Text = ClearedMessage;
            InputTextBox.Focus();
        }
        #endregion
    }
}