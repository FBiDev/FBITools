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

        public static void Init(MemoryCardForm formView)
        {
            form = formView;

            btnOrigin.Click += btnOrigin_Click;
            btnDestination.Click += btnDestination_Click;
            btnBackup.Click += btnBackup_Click;
            cboTimer.SelectedIndexChanged += cboTimer_SelectedIndexChanged;
            lblWarning.TextChanged += lblResult_TextChanged;

            dlgOrigin.ValidateNames = true;
            dlgOrigin.CheckFileExists = true;
            dlgOrigin.CheckPathExists = true;
            dlgOrigin.FileName = "";

            dlgDestination.Filter = "All Files (*.*)|*.*";

            var timerItems = new List<int> { 0, 1, 5, 10, 15, 30, 60, 120, 180 };
            cboTimer.DataSource = timerItems;

            if (Options.Loaded)
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
                Session.Options.MemoryCard_Origin = dlgOrigin.FileName.NormalizePath();
                UpdateOrigin();

                if (Session.Options.MemoryCard_Destination == null) return;

                Session.Options.MemoryCard_Destination = (Path.Combine(Path.GetDirectoryName(txtDestination.Text),
                                                                       dlgOrigin.FileName)).NormalizePath();
                UpdateDestination();
            }
        }

        static void UpdateOrigin()
        {
            txtOrigin.Text = Session.Options.MemoryCard_Origin;

            dlgOrigin.InitialDirectory = Path.GetDirectoryName(Session.Options.MemoryCard_Origin);
            dlgOrigin.FileName = Path.GetFileName(Session.Options.MemoryCard_Origin);

            if (string.IsNullOrWhiteSpace(dlgDestination.FileName))
                dlgDestination.FileName = dlgOrigin.FileName;
        }

        static void btnDestination_Click(object sender, EventArgs e)
        {
            if (dlgDestination.ShowDialog() == DialogResult.OK)
            {
                Session.Options.MemoryCard_Destination = dlgDestination.FileName.NormalizePath();
                UpdateDestination();
            }
        }

        static void UpdateDestination()
        {
            txtDestination.Text = Session.Options.MemoryCard_Destination;

            dlgDestination.InitialDirectory = Path.GetDirectoryName(Session.Options.MemoryCard_Destination);
            dlgDestination.FileName = Path.GetFileName(Session.Options.MemoryCard_Destination);
        }

        static void cboTimer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session.Options.MemoryCard_Timer = cboTimer.SelectedValueInt;
        }

        static void UpdateTimer()
        {
            cboTimer.SelectedItem = Session.Options.MemoryCard_Timer;
        }

        static async void btnBackup_Click(object sender, EventArgs e)
        {
            if (IsBackupInvalid())
            {
                lblWarning.Text = "MemoryCard Backup Failed!";
                return;
            }

            backupStarted = !backupStarted;

            tblInput.Enabled = !backupStarted;

            if (backupStarted)
            {
                BackupTask.Reset();
                lblWarning.Text = "MemoryCard Backup Started!";
                btnBackup.Text = "Backup Stop";

                Session.UpdateOptions();
                await BackupMemoryCard();
            }
            else
            {
                BackupTask.Cancel();
                lblWarning.Text = "MemoryCard Backup Stoped!";
                btnBackup.Text = "Backup Start";
            }
        }

        static bool IsBackupInvalid()
        {
            return string.IsNullOrWhiteSpace(Session.Options.MemoryCard_Origin)
            || string.IsNullOrWhiteSpace(Session.Options.MemoryCard_Destination)
            || Session.Options.MemoryCard_Origin == Session.Options.MemoryCard_Destination
            || Session.Options.MemoryCard_Timer <= 0;
        }

        static async Task BackupMemoryCard()
        {
            do
            {
                var fileSource = Session.Options.MemoryCard_Origin;
                var fileDestination = Session.Options.MemoryCard_Destination.PathAddDateTime();

                File.Copy(fileSource, fileDestination, true);
                lblWarning.Text = "MemoryCard Backup Saved!";

                await BackupTask.DelayStart(Session.Options.MemoryCard_Timer * 60);
                if (BackupTask.IsCanceled) return;
            } while (backupStarted);
        }

        static async void lblResult_TextChanged(object sender, EventArgs e)
        {
            await TaskController.Delay(4);
            lblWarning.Text = "";
        }
    }
}