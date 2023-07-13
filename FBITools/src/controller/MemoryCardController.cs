using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using GNX;

namespace FBITools
{
    public partial class MemoryCardController
    {
        static bool backupStarted;

        public static void Init(Form formDesign)
        {
            Session.memoryCardForm = formDesign;

            btnMcOrigin.Click += btnMcOrigin_Click;
            btnMcDestination.Click += btnMcDestination_Click;
            btnMcBackup.Click += btnMcBackup_Click;
            lblMcBackup.TextChanged += lblMcBackup_TextChanged;
            cboMcTimer.SelectedIndexChanged += cboMcTimer_SelectedIndexChanged;

            dlgMcOrigin.ValidateNames = true;
            dlgMcOrigin.CheckFileExists = true;
            dlgMcOrigin.CheckPathExists = true;
            dlgMcOrigin.FileName = "";

            dlgMcDestination.Filter = "All Files (*.*)|*.*";

            var timerItems = new List<int> { 0, 1, 5, 10, 15, 30, 60, 120, 180 };
            cboMcTimer.DataSource = timerItems;

            if (MainContentController.LoadConfigFile())
            {
                UpdateMcOrigin();
                UpdateMcDestination();
                UpdateMcTimer();
            }

            if (cboMcTimer.SelectedIndex < 0) cboMcTimer.SelectedIndex = 0;
        }

        static void cboMcTimer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session.options.MemoryCard_Timer = cboMcTimer.SelectedValueInt;
        }

        static void btnMcOrigin_Click(object sender, EventArgs e)
        {
            if (dlgMcOrigin.ShowDialog() == DialogResult.OK)
            {
                Session.options.MemoryCard_Origin = dlgMcOrigin.FileName.NormalizePath();
                UpdateMcOrigin();
            }
        }

        static void btnMcDestination_Click(object sender, EventArgs e)
        {
            if (dlgMcDestination.ShowDialog() == DialogResult.OK)
            {
                Session.options.MemoryCard_Destination = dlgMcDestination.FileName.NormalizePath();
                UpdateMcDestination();
            }
        }

        static async void btnMcBackup_Click(object sender, EventArgs e)
        {
            if (IsMcBackupInvalid())
            {
                lblMcBackup.Text = "MemoryCard Backup Failed!";
                return;
            }

            backupStarted = !backupStarted;

            pnlMcOrigin.Enabled = !backupStarted;
            pnlMcDestination.Enabled = !backupStarted;
            pnlMcTimer.Enabled = !backupStarted;

            if (backupStarted)
            {
                btnMcBackup.Text = "Backup Stop";
                lblMcBackup.Text = "MemoryCard Backup Started!";

                MainContentController.UpdateConfigFile();
                await BackupMemoryCard();
            }
            else
            {
                btnMcBackup.Text = "Backup Start";
                lblMcBackup.Text = "MemoryCard Backup Stoped!";
            }
        }

        static async void lblMcBackup_TextChanged(object sender, EventArgs e)
        {
            await Task.Delay(2000);
            lblMcBackup.Text = "";
        }

        static void UpdateMcOrigin()
        {
            txtMcOrigin.Text = Session.options.MemoryCard_Origin;

            dlgMcOrigin.InitialDirectory = Path.GetDirectoryName(Session.options.MemoryCard_Origin);
            dlgMcOrigin.FileName = Path.GetFileName(Session.options.MemoryCard_Origin);

            if (string.IsNullOrWhiteSpace(dlgMcDestination.FileName))
                dlgMcDestination.FileName = Session.options.MemoryCard_Origin;
        }

        static void UpdateMcDestination()
        {
            txtMcDestination.Text = Session.options.MemoryCard_Destination;

            dlgMcDestination.InitialDirectory = Path.GetDirectoryName(Session.options.MemoryCard_Destination);
            dlgMcDestination.FileName = Path.GetFileName(Session.options.MemoryCard_Destination);
        }

        static void UpdateMcTimer()
        {
            cboMcTimer.SelectedItem = Session.options.MemoryCard_Timer;
        }

        static bool IsMcBackupInvalid()
        {
            return string.IsNullOrWhiteSpace(Session.options.MemoryCard_Origin)
            || string.IsNullOrWhiteSpace(Session.options.MemoryCard_Destination)
            || Session.options.MemoryCard_Origin == Session.options.MemoryCard_Destination
            || Session.options.MemoryCard_Timer <= 0;
        }

        static async Task BackupMemoryCard()
        {
            await Task.Delay(2000);

            do
            {
                DateTime? NOW = DateTime.Now;
                var NOWString = NOW.ToDB();
                NOWString = NOWString.Substring(0, NOWString.Length - 4);

                var fileSource = Session.options.MemoryCard_Origin;

                var fileDestFolder = Path.GetDirectoryName(Session.options.MemoryCard_Destination);
                var fileDestName = Path.GetFileNameWithoutExtension(Session.options.MemoryCard_Destination);
                var fileDestExt = Path.GetExtension(Session.options.MemoryCard_Destination);

                var fileDestination = fileDestName + "(" + NOWString + ")" + fileDestExt;
                fileDestination = fileDestination.Replace("/", "-").Replace(":", "-").Replace("'", "");
                fileDestination = Path.Combine(fileDestFolder, fileDestination);

                File.Copy(fileSource, fileDestination, true);
                lblMcBackup.Text = "MemoryCard Backup Saved!";

                await Task.Delay((Session.options.MemoryCard_Timer * 1000) * 60);
            } while (backupStarted);
        }
    }
}