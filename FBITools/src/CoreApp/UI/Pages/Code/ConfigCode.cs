using System;

namespace FBITools
{
    public class ConfigCode : PageCode
    {
        #region InitializeForm
        public ConfigCode()
        {
            Session.ConfigPage = this;

            base.UI = UI = new ConfigUI();
            UI.TabStop = false;
            UI.Load += OnFormLoad;
            UI.Shown += OnFormShown;
            UI.GotFocus += OnFormGotFocus;
        }

        public new ConfigUI UI { get; set; }

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
            UI.DarkModeCheckBox.CheckedChanged += DarkModeCheckBox_CheckedChanged;
            UI.AutoCenterWindowCheckBox.CheckedChanged += WindowAutoCenterCheckBox_CheckedChanged;
            UI.AutoResizeWindowCheckBox.CheckedChanged += WindowAutoResizeCheckBox_CheckedChanged;
            UI.DebugModeCheckBox.CheckedChanged += DebugModeCheckBox_CheckedChanged;
        }

        private void OnFormGotFocus(object sender, EventArgs e)
        {
            UI.DarkModeCheckBox.Focus();
        }
        #endregion

        #region InitializeControls
        private void InitializeControls()
        {
            if (Options.IsLoaded)
            {
                UI.DarkModeCheckBox.Checked = Session.Options.IsDarkMode;
                UI.AutoCenterWindowCheckBox.Checked = Session.Options.IsAutoCenterWindow;
                UI.AutoResizeWindowCheckBox.Checked = Session.Options.IsAutoResizeWindow;
                UI.DebugModeCheckBox.Checked = Session.Options.IsDebugMode;
            }
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