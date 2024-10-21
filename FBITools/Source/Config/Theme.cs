using App.Core.Desktop;

namespace FBITools
{
    public static class Theme
    {
        public static bool DesignMode = true;

        public static bool ToggleDarkTheme()
        {
            if (DesignMode) return false;

            return ThemeBase.ToggleDarkMode();
        }

        public static void SetTheme()
        {
            DesignMode = Session.MainForm.IsDesignMode;
            if (DesignMode) return;

            if (Session.Options.IsDarkMode)
                ThemeBase.SetTheme(ThemeBase.ThemeNames.Dark);
            else
                ThemeBase.SetTheme(ThemeBase.ThemeNames.Light);
        }
    }
}