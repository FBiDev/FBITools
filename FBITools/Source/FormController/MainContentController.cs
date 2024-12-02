﻿using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core;
using App.Core.Desktop;
using System.Collections.Generic;

namespace FBITools
{
    public partial class MainContentController
    {
        #region Entrada
        public MainContentController(MainContentForm formView)
        {
            form = formView;
            form.Shown += form_Shown;
            form.KeyDown += form_KeyDown;
            form.KeyPreview = true;
        }

        private FlatButton SelectedTab { get; set; }

        void form_Shown(object sender, EventArgs ev)
        {
            btnTabFileCopy.Click += (s, e) => SetContent(s, Session.FileCopyForm);
            btnTabFileBackup.Click += (s, e) => SetContent(s, Session.FileBackupForm);
            btnTabImageResize.Click += (s, e) => SetContent(s, Session.ImageResizeForm);
            btnVbCsharp.Click += (s, e) => SetContent(s, Session.VbToCsharpForm);
            btnWiiUcetk.Click += (s, e) => SetContent(s, Session.WiiUcetkForm);

            btnTabConfig.Click += (s, e) => SetContent(s, Session.ConfigForm);

            btnTabFileCopy.PerformClick();

            if (SelectedTab != null)
            {
                SelectedTab.Focus();
            }
        }

        void form_KeyDown(object sender, KeyEventArgs e)
        {
            if (form.ActiveControl is FlatButton)
            {
                var ctl = form.ActiveControl as FlatButton;

                if (e.KeyData == Keys.Space)
                    Window.SendKey(Keys.Enter);

                if (e.KeyData == Keys.Enter)
                    ctl.PerformClick();
                return;
            }

            if (e.KeyData == Keys.Escape)
            {
                SelectedTab.Focus();
            }
        }

        void SetSelectedTab(FlatButton btnClicked)
        {
            if (SelectedTab != null && SelectedTab != btnClicked)
                SelectedTab.Selected = false;

            btnClicked.Selected = true;
            SelectedTab = btnClicked;
        }

        void ResizeContent(Size content)
        {
            if (MainBaseForm.AutoResizeWindow == false) return;

            var newW = content.Width + pnlContentL.Width + 30;
            var newH = content.Height + 26;

            if (Session.MainForm.StatusBarEnable)
                newH += 24;

            Session.MainForm.ClientSize = new Size(newW, newH);
        }
        #endregion

        #region Common
        void SetContent<T>(object sender, T contentForm) where T : ContentBaseForm, new()
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

            if (pnlContentRInside.Controls.Contains(contentForm))
            {
                contentForm.Focus();
                return;
            }

            contentForm.AutoScroll = false;
            SetSelectedTab(sender as FlatButton);

            pnlContentRInside.Controls.Clear();
            pnlContentRInside.Controls.Add(contentForm);
            ThemeBase.CheckTheme(contentForm);

            contentForm.Show();
            contentForm.Dock = DockStyle.Fill;
            contentForm.Focus();

            ResizeContent(contentForm.SizeOriginal);
            contentForm.AutoScroll = true;

            //Fix Resize Selection End
            foreach (var item in contentForm.GetControls<FlatMaskedTextBox>())
                item.SelectionStart = 0;
            foreach (var item in contentForm.GetControls<FlatTextBox>())
                item.SelectionStart = 0;

            CenterMainWindow(contentForm).TryAwait();
        }

        async Task CenterMainWindow<T>(T contentForm) where T : ContentBaseForm, new()
        {
            await Task.Delay(50);
            Session.MainForm.CenterWindow();
            await Task.Delay(50);

            contentForm.FinalLoadOnShow();
        }
        #endregion
    }
}