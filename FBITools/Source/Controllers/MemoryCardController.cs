using System;
using App.Core;
using App.Core.Desktop;

namespace FBITools
{
    public partial class MemoryCardController
    {
        FileBackup memoryCard;

        public MemoryCardController(MemoryCardForm formView)
        {
            form = formView;
            form.Shown += form_Shown;
        }

        void form_Shown(object sender, EventArgs ev)
        {
            lblWarning.TextChanged += lblWarning_TextChanged;

            memoryCard = new FileBackup
            {
                CustomName = true,
                Timer = true
            };

            CarregarCombos();

            if (Options.Loaded)
            {
                memoryCard.OriginPath = Session.Options.MemoryCard_Origin;
                memoryCard.DestinationPath = Session.Options.MemoryCard_Destination;
                memoryCard.TimerValue = Session.Options.MemoryCard_Timer;

                cboTimer.SelectedValue = Session.Options.MemoryCard_Timer;

                PreencherCampos();
            }

            btnOrigin.Click += (s, e) => { if (memoryCard.PickOrigin()) PreencherCampos(); };

            btnDestination.Click += (s, e) => { if (memoryCard.PickDestination()) PreencherCampos(); };

            cboTimer.SelectedIndexChanged += (s, e) => { PreencherCampos(); };

            btnBackup.Click += (s, e) =>
            {
                if (memoryCard.Copy())
                {
                    Session.UpdateOptions();
                    if (memoryCard.TimerIsRunning)
                    {
                        memoryCard.StartBackupTimer().TryAwait();
                    }
                }
            };

            memoryCard.Copied += () =>
            {
                lblWarning.ForeColorType = LabelType.success;
                lblWarning.Text = "MemoryCard Copied!";
            };

            memoryCard.InvalidFile += () =>
            {
                lblWarning.ForeColorType = LabelType.danger;
                lblWarning.Text = "MemoryCard Copy Failed!";
            };

            memoryCard.TimerRunningChanged += () =>
            {
                FormManager.EnableFormControls(!memoryCard.TimerIsRunning, tblInput);

                lblWarning.ForeColorType = LabelType.primary;

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
        }

        async void lblWarning_TextChanged(object sender, EventArgs e)
        {
            await TaskController.Delay(4);
            lblWarning.Text = "";
        }

        void CarregarCombos()
        {
            memoryCard.LoadComboTimer(cboTimer);
        }

        void PreencherCampos()
        {
            txtOrigin.Text = memoryCard.OriginPath;
            txtDestination.Text = memoryCard.DestinationPath;

            Session.Options.MemoryCard_Origin = memoryCard.OriginPath;
            Session.Options.MemoryCard_Destination = memoryCard.DestinationPath;
            Session.Options.MemoryCard_Timer = memoryCard.TimerValue;

            if (cboTimer.Enabled)
                btnBackup.Text = "Backup Start";
            else
                btnBackup.Text = "Copy";
        }
    }
}