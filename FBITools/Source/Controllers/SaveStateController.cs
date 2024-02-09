using System;
using GNX;
using GNX.Desktop;

namespace FBITools
{
    public partial class SaveStateController
    {
        FileBackup state;

        public SaveStateController(SaveStateForm formView)
        {
            form = formView;
            form.Shown += form_Shown;
        }

        void form_Shown(object sender, EventArgs ev)
        {
            lblWarning.TextChanged += lblWarning_TextChanged;

            state = new FileBackup
            {
                CustomName = true
            };

            CarregarCombos();

            if (Options.Loaded)
            {
                state.OriginPath = Session.Options.SaveState_Origin;
                state.DestinationPath = Session.Options.SaveState_Destination;
                state.TimerValue = Session.Options.SaveState_Timer;

                cboType.SelectedValue = Session.Options.SaveState_Type;
                cboTimer.SelectedValue = Session.Options.SaveState_Timer;

                PreencherCampos();
            }

            btnOrigin.Click += (s, e) => { if (state.PickOrigin()) PreencherCampos(); };

            btnDestination.Click += (s, e) => { if (state.PickDestination()) PreencherCampos(); };

            cboType.SelectedIndexChanged += (s, e) => { PreencherCampos(); };

            cboTimer.SelectedIndexChanged += (s, e) => { PreencherCampos(); };

            btnCopy.Click += (s, e) =>
            {
                if (state.Copy())
                {
                    Session.UpdateOptions();
                    if (state.TimerIsRunning)
                    {
                        state.StartBackupTimer().TryAwait();
                    }
                }
            };

            state.Copied += () =>
            {
                lblWarning.ForeColorType = LabelType.success;
                lblWarning.Text = "Save State Copied!";
            };

            state.InvalidFile += () =>
            {
                lblWarning.ForeColorType = LabelType.danger;
                lblWarning.Text = "Save State Copy Failed!";
            };

            state.TimerRunningChanged += () =>
            {
                FormManager.EnableFormControls(!state.TimerIsRunning, tblInput);

                lblWarning.ForeColorType = LabelType.primary;

                if (state.TimerIsRunning)
                {
                    lblWarning.Text = "Save State Backup Started!";
                    btnCopy.Text = "Backup Stop";
                }
                else
                {
                    lblWarning.Text = "Save State Backup Stoped!";
                    btnCopy.Text = "Backup Start";
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
            state.LoadComboTypes(cboType);
            state.LoadComboTimer(cboTimer);
        }

        void PreencherCampos()
        {
            txtOrigin.Text = state.OriginPath;
            txtDestination.Text = state.DestinationPath;

            Session.Options.SaveState_Origin = state.OriginPath;
            Session.Options.SaveState_Destination = state.DestinationPath;
            Session.Options.SaveState_Type = cboType.SelectedValueInt;
            Session.Options.SaveState_Timer = state.TimerValue;

            cboTimer.Enabled = cboType.SelectedValueInt == 2;
            if (cboTimer.Enabled)
                btnCopy.Text = "Backup Start";
            else
                btnCopy.Text = "Copy";
        }
    }
}