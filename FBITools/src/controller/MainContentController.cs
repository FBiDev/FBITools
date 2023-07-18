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

        public static SaveStateForm tabSaveState = new SaveStateForm();
        public static MemoryCardForm tabMemoryCard = new MemoryCardForm();

        public static void Init(Form formDesign)
        {
            Session.mainContentForm = formDesign;

            form.Load += Load;
            form.Shown += Shown;
            form.KeyPreview = true;
            form.KeyDown += form_KeyDown;

            btnSaveStateTab.Click += (sender, e) => SetContent(tabSaveState, btnSaveStateTab);
            btnMemoryCardTab.Click += (sender, e) => SetContent(tabMemoryCard, btnMemoryCardTab);
        }

        static void form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.A) return;

            Theme.DarkMode();
        }

        static void Load(object sender, EventArgs e) { }
        static void Shown(object sender, EventArgs e)
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
        public static void SetContent(ContentBaseForm contentForm, FlatButtonA selectTab)
        {
            SetSelectedTab(selectTab);

            pnlContentR.Controls.Clear();
            pnlContentR.Controls.Add(contentForm);

            contentForm.Dock = DockStyle.Fill;
            contentForm.Show();

            ResizeContent(contentForm.OriginalSize);
        }

        public static bool LoadConfigFile() { return Json.Load(ref Session.options, Session.options.File); }
        public static bool UpdateConfigFile() { return Json.Save(Session.options, Session.options.File); }
        #endregion
    }
}