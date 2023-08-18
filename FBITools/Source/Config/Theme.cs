﻿using BASE = GNX.Desktop;

namespace FBITools
{
    public static class Theme
    {
        public static void SetTheme(BASE.Theme.eTheme newTheme)
        {
            BASE.Theme.SetTheme(newTheme);
        }

        public static bool ToggleDarkMode()
        {
            return BASE.Theme.ToggleDarkMode();
        }
    }
}