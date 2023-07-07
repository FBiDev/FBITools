using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FBITools
{
    public partial class MainContentController
    {
        #region MAIN
        public static SaveStateForm tabSaveState;
        public static Size tabSaveStateSize;

        public static MemoryCardForm tabMemoryCard;
        public static Size tabMemoryCardSize;

        public static FlatButtonA selectedTab;

        public static void Init(Form formDesign)
        {
            Session.mainContentForm = formDesign;

            form.Load += Load;
            form.Shown += Shown;
            form.KeyPreview = true;
            form.KeyDown += form_KeyDown;

            tabSaveState = new SaveStateForm();
            tabSaveStateSize = tabSaveState.Size;

            tabMemoryCard = new MemoryCardForm();
            tabMemoryCardSize = tabMemoryCard.Size;

            btnSaveStateTab.Click += btnSaveStateTab_Click;
            btnMemoryCardTab.Click += btnMemoryCardTab_Click;
        }

        static void form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                if (GNX.Theme.SelectedTheme == GNX.Theme.eTheme.Dark)
                    Theme.SetTheme(GNX.Theme.eTheme.Light);
                else
                    Theme.SetTheme(GNX.Theme.eTheme.Dark);
            }
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

            pnlContentR.Controls.Clear();
            pnlContentR.Controls.Add(tabSaveState);

            tabSaveState.Dock = DockStyle.Fill;
            tabSaveState.Show();

            ResizeContent(tabSaveStateSize);
        }

        static void btnMemoryCardTab_Click(object sender, EventArgs e)
        {
            SetSelectedTab(btnMemoryCardTab);

            pnlContentR.Controls.Clear();
            pnlContentR.Controls.Add(tabMemoryCard);

            tabMemoryCard.Dock = DockStyle.Fill;
            tabMemoryCard.Show();

            ResizeContent(tabMemoryCardSize);
        }

        static void ResizeContent(Size content)
        {
            Session.mainForm.Height = content.Height + 84;
            Session.mainForm.Width = content.Width + pnlContentL.Width;
        }
        #endregion

        #region Common
        public static bool LoadConfigFile()
        {
            if (File.Exists(Session.options.File))
            {
                var json_data = File.ReadAllText(Session.options.File);
                Session.options = JsonConvert.DeserializeObject<Options>(json_data);
                return true;
            }
            return false;
        }

        public static void UpdateConfigFile()
        {
            var json_data = JsonConvert.SerializeObject(Session.options, Formatting.Indented);
            File.WriteAllText(Session.options.File, json_data, Encoding.UTF8);
        }
        #endregion
    }
}