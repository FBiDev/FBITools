using GNX;
using GNX.Desktop;
using System;

namespace FBITools
{
    public partial class SaveStateController
    {
        FileCopy state;

        public SaveStateController(SaveStateForm formView)
        {
            form = formView;
            form.FinalLoadOnce += CarregarCampos;
            lblWarning.TextChanged += lblWarning_TextChanged;

            btnOrigin.Click += (s, e) =>
            {
                if (state.PickOrigin()) PreencherCampos();
            };

            btnDestination.Click += (s, e) =>
            {
                if (state.PickDestination()) PreencherCampos();
            };

            btnCopy.Click += (s, e) =>
            {
                if (state.Copy())
                {
                    lblWarning.ForeColorType = LabelType.success;
                    lblWarning.Text = "Save State Copied!";
                    Session.UpdateOptions();
                }
                else
                {
                    lblWarning.ForeColorType = LabelType.danger;
                    lblWarning.Text = "Save State Copy Failed!";
                }
            };

            state = new FileCopy
            {
                CustomName = true,
                Filter = (FileCopy.Filters.AllFiles),
            };

            if (Options.Loaded)
            {
                state.OriginPath = Session.Options.SaveState_Origin;
                state.DestinationPath = Session.Options.SaveState_Destination;
                PreencherCampos();
            }
        }

        void CarregarCampos()
        {
            state.FillTypesCombo(cboCopyType);
        }

        void PreencherCampos()
        {
            txtOrigin.Text = state.OriginPath;
            Session.Options.SaveState_Origin = state.OriginPath;
            txtDestination.Text = state.DestinationPath;
            Session.Options.SaveState_Destination = state.DestinationPath;
        }

        async void lblWarning_TextChanged(object sender, System.EventArgs e)
        {
            await TaskController.Delay(4);
            lblWarning.Text = "";
        }
    }
}