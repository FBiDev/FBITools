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
        static TaskController BackupTask = new TaskController();

        public static void Init(Form formDesign)
        {
            Session.memoryCardForm = formDesign;

            btnOrigin.Click += btnOrigin_Click;
            btnDestination.Click += btnDestination_Click;
            btnBackup.Click += btnBackup_Click;
            lblResult.TextChanged += lblBackup_TextChanged;
            cboTimer.SelectedIndexChanged += cboTimer_SelectedIndexChanged;

            dlgOrigin.ValidateNames = true;
            dlgOrigin.CheckFileExists = true;
            dlgOrigin.CheckPathExists = true;
            dlgOrigin.FileName = "";

            dlgDestination.Filter = "All Files (*.*)|*.*";

            var timerItems = new List<int> { 0, 1, 5, 10, 15, 30, 60, 120, 180 };
            cboTimer.DataSource = timerItems;

            if (MainContentController.LoadConfigFile())
            {
                UpdateOrigin();
                UpdateDestination();
                UpdateTimer();
            }

            if (cboTimer.SelectedIndex < 0) cboTimer.SelectedIndex = 0;
        }

        static void btnOrigin_Click(object sender, EventArgs e)
        {
            if (dlgOrigin.ShowDialog() == DialogResult.OK)
            {
                Session.options.MemoryCard_Origin = dlgOrigin.FileName.NormalizePath();
                UpdateOrigin();

                Session.options.MemoryCard_Destination = (Path.Combine(Path.GetDirectoryName(txtDestination.Text),
                                                                       dlgOrigin.FileName)).NormalizePath();
                UpdateDestination();
            }
        }

        static void btnDestination_Click(object sender, EventArgs e)
        {
            if (dlgDestination.ShowDialog() == DialogResult.OK)
            {
                Session.options.MemoryCard_Destination = dlgDestination.FileName.NormalizePath();
                UpdateDestination();
            }
        }

        static void cboTimer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session.options.MemoryCard_Timer = cboTimer.SelectedValueInt;
        }

        static async void btnBackup_Click(object sender, EventArgs e)
        {
            if (IsBackupInvalid())
            {
                lblResult.Text = "MemoryCard Backup Failed!";
                return;
            }

            backupStarted = !backupStarted;

            pnlOrigin.Enabled = !backupStarted;
            pnlDestination.Enabled = !backupStarted;
            pnlTimer.Enabled = !backupStarted;

            if (backupStarted)
            {
                BackupTask.Reset();
                lblResult.Text = "MemoryCard Backup Started!";
                btnBackup.Text = "Backup Stop";

                MainContentController.UpdateConfigFile();
                await BackupMemoryCard();
            }
            else
            {
                BackupTask.Cancel();
                lblResult.Text = "MemoryCard Backup Stoped!";
                btnBackup.Text = "Backup Start";
            }
        }

        static async void lblBackup_TextChanged(object sender, EventArgs e)
        {
            await TaskController.Delay(4);
            lblResult.Text = "";
        }

        static void UpdateOrigin()
        {
            txtOrigin.Text = Session.options.MemoryCard_Origin;

            dlgOrigin.InitialDirectory = Path.GetDirectoryName(Session.options.MemoryCard_Origin);
            dlgOrigin.FileName = Path.GetFileName(Session.options.MemoryCard_Origin);

            if (string.IsNullOrWhiteSpace(dlgDestination.FileName))
                dlgDestination.FileName = Session.options.MemoryCard_Origin;
        }

        static void UpdateDestination()
        {
            txtDestination.Text = Session.options.MemoryCard_Destination;

            dlgDestination.InitialDirectory = Path.GetDirectoryName(Session.options.MemoryCard_Destination);
            dlgDestination.FileName = Path.GetFileName(Session.options.MemoryCard_Destination);
        }

        static void UpdateTimer()
        {
            cboTimer.SelectedItem = Session.options.MemoryCard_Timer;
        }

        static bool IsBackupInvalid()
        {
            return string.IsNullOrWhiteSpace(Session.options.MemoryCard_Origin)
            || string.IsNullOrWhiteSpace(Session.options.MemoryCard_Destination)
            || Session.options.MemoryCard_Origin == Session.options.MemoryCard_Destination
            || Session.options.MemoryCard_Timer <= 0;
        }

        static async Task BackupMemoryCard()
        {
            do
            {
                await BackupTask.DelayStart(Session.options.MemoryCard_Timer * 60);
                if (BackupTask.IsCanceled) return;

                var fileSource = Session.options.MemoryCard_Origin;
                var fileDestination = Session.options.MemoryCard_Destination.PathAddDateTime();

                File.Copy(fileSource, fileDestination, true);
                lblResult.Text = "MemoryCard Backup Saved!";
            } while (backupStarted);
        }
    }
}