using System;

namespace FBITools
{
    public partial class ConfigController
    {
        public ConfigController(ConfigForm page)
        {
            Page = page;
            Page.Load += Page_Load;
            Page.Shown += Page_Shown;
            Page.GotFocus += (s, e) => DarkModeCheckBox.Focus();
            Page.TabStop = false;
        }

        private void Page_Load(object sender, EventArgs e)
        {
            Controls_Load();
        }

        private void Page_Shown(object sender, EventArgs ev)
        {
            DarkModeCheckBox.CheckedChanged += (s, e) => Session.Options.ToggleDarkMode();
            WindowAutoCenterCheckBox.CheckedChanged += (s, e) => Session.Options.ToggleAutoCenterWindow();
            WindowAutoResizeCheckBox.CheckedChanged += (s, e) => Session.Options.ToggleAutoResizeWindow();
            DebugModeCheckBox.CheckedChanged += (s, e) => Session.Options.ToggleDebugMode();
        }

        private void Controls_Load()
        {
            if (Options.IsLoaded)
            {
                DarkModeCheckBox.Checked = Session.Options.IsDarkMode;
                WindowAutoCenterCheckBox.Checked = Session.Options.IsAutoCenterWindow;
                WindowAutoResizeCheckBox.Checked = Session.Options.IsAutoResizeWindow;
                DebugModeCheckBox.Checked = Session.Options.IsDebugMode;
            }
        }
    }
}