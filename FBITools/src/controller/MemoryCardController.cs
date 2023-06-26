﻿using System;
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
            BIND.memoryCardForm = formDesign;
            form.Init(form);

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
        }

        static void cboMcTimer_SelectedIndexChanged(object sender, EventArgs e)
        {
            BIND.cfg.MemoryCard_Timer = cboMcTimer.SelectedValueInt;
        }

        static void btnMcOrigin_Click(object sender, EventArgs e)
        {
            if (dlgMcOrigin.ShowDialog() == DialogResult.OK)
            {
                BIND.cfg.MemoryCard_Origin = dlgMcOrigin.FileName;
                UpdateMcOrigin();
            }
        }

        static void btnMcDestination_Click(object sender, EventArgs e)
        {
            if (dlgMcDestination.ShowDialog() == DialogResult.OK)
            {
                BIND.cfg.MemoryCard_Destination = dlgMcDestination.FileName;
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
            txtMcOrigin.Text = BIND.cfg.MemoryCard_Origin;

            dlgMcOrigin.InitialDirectory = Path.GetDirectoryName(BIND.cfg.MemoryCard_Origin);
            dlgMcOrigin.FileName = Path.GetFileName(BIND.cfg.MemoryCard_Origin);

            if (string.IsNullOrWhiteSpace(dlgMcDestination.FileName))
                dlgMcDestination.FileName = BIND.cfg.MemoryCard_Origin;
        }

        static void UpdateMcDestination()
        {
            txtMcDestination.Text = BIND.cfg.MemoryCard_Destination;

            dlgMcDestination.InitialDirectory = Path.GetDirectoryName(BIND.cfg.MemoryCard_Destination);
            dlgMcDestination.FileName = Path.GetFileName(BIND.cfg.MemoryCard_Destination);
        }

        static void UpdateMcTimer()
        {
            cboMcTimer.SelectedItem = BIND.cfg.MemoryCard_Timer;
        }

        static bool IsMcBackupInvalid()
        {
            return string.IsNullOrWhiteSpace(BIND.cfg.MemoryCard_Origin)
            || string.IsNullOrWhiteSpace(BIND.cfg.MemoryCard_Destination)
            || BIND.cfg.MemoryCard_Origin == BIND.cfg.MemoryCard_Destination
            || BIND.cfg.MemoryCard_Timer <= 0;
        }

        static async Task BackupMemoryCard()
        {
            await Task.Delay(2000);

            do
            {
                DateTime? NOW = DateTime.Now;
                var NOWString = NOW.ToDB();
                NOWString = NOWString.Substring(0, NOWString.Length - 4);

                var fileSource = BIND.cfg.MemoryCard_Origin;

                var fileDestFolder = Path.GetDirectoryName(BIND.cfg.MemoryCard_Destination);
                var fileDestName = Path.GetFileNameWithoutExtension(BIND.cfg.MemoryCard_Destination);
                var fileDestExt = Path.GetExtension(BIND.cfg.MemoryCard_Destination);

                var fileDestination = fileDestName + "(" + NOWString + ")" + fileDestExt;
                fileDestination = fileDestination.Replace("/", "-").Replace(":", "-").Replace("'", "");
                fileDestination = Path.Combine(fileDestFolder, fileDestination);

                File.Copy(fileSource, fileDestination, true);
                lblMcBackup.Text = "MemoryCard Backup Saved!";

                await Task.Delay((BIND.cfg.MemoryCard_Timer * 1000) * 60);
            } while (backupStarted);
        }
    }
}