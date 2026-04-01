using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public partial class MainContentCode
    {
        public MainContentCode()
        {
            Session.MainContentPage = this;

            UI = new MainContentUI();
            UI.Shown += Page_Shown;
            UI.KeyDown += Page_KeyDown;
            UI.KeyPreview = true;
        }

        public MainContentUI UI { get; set; }

        private FlatButton SelectedTab { get; set; }

        internal void SetContent<T>(object sender, T codePage) where T : PageCode, new()
        {
            if (codePage == null || codePage.UI.IsDisposed)
            {
                try
                {
                    codePage = new T();
                }
                catch (Exception ex)
                {
                    ExceptionManager.Resolve(ex, "Page : " + typeof(T).FullName);
                    return;
                }
            }

            if (UI.ContentRInsidePanel.Controls.Contains(codePage.UI))
            {
                codePage.UI.Focus();
                return;
            }

            codePage.UI.AutoScroll = false;
            SetSelectedTab(sender as FlatButton);

            UI.ContentRInsidePanel.Controls.Clear();
            UI.ContentRInsidePanel.Controls.Add(codePage.UI);
            ThemeBase.CheckTheme(codePage.UI);

            try
            {
                codePage.UI.Show();
            }
            catch (Exception ex)
            {
                ExceptionManager.Resolve(ex, "Page : " + typeof(T).FullName);
                return;
            }

            codePage.UI.Dock = DockStyle.Fill;
            codePage.UI.Focus();

            if (Session.Options.IsAutoResizeWindow)
            {
                var additionalSize = new Size(UI.ContentLPanel.Width + 4, 0);
                Session.MainPage.UI.ResizeWindow(codePage.UI.SizeOriginal, additionalSize);
            }

            codePage.UI.AutoScroll = true;

            // Fix Resize Selection End
            foreach (var item in codePage.UI.GetControls<FlatMaskedTextBox>())
            {
                item.SelectionStart = 0;
            }

            foreach (var item in codePage.UI.GetControls<FlatTextBox>())
            {
                item.SelectionStart = 0;
            }

            CenterMainWindow(codePage.UI).TryAwait();
        }

        private void SetMenu<T>(T contentPage) where T : ContentBaseForm, new()
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

            if (UI.ContentLInsidePanel.Controls.Contains(contentPage))
            {
                contentPage.Focus();
                return;
            }

            contentPage.AutoScroll = false;

            UI.ContentLInsidePanel.Controls.Clear();
            UI.ContentLInsidePanel.Controls.Add(contentPage);
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
            SetMenu(new MainMenuCode().UI);

            if (SelectedTab != null)
            {
                SelectedTab.Focus();
            }
        }

        private void Page_KeyDown(object sender, KeyEventArgs e)
        {
            if (UI.ActiveControl is FlatButton)
            {
                var ctl = UI.ActiveControl as FlatButton;

                if (e.KeyData == Keys.Space)
                {
                    Native.Window.SendKey(Keys.Enter);
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

        private async Task CenterMainWindow<T>(T contentPage) where T : ContentBaseForm, new()
        {
            await Session.MainPage.UI.CenterWindow();

            contentPage.FinalLoadOnShow();
        }
    }
}