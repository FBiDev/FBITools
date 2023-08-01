using GNX;

namespace FBITools
{
    public static class Session
    {
        public static Options options = new Options();

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