using App.Core.Desktop;

namespace FBITools
{
    public static class Theme
    {
        private static bool _isDesignMode = true;

        public static bool ToggleDarkTheme()
        {
            return !_isDesignMode && ThemeBase.ToggleDarkMode();
        }

        public static void SetTheme()
        {
            _isDesignMode = Session.MainPage.IsDesignMode;

            if (_isDesignMode)
            {
                return;
            }

            ThemeBase.SetTheme(Session.Options.IsDarkMode ? ThemeBase.ThemeNames.Dark : ThemeBase.ThemeNames.Light);
        }
    }
}