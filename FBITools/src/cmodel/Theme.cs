using GNX;
using System.Drawing;
using System.Windows.Forms;
namespace FBITools
{
    public class Theme : GNX.Theme
    {
        public static new void SetTheme(eTheme newTheme)
        {
            _inst = new Theme();
            SelectedTheme = newTheme;
        }

        protected override void LightTheme(Form f)
        {
            base.LightTheme(f);
        }

        protected override void DarkTheme(Form f)
        {
            base.DarkTheme(f);
        }
    }
}