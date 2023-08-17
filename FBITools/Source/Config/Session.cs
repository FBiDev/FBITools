using GNX.Desktop;

namespace FBITools
{
    public static class Session
    {
        public static OptionsFile options = new OptionsFile();

        public static MainForm mainForm;
        public static MainContentForm mainContentForm;

        public static SaveStateForm saveStateForm;
        public static MemoryCardForm memoryCardForm;

        public static void SetIcon()
        {
            MainBaseForm.ico = Properties.Resources.FormIcon;
        }
    }
}