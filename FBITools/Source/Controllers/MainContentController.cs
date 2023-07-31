using System;
using System.Drawing;
using System.Windows.Forms;
using GNX;

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
            Session.mainForm.Height = content.Height + 84;
            Session.mainForm.Width = content.Width + pnlContentL.Width;
        }
        #endregion

        #region Common
        public static void SetContent<T>(ref T contentForm, FlatButtonA selectTab) where T : ContentBaseForm, new()
        {
            SetSelectedTab(selectTab);

            if (contentForm == null) contentForm = new T();
            if (pnlContentR.Controls.Contains(contentForm)) return;

            pnlContentR.Controls.Clear();
            pnlContentR.Controls.Add(contentForm);

            contentForm.Dock = DockStyle.Fill;
            contentForm.Show();

            ResizeContent(contentForm.OriginalSize);
        }
        #endregion
    }
}