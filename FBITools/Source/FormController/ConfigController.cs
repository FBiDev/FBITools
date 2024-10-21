namespace FBITools
{
    public partial class ConfigController
    {
        #region Entrada
        public ConfigController(ConfigForm formView)
        {
            form = formView;
            form.Shown += form_Shown;
            form.GotFocus += (s, e) => chkDarkMode.Focus();
            form.TabStop = false;
        }

        void form_Shown(object sender, System.EventArgs ev)
        {
            //Initial Value
            chkDarkMode.Checked = Session.Options.IsDarkMode;
            chkDarkMode.CheckedChanged += (s, e) => Session.Options.ToggleDarkMode();

            chkAutoCenterWindow.Checked = Session.Options.IsAutoCenterWindow;
            chkAutoCenterWindow.CheckedChanged += (s, e) => Session.Options.ToggleAutoCenterWindow();

            chkAutoResizeWindow.Checked = Session.Options.IsAutoResizeWindow;
            chkAutoResizeWindow.CheckedChanged += (s, e) => Session.Options.ToggleAutoResizeWindow();

            chkDebugMode.Checked = Session.Options.IsDebugMode;
            chkDebugMode.CheckedChanged += (s, e) => Session.Options.ToggleDebugMode();
        }
        #endregion
    }
}