using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public partial class MainContentController
    {
        public MainContentController(MainContentForm page)
        {
            Page = page;
            Page.Shown += Page_Shown;
            Page.KeyDown += Page_KeyDown;
            Page.KeyPreview = true;
        }

        private FlatButton SelectedTab { get; set; }

        internal void SetContent<T>(object sender, T contentPage) where T : ContentBaseForm, new()
        {
            if (contentPage == null || contentPage.IsDisposed)
            {
                try
                {
                    contentPage = new T();
                }
                catch (Exception ex)
                {
                    ExceptionManager.Resolve(ex, "Page : " + typeof(T).FullName);
                    return;
                }
            }

            if (ContentRInsidePanel.Controls.Contains(contentPage))
            {
                contentPage.Focus();
                return;
            }

            contentPage.AutoScroll = false;
            SetSelectedTab(sender as FlatButton);

            ContentRInsidePanel.Controls.Clear();
            ContentRInsidePanel.Controls.Add(contentPage);
            ThemeBase.CheckTheme(contentPage);

            try
            {
                contentPage.Show();
            }
            catch (Exception ex)
            {
                ExceptionManager.Resolve(ex, "Page : " + typeof(T).FullName);
                return;
            }

            contentPage.Dock = DockStyle.Fill;
            contentPage.Focus();

            var newSize = new Size(ContentLPanel.Width + 4, 0);
            Session.MainPage.ResizeWindow(contentPage.SizeOriginal, newSize);
            contentPage.AutoScroll = true;

            // Fix Resize Selection End
            foreach (var item in contentPage.GetControls<FlatMaskedTextBox>())
            {
                item.SelectionStart = 0;
            }

            foreach (var item in contentPage.GetControls<FlatTextBox>())
            {
                item.SelectionStart = 0;
            }

            CenterMainWindow(contentPage).TryAwait();
        }

        private void SetMenu<T>(object sender, T contentPage) where T : ContentBaseForm, new()
        {
            if (contentPage == null || contentPage.IsDisposed)
            {
                try
                {
                    contentPage = new T();
                }
                catch (Exception ex)
                {
                    ExceptionManager.Resolve(ex, "Page : " + typeof(T).FullName);
                    return;
                }
            }

            if (ContentLInsidePanel.Controls.Contains(contentPage))
            {
                contentPage.Focus();
                return;
            }

            contentPage.AutoScroll = false;

            ContentLInsidePanel.Controls.Clear();
            ContentLInsidePanel.Controls.Add(contentPage);
            ThemeBase.CheckTheme(contentPage);

            try
            {
                contentPage.Show();
            }
            catch (Exception ex)
            {
                ExceptionManager.Resolve(ex, "Page : " + typeof(T).FullName);
                return;
            }

            contentPage.Dock = DockStyle.Fill;
            contentPage.Focus();
            contentPage.AutoScroll = true;
        }

        private void Page_Shown(object sender, EventArgs ev)
        {
            SetMenu(sender, new MainMenuForm());

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

        private void SetSelectedTab(FlatButton clickedButton)
        {
            if (SelectedTab != null && SelectedTab != clickedButton)
            {
                SelectedTab.Selected = false;
            }

            clickedButton.Selected = true;
            SelectedTab = clickedButton;
        }

        private void ResizeContent(Size contentSize)
        {
            if (Session.Options.IsAutoResizeWindow == false)
            {
                return;
            }

            var newW = contentSize.Width + ContentLPanel.Width + 30;
            var newH = contentSize.Height + 26;

            if (Session.MainPage.StatusBarEnable)
            {
                newH += 24;
            }

            Session.MainPage.ClientSize = new Size(newW, newH);
        }

        private async Task CenterMainWindow<T>(T contentPage) where T : ContentBaseForm, new()
        {
            await Session.MainPage.CenterWindow();

            contentPage.FinalLoadOnShow();
        }
    }
}