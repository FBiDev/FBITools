namespace FBITools
{
    public partial class ConfigController
    {
        #region Entrada
        public static void Init(ConfigForm formView)
        {
            form = formView;

            //Initial Value
            chkDarkMode.Checked = Session.Options.DarkMode;
            chkDarkMode.CheckedChanged += (s, e) => Session.Options.ToggleDarkMode();

            chkDebugMode.Checked = Session.Options.DebugMode;
            chkDebugMode.CheckedChanged += (s, e) => Session.Options.ToggleDebugMode();
        }
        #endregion
    }
}