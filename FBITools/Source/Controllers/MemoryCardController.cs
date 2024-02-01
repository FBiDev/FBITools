using System;
using GNX;
using GNX.Desktop;

namespace FBITools
{
    public partial class MemoryCardController
    {
        FileCopy memoryCard;

        public MemoryCardController(MemoryCardForm formView)
        {
            form = formView;
            lblWarning.TextChanged += lblWarning_TextChanged;

            btnOrigin.Click += (s, e) =>
            {
                if (memoryCard.PickOrigin()) PreencherCampos();
            };

            btnDestination.Click += (s, e) =>
            {
                if (memoryCard.PickDestination()) PreencherCampos();
            };

            btnBackup.Click += async (s, e) =>
            {
                if (memoryCard.Copy() && memoryCard.TimerIsRunning)
                {
                    Session.UpdateOptions();
                    await memoryCard.StartTimer();
                }
            };

            memoryCard = new FileCopy
            {
                CustomName = true,
                Timer = true
            };

            memoryCard.Copied += () => lblWarning.Text = "MemoryCard Backup Saved!";

            memoryCard.InvalidFile += () =>
            {
                lblWarning.ForeColorType = LabelType.danger;
                lblWarning.Text = "MemoryCard Backup Failed!";
            };

            memoryCard.TimerRunningChanged += () =>
            {
                tblInput.Enabled = !memoryCard.TimerIsRunning;

                if (memoryCard.TimerIsRunning)
                {
                    lblWarning.Text = "MemoryCard Backup Started!";
                    btnBackup.Text = "Backup Stop";
                }
                else
                {
                    lblWarning.Text = "MemoryCard Backup Stoped!";
                    btnBackup.Text = "Backup Start";
                }
            };

            CarregarCampos();

            cboTimer.SelectedIndexChanged += cboTimer_SelectedIndexChanged;

            if (Options.Loaded)
            {
                memoryCard.OriginPath = Session.Options.MemoryCard_Origin;
                memoryCard.DestinationPath = Session.Options.MemoryCard_Destination;
                memoryCard.TimerValue = Session.Options.MemoryCard_Timer;
                PreencherCampos();
            }
        }

        void cboTimer_SelectedIndexChanged(object sender, EventArgs e)
        {
            memoryCard.TimerValue = cboTimer.SelectedValueInt;
            Session.Options.MemoryCard_Timer = memoryCard.TimerValue;
        }

        void CarregarCampos()
        {
            memoryCard.FillTimerCombo(cboTimer);
        }

        void PreencherCampos()
        {
            txtOrigin.Text = memoryCard.OriginPath;
            Session.Options.MemoryCard_Origin = memoryCard.OriginPath;
            txtDestination.Text = memoryCard.DestinationPath;
            Session.Options.MemoryCard_Destination = memoryCard.DestinationPath;
            cboTimer.SelectedValue = memoryCard.TimerValue;
        }

        async void lblWarning_TextChanged(object sender, EventArgs e)
        {
            await TaskController.Delay(4);
            lblWarning.Text = "";
        }
    }
}