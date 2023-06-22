using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FBITools
{
    public partial class MainCommon
    {
        #region MAIN
        public static CopyStateForm tabCopyState;
        public static Size tabCopyStateSize;

        public static MemoryCardForm tabMemoryCard;
        public static Size tabMemoryCardSize;

        public static void Main_Init(MainForm formDesign)
        {
            BIND.form = formDesign;
            form.Init(form);
            form.StatusBar = false;

            tabCopyState = new CopyStateForm();
            tabCopyStateSize = tabCopyState.Size;

            tabMemoryCard = new MemoryCardForm();
            tabMemoryCardSize = tabMemoryCard.Size;

            btnCopyState.Click += btnCopyState_Click;
            btnSaveMemoryCard.Click += btnSaveMemoryCard_Click;

            btnCopyState_Click(null, null);
        }

        static void Main_Load(object sender, EventArgs e) { }
        static void Main_Shown(object sender, EventArgs e) { }

        static void btnCopyState_Click(object sender, EventArgs e)
        {
            form.Height = tabCopyStateSize.Height + 84;
            form.Width = tabCopyStateSize.Width + 163;
            tabCopyState.Show();

            pnlContentL.Controls.Clear();
            pnlContentL.Controls.Add(tabCopyState);
            tabCopyState.Dock = DockStyle.Fill;
        }

        static void btnSaveMemoryCard_Click(object sender, EventArgs e)
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