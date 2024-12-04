namespace FBITools
{
    public partial class ConfigController
    {
        #region Entrada
        public ConfigController(ConfigForm pageForm)
        {
            Page = pageForm;
            Page.Shown += ShownForm;
            Page.GotFocus += (s, e) => DarkModeCheckBox.Focus();
            Page.TabStop = false;
        }

        private void ShownForm(object sender, System.EventArgs ev)
        {
            DarkModeCheckBox.Checked = Session.Options.IsDarkMode;
            DarkModeCheckBox.CheckedChanged += (s, e) => Session.Options.ToggleDarkMode();

            WindowAutoCenterCheckBox.Checked = Session.Options.IsAutoCenterWindow;
            WindowAutoCenterCheckBox.CheckedChanged += (s, e) => Session.Options.ToggleAutoCenterWindow();

            WindowAutoResizeCheckBox.Checked = Session.Options.IsAutoResizeWindow;
            WindowAutoResizeCheckBox.CheckedChanged += (s, e) => Session.Options.ToggleAutoResizeWindow();

            DebugModeCheckBox.Checked = Session.Options.IsDebugMode;
            DebugModeCheckBox.CheckedChanged += (s, e) => Session.Options.ToggleDebugMode();
        }
        #endregion
    }
}