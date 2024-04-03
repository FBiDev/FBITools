using System;
using System.Windows.Forms;
using App.Core;

namespace FBITools
{
    public partial class VbToCsharpController
    {
        public VbToCsharpController(VbToCsharpForm formView)
        {
            form = formView;
            form.Shown += form_Shown;
            form.GotFocus += (s, e) => txtInput.Focus();
        }

        void form_Shown(object sender, EventArgs ev)
        {
            lblWarning.TextChanged += lblWarning_TextChanged;

            btnClear.Click += (s, e) =>
            {
                txtInput.Text = txtOutput.Text = string.Empty;
                txtInput.Focus();
                lblWarning.Text = "Text Cleared!";
            };

            btnCopyResult.Click += (s, e) =>
            {
                if (txtOutput.Text.Length > 0)
                {
                    txtInput.Focus();
                    Clipboard.SetText(txtOutput.Text);
                    lblWarning.Text = "Text Copied!";
                }
            };

            btnConvert.Click += btnConvert_Click;
        }

        async void lblWarning_TextChanged(object sender, EventArgs e)
        {
            await TaskController.Delay(4);
            lblWarning.Text = "";
        }

        void btnConvert_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Length == 0) return;
            txtInput.Focus();

            txtOutput.Text = VbToCsharp.Convert(txtInput.Text);
        }
    }
}