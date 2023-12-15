using GNX.Desktop;

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
            DesignMode = Session.MainForm.isDesignMode;
            if (DesignMode) return;

            if (Session.Options.DarkMode)
                ThemeBase.SetTheme(ThemeBase.ThemeNames.Dark);
            else
                ThemeBase.SetTheme(ThemeBase.ThemeNames.Light);
        }
    }
}