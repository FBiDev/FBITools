using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FBITools
{
    public partial class MainController
    {
        #region MAIN
        public static SaveStateForm tabCopyState;
        public static Size tabCopyStateSize;

        public static MemoryCardForm tabMemoryCard;
        public static Size tabMemoryCardSize;

        public static void Init(Form formDesign)
        {
            BIND.mainForm = formDesign;
            form.Init(form);
            form.StatusBar = false;

            tabCopyState = new SaveStateForm();
            tabCopyStateSize = tabCopyState.Size;

            tabMemoryCard = new MemoryCardForm();
            tabMemoryCardSize = tabMemoryCard.Size;

            btnSaveStateTab.Click += btnSaveStateTab_Click;
            btnMemoryCardTab.Click += btnMemoryCardTab_Click;

            btnSaveStateTab_Click(null, null);
        }

        static void Load(object sender, EventArgs e) { }
        static void Shown(object sender, EventArgs e) { }

        static void btnSaveStateTab_Click(object sender, EventArgs e)
        {
            form.Height = tabCopyStateSize.Height + 84;
            form.Width = tabCopyStateSize.Width + 163;
            tabCopyState.Show();

            pnlContentL.Controls.Clear();
            pnlContentL.Controls.Add(tabCopyState);
            tabCopyState.Dock = DockStyle.Fill;
        }

        static void btnMemoryCardTab_Click(object sender, EventArgs e)
        {
            form.Height = tabMemoryCardSize.Height + 84;
            form.Width = tabMemoryCardSize.Width + 163;
            tabMemoryCard.Show();

            pnlContentL.Controls.Clear();
            pnlContentL.Controls.Add(tabMemoryCard);
            tabMemoryCard.Dock = DockStyle.Fill;
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