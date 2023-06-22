using System.Drawing;
using System.Windows.Forms;

namespace FBITools
{
    public static class BIND
    {
        public static Config cfg = new Config();
        public static Form form;

        public static void SetIcon()
        {
            GNX.FormBase.ico = GNX.cConvert.ToIco(Properties.Resources.FormIcon, new Size(250, 250));
        }
    }
}