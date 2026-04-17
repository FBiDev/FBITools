using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public partial class MainContentForm : ContentBaseForm
    {
        public MainContentForm()
        {
            InitializeComponent();

            Session.MainContentPage = this;

            Shown += Page_Shown;
            KeyDown += Page_KeyDown;
            KeyPreview = true;
        }

        private FlatButton SelectedTab { get; set; }

        internal void SetContent<T>(object sender, T contentForm) where T : ContentBaseForm, new()
        {
            if (contentForm == null || contentForm.IsDisposed)
            {
                try
                {
                    contentForm = new T();
                }
                catch (Exception ex)
                {
                    ExceptionManager.Resolve(ex, "Page : " + typeof(T).FullName);
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

            try
            {
                contentForm.Show();
            }
            catch (Exception ex)
            {
                ExceptionManager.Resolve(ex, "Page : " + typeof(T).FullName);
                return;
            }

            contentForm.Dock = DockStyle.Fill;
            contentForm.Focus();

            if (Session.Options.IsAutoResizeWindow)
            {
                var additionalSize = new Size(ContentLPanel.Width + 4, 0);
                Session.MainPage.ResizeWindow(contentForm.SizeOriginal, additionalSize);
            }

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

        private void SetMenu<T>(T menuForm) where T : ContentBaseForm, new()
        {
            if (menuForm == null || menuForm.IsDisposed)
            {
                try
                {
                    menuForm = new T();
                }
                catch (Exception ex)
                {
                    ExceptionManager.Resolve(ex, "Page : " + typeof(T).FullName);
                    return;
                }
            }

            if (ContentLInsidePanel.Controls.Contains(menuForm))
            {
                menuForm.Focus();
                return;
            }

            menuForm.AutoScroll = false;

            ContentLInsidePanel.Controls.Clear();
            ContentLInsidePanel.Controls.Add(menuForm);
            ThemeBase.CheckTheme(menuForm);

            try
            {
                menuForm.Show();
            }
            catch (Exception ex)
            {
                ExceptionManager.Resolve(ex, "Page : " + typeof(T).FullName);
                return;
            }

            menuForm.Dock = DockStyle.Fill;
            menuForm.Focus();
            menuForm.AutoScroll = true;
        }

        private void Page_Shown(object sender, EventArgs ev)
        {
            SetMenu(new MainMenuForm());

            if (SelectedTab != null)
            {
                SelectedTab.Focus();
            }
        }

        private void Page_KeyDown(object sender, KeyEventArgs e)
        {
            if (ActiveControl is FlatButton)
            {
                var ctl = ActiveControl as FlatButton;

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
            await Session.MainPage.CenterWindow();

            contentPage.FinalLoadOnShow();
        }
    }
}