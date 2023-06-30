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

        protected override void DarkTheme(Form f)
        {
            base.DarkTheme(f);

            //if (f is ContentBaseForm)
            //    ((ContentBaseForm)f).BackColor = Color.WhiteSmoke;
            //if (f is MainBaseForm)
            //    ((MainBaseForm)f).BackColor = Color.Red;
        }
    }
}