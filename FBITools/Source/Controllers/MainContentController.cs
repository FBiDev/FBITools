using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using GNX.Desktop;

namespace FBITools
{
    public partial class MainContentController
    {
        #region Entrada
        public static FlatButtonA selectedTab;

        public static void Init(MainContentForm formView)
        {
            form = formView;

            form.Load += form_Load;
            form.Shown += form_Shown;

            btnTabSaveState.Click += (s, e) => SetContent(Session.SaveStateForm, btnTabSaveState);
            btnTabMemoryCard.Click += (s, e) => SetContent(Session.MemoryCardForm, btnTabMemoryCard);

            btnTabConfig.Click += (s, e) => SetContent(Session.ConfigForm, btnTabConfig);
        }

        static void form_Load(object sender, EventArgs e) { }

        static void form_Shown(object sender, EventArgs e)
        {
            btnTabSaveState.PerformClick();
        }

        static void SetSelectedTab(FlatButtonA btnClicked)
        {
            if (selectedTab != null && selectedTab != btnClicked)
                selectedTab.Selected = false;

            btnClicked.Selected = true;
            selectedTab = btnClicked;
        }

        static void ResizeContent(Size content)
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
        static void SetContent<T>(T contentForm, FlatButtonA selectTab) where T : ContentBaseForm, new()
        {
            if (contentForm == null) contentForm = new T();
            if (pnlContentRInside.Controls.Contains(contentForm)) return;

            contentForm.AutoScroll = false;
            SetSelectedTab(selectTab);

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

        static async Task CenterMainWindow<T>(T contentForm) where T : ContentBaseForm, new()
        {
            //Session.MainForm.CenterWindow();
            await Task.Delay(50);

            contentForm.FinalLoadOnShow();
        }
        #endregion
    }
}