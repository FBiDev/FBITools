using System;
using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public class VbToCsharpCode : PageCode
    {
        private const string CopiedMessage = "Text Copied!";
        private const string ClearedMessage = "Text Cleared!";

        #region InitializeForm
        public VbToCsharpCode()
        {
            Session.VbToCsharpPage = this;

            base.UI = UI = new VbToCsharpUI();
            UI.Shown += OnFormShown;
            UI.GotFocus += OnFormGotFocus;
        }

        public new VbToCsharpUI UI { get; set; }

        private void OnFormShown(object sender, EventArgs ev)
        {
            RegisterShownEvents();
        }

        private void RegisterShownEvents()
        {
            UI.WarningLabel.TextChanged += ClearLabelText;
            UI.ConvertButton.Click += ConvertButton_Click;
            UI.CopyResultButton.Click += OnCopyResult;
            UI.ClearButton.Click += OnClear;
        }

        private void OnFormGotFocus(object sender, EventArgs e)
        {
            UI.InputTextBox.Focus();
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
            if (UI.InputTextBox.Text.IsEmpty())
            {
                return;
            }

            UI.InputTextBox.Focus();

            UI.OutputTextBox.Text = VbToCsharpController.Convert(UI.InputTextBox.Text);
        }

        private void OnCopyResult(object sender, EventArgs e)
        {
            if (UI.OutputTextBox.Text.HasValue())
            {
                ClipboardSafe.SetText(UI.OutputTextBox.Text);
                UI.WarningLabel.Text = CopiedMessage;
                UI.InputTextBox.Focus();
            }
        }

        private void OnClear(object sender, EventArgs e)
        {
            UI.InputTextBox.Text = string.Empty;
            UI.OutputTextBox.Text = string.Empty;
            UI.WarningLabel.Text = ClearedMessage;
            UI.InputTextBox.Focus();
        }
        #endregion
    }
}