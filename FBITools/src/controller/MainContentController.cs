using System;
using System.Drawing;
using System.Windows.Forms;

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

            btnSaveStateTab.Click += btnSaveStateTab_Click;
            btnMemoryCardTab.Click += btnMemoryCardTab_Click;
        }

        static void form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData != Keys.A) return;

            Theme.DarkMode();
        }

        static void Load(object sender, EventArgs e) { }
        static void Shown(object sender, EventArgs e)
        {
            btnSaveStateTab_Click(btnSaveStateTab, null);
        }

        static void SetSelectedTab(FlatButtonA btnClicked)
        {
            if (selectedTab != null && selectedTab != btnClicked)
                selectedTab.Selected = false;

            btnClicked.Selected = true;
            selectedTab = btnClicked;
        }

        static void btnSaveStateTab_Click(object sender, EventArgs e)
        {
            SetSelectedTab(btnSaveStateTab);
            SetContentForm(tabSaveState);
            ResizeContent(tabSaveState.OriginalSize);
        }

        static void btnMemoryCardTab_Click(object sender, EventArgs e)
        {
            SetSelectedTab(btnMemoryCardTab);
            SetContentForm(tabMemoryCard);
            ResizeContent(tabMemoryCard.OriginalSize);
        }

        static void ResizeContent(Size content)
        {
            Session.mainForm.Height = content.Height + 84;
            Session.mainForm.Width = content.Width + pnlContentL.Width;
        }
        #endregion

        #region Common
        public static void SetContentForm(Form frm)
        {
            pnlContentR.Controls.Clear();
            pnlContentR.Controls.Add(frm);

            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        public static bool LoadConfigFile()
        {
            return Json.Load(ref Session.options, Session.options.File);
        }

        public static bool UpdateConfigFile()
        {
            return Json.Save(Session.options, Session.options.File);
        }
        #endregion
    }
}