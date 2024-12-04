using System;
using System.Windows.Forms;
using App.Core;

namespace FBITools
{
    public partial class VbToCsharpController
    {
        public VbToCsharpController(VbToCsharpForm pageForm)
        {
            Page = pageForm;
            Page.Shown += ShownForm;
            Page.GotFocus += (s, e) => InputTextBox.Focus();
        }

        private void ShownForm(object sender, EventArgs ev)
        {
            WarningLabel.TextChanged += WarningLabel_TextChanged;

            ClearButton.Click += (s, e) =>
            {
                InputTextBox.Text = OutputTextBox.Text = string.Empty;
                InputTextBox.Focus();
                WarningLabel.Text = "Text Cleared!";
            };

            CopyResultButton.Click += (s, e) =>
            {
                if (OutputTextBox.Text.Length > 0)
                {
                    InputTextBox.Focus();
                    Clipboard.SetText(OutputTextBox.Text);
                    WarningLabel.Text = "Text Copied!";
                }
            };

            ConvertButton.Click += ConvertButton_Click;
        }

        private async void WarningLabel_TextChanged(object sender, EventArgs e)
        {
            await TaskController.Delay(4);
            WarningLabel.Text = string.Empty;
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (InputTextBox.Text.Length == 0)
            {
                return;
            }

            InputTextBox.Focus();

            OutputTextBox.Text = VbToCsharp.Convert(InputTextBox.Text);
        }
    }
}