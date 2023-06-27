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
        public static SaveStateForm tabCopyState;
        public static Size tabCopyStateSize;

        public static MemoryCardForm tabMemoryCard;
        public static Size tabMemoryCardSize;

        public static FlatButtonA selectedTab;

        public static void Init(Form formDesign)
        {
            BIND.mainContentForm = formDesign;
            form.Init(form);
            form.Shown += Form_Shown;

            tabCopyState = new SaveStateForm();
            tabCopyStateSize = tabCopyState.Size;

            tabMemoryCard = new MemoryCardForm();
            tabMemoryCardSize = tabMemoryCard.Size;

            btnSaveStateTab.Click += btnSaveStateTab_Click;
            btnMemoryCardTab.Click += btnMemoryCardTab_Click;
        }

        static void Form_Load(object sender, EventArgs e) { }
        static void Form_Shown(object sender, EventArgs e)
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
            BIND.mainForm.Height = tabCopyStateSize.Height + 84;
            BIND.mainForm.Width = tabCopyStateSize.Width + 163;
            tabCopyState.Show();

            pnlContentL.Controls.Clear();
            pnlContentL.Controls.Add(tabCopyState);
            tabCopyState.Dock = DockStyle.Fill;

            SetSelectedTab(btnSaveStateTab);
        }

        static void btnMemoryCardTab_Click(object sender, EventArgs e)
        {
            BIND.mainForm.Height = tabMemoryCardSize.Height + 84;
            BIND.mainForm.Width = tabMemoryCardSize.Width + 163;
            tabMemoryCard.Show();

            pnlContentL.Controls.Clear();
            pnlContentL.Controls.Add(tabMemoryCard);
            tabMemoryCard.Dock = DockStyle.Fill;

            SetSelectedTab(btnMemoryCardTab);
        }
        #endregion

        #region Common
        public static bool LoadConfigFile()
        {
            if (File.Exists(BIND.cfg.File))
            {
                var json_data = File.ReadAllText(BIND.cfg.File);
                BIND.cfg = JsonConvert.DeserializeObject<Config>(json_data);
                return true;
            }
            return false;
        }

        public static void UpdateConfigFile()
        {
            var json_data = JsonConvert.SerializeObject(BIND.cfg, Formatting.Indented);
            File.WriteAllText(BIND.cfg.File, json_data, Encoding.UTF8);
        }
        #endregion
    }
}