using App.Core.Desktop;

namespace FBITools
{
    public static class Theme
    {
        private static bool isDesignMode = true;

        public static bool ToggleDarkTheme()
        {
            if (isDesignMode)
            {
                return false;
            }

            return ThemeBase.ToggleDarkMode();
        }

        public static void SetTheme()
        {
            isDesignMode = Session.MainForm.IsDesignMode;

            if (isDesignMode)
            {
                return;
            }

            if (Session.Options.IsDarkMode)
            {
                ThemeBase.SetTheme(ThemeBase.ThemeNames.Dark);
            }
            else
            {
                ThemeBase.SetTheme(ThemeBase.ThemeNames.Light);
            }
        }
    }
}