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
            DarkModeCheckBox.CheckedChanged += OnDarkModeCheckBoxChanged;
            AutoCenterWindowCheckBox.CheckedChanged += OnWindowAutoCenterCheckBoxChanged;
            AutoResizeWindowCheckBox.CheckedChanged += OnWindowAutoResizeCheckBoxChanged;
            DebugModeCheckBox.CheckedChanged += OnDebugModeCheckBoxChanged;
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
        private static void OnDarkModeCheckBoxChanged(object sender, EventArgs e)
        {
            Session.Options.ToggleDarkMode();
        }

        private static void OnWindowAutoCenterCheckBoxChanged(object sender, EventArgs e)
        {
            Session.Options.ToggleAutoCenterWindow();
        }

        private static void OnWindowAutoResizeCheckBoxChanged(object sender, EventArgs e)
        {
            Session.Options.ToggleAutoResizeWindow();
        }

        private static void OnDebugModeCheckBoxChanged(object sender, EventArgs e)
        {
            Session.Options.ToggleDebugMode();
        }
        #endregion
    }
}