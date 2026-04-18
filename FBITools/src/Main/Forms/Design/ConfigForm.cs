using System;
using App.Core.Desktop;

namespace FBITools
{
    public partial class ConfigForm : ContentBaseForm
    {
        #region InitializeForm
        public ConfigForm()
        {
            InitializeComponent();

            Session.ConfigPage = this;

            TabStop = false;
            Load += OnFormLoad;
            Shown += OnFormShown;
            GotFocus += OnFormGotFocus;
        }

        private void OnFormLoad(object sender, EventArgs e)
        {
            InitializeControls();
        }

        private void OnFormShown(object sender, EventArgs ev)
        {
            RegisterShownEvents();
        }

        private void RegisterShownEvents()
        {
            DarkModeCheckBox.CheckedChanged += DarkModeCheckBox_CheckedChanged;
            AutoCenterWindowCheckBox.CheckedChanged += WindowAutoCenterCheckBox_CheckedChanged;
            AutoResizeWindowCheckBox.CheckedChanged += WindowAutoResizeCheckBox_CheckedChanged;
            DebugModeCheckBox.CheckedChanged += DebugModeCheckBox_CheckedChanged;
        }

        private void OnFormGotFocus(object sender, EventArgs e)
        {
            DarkModeCheckBox.Focus();
        }
        #endregion

        #region InitializeControls
        private void InitializeControls()
        {
            if (!Options.IsLoaded)
            {
                return;
            }

            DarkModeCheckBox.Checked = Session.Options.IsDarkMode;
            AutoCenterWindowCheckBox.Checked = Session.Options.IsAutoCenterWindow;
            AutoResizeWindowCheckBox.Checked = Session.Options.IsAutoResizeWindow;
            DebugModeCheckBox.Checked = Session.Options.IsDebugMode;
        }
        #endregion

        #region UserEvents
        private void DarkModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Session.Options.ToggleDarkMode();
        }

        private void WindowAutoCenterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Session.Options.ToggleAutoCenterWindow();
        }

        private void WindowAutoResizeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Session.Options.ToggleAutoResizeWindow();
        }

        private void DebugModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Session.Options.ToggleDebugMode();
        }
        #endregion
    }
}