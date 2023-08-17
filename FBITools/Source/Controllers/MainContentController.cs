using System;
using System.Drawing;
using System.Windows.Forms;
using GNX.Desktop;

namespace FBITools
{
    public partial class MainContentController
    {
        #region MAIN
        public static FlatButtonA selectedTab;

        public static void Init(MainContentForm formView)
        {
            form = formView;

            form.Load += form_Load;
            form.Shown += form_Shown;

            //Initial Value
            chkDarkMode.Checked = Session.options.DarkMode;
            chkDarkMode.CheckedChanged += (sender, e) => MainController.DarkMode();

            btnSaveStateTab.Click += (sender, e) => SetContent(ref Session.saveStateForm, btnSaveStateTab);
            btnMemoryCardTab.Click += (sender, e) => SetContent(ref Session.memoryCardForm, btnMemoryCardTab);
        }

        static void form_Load(object sender, EventArgs e) { }

        static void form_Shown(object sender, EventArgs e)
        {
            btnSaveStateTab.PerformClick();
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
            var newW = content.Width + pnlContentL.Width + 30;
            var newH = content.Height + 26;

            if (Session.mainForm.StatusBar)
                newH += 24;

            Session.mainForm.ClientSize = new Size(newW, newH);
        }
        #endregion

        #region Common
        public static void SetContent<T>(ref T contentForm, FlatButtonA selectTab) where T : ContentBaseForm, new()
        {
            SetSelectedTab(selectTab);

            if (contentForm == null) contentForm = new T();
            if (pnlContentRInside.Controls.Contains(contentForm)) return;

            pnlContentRInside.Controls.Clear();
            pnlContentRInside.Controls.Add(contentForm);

            contentForm.Show();
            contentForm.Dock = DockStyle.Fill;
            contentForm.Focus();

            ResizeContent(contentForm.OriginalSize);
        }
        #endregion
    }
}