using System;

namespace FBITools
{
    public partial class ConfigController
    {
        #region InitializeForm
        public ConfigController(ConfigForm page)
        {
            Page = page;
            Page.TabStop = false;
            Page.Load += OnFormLoad;
            Page.Shown += OnFormShown;
            Page.GotFocus += OnFormGotFocus;
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
            WindowAutoCenterCheckBox.CheckedChanged += WindowAutoCenterCheckBox_CheckedChanged;
            WindowAutoResizeCheckBox.CheckedChanged += WindowAutoResizeCheckBox_CheckedChanged;
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
            if (Options.IsLoaded)
            {
                DarkModeCheckBox.Checked = Session.Options.IsDarkMode;
                WindowAutoCenterCheckBox.Checked = Session.Options.IsAutoCenterWindow;
                WindowAutoResizeCheckBox.Checked = Session.Options.IsAutoResizeWindow;
                DebugModeCheckBox.Checked = Session.Options.IsDebugMode;
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