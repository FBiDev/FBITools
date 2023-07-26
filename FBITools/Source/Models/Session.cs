using System.Drawing;
using System.Windows.Forms;

namespace FBITools
{
    public static class Session
    {
        public static Options options = new Options();

        public static MainForm mainForm;
        public static Form mainContentForm;

        public static Form saveStateForm;
        public static Form memoryCardForm;

        public static void SetIcon()
        {
            GNX.MainBaseForm.ico = GNX.cConvert.ToIco(Properties.Resources.FormIcon, new Size(250, 250));
        }
    }
}