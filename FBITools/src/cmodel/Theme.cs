using GNX;

namespace FBITools
{
    public class Theme : GNX.Theme
    {
        public static new void SetTheme(eTheme newTheme)
        {
            Instance = new Theme();
            GNX.Theme.SetTheme(newTheme);
        }

        protected override void DarkFlatButton(FlatButton c)
        {
            base.DarkFlatButton(c);
            //c.BackgroundColor = Color.Red;
        }
    }
}