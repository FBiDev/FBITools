using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public partial class MainContentController
    {
        #region Entrada
        public MainContentController(MainContentForm formView)
        {
            Page = formView;
            Page.Shown += ShownForm;
            Page.KeyDown += Page_KeyDown;
            Page.KeyPreview = true;
        }

        private FlatButton SelectedTab { get; set; }

        private void ShownForm(object sender, EventArgs ev)
        {
            FileCopyTabButton.Click += (s, e) => SetContent(s, Session.FileCopyForm);
            FileBackupTabButton.Click += (s, e) => SetContent(s, Session.FileBackupForm);
            ImageResizeTabButton.Click += (s, e) => SetContent(s, Session.ImageResizeForm);
            VbCsharpTabButton.Click += (s, e) => SetContent(s, Session.VbToCsharpForm);
            WiiUcetkTabButton.Click += (s, e) => SetContent(s, Session.WiiUcetkForm);

            ConfigTabButton.Click += (s, e) => SetContent(s, Session.ConfigForm);

            FileCopyTabButton.PerformClick();

            if (SelectedTab != null)
            {
                SelectedTab.Focus();
            }
        }

        private void Page_KeyDown(object sender, KeyEventArgs e)
        {
            if (Page.ActiveControl is FlatButton)
            {
                var ctl = Page.ActiveControl as FlatButton;

                if (e.KeyData == Keys.Space)
                {
                    Window.SendKey(Keys.Enter);
                }

                if (e.KeyData == Keys.Enter)
                {
                    ctl.PerformClick();
                }

                return;
            }

            if (e.KeyData == Keys.Escape)
            {
                SelectedTab.Focus();
            }
        }

        private void SetSelectedTab(FlatButton btnClicked)
        {
            if (SelectedTab != null && SelectedTab != btnClicked)
            {
                SelectedTab.Selected = false;
            }

            btnClicked.Selected = true;
            SelectedTab = btnClicked;
        }

        private void ResizeContent(Size content)
        {
            if (MainBaseForm.AutoResizeWindow == false)
            {
                return;
            }

            var newW = content.Width + ContentLPanel.Width + 30;
            var newH = content.Height + 26;

            if (Session.MainForm.StatusBarEnable)
            {
                newH += 24;
            }

            Session.MainForm.ClientSize = new Size(newW, newH);
        }
        #endregion

        #region Common
        private void SetContent<T>(object sender, T contentForm) where T : ContentBaseForm, new()
        {
            if (contentForm == null || contentForm.IsDisposed)
            {
                try
                {
                    contentForm = new T();
                }
                catch (Exception ex)
                {
                    ExceptionManager.Resolve(ex, Environment.NewLine + "ShownForm : " + typeof(T).ToString());
                    return;
                }
            }

            if (ContentRInsidePanel.Controls.Contains(contentForm))
            {
                contentForm.Focus();
                return;
            }

            contentForm.AutoScroll = false;
            SetSelectedTab(sender as FlatButton);

            ContentRInsidePanel.Controls.Clear();
            ContentRInsidePanel.Controls.Add(contentForm);
            ThemeBase.CheckTheme(contentForm);

            contentForm.Show();
            contentForm.Dock = DockStyle.Fill;
            contentForm.Focus();

            ResizeContent(contentForm.SizeOriginal);
            contentForm.AutoScroll = true;

            // Fix Resize Selection End
            foreach (var item in contentForm.GetControls<FlatMaskedTextBox>())
            {
                item.SelectionStart = 0;
            }

            foreach (var item in contentForm.GetControls<FlatTextBox>())
            {
                item.SelectionStart = 0;
            }

            CenterMainWindow(contentForm).TryAwait();
        }

        private async Task CenterMainWindow<T>(T contentForm) where T : ContentBaseForm, new()
        {
            await Task.Delay(50);
            Session.MainForm.CenterWindow();
            await Task.Delay(50);

            contentForm.FinalLoadOnShow();
        }
        #endregion
    }
}