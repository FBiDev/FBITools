using GNX;
using GNX.Desktop;

namespace FBITools
{
    public static class Config
    {
        public static bool Singleton = true;
        public const string SystemName = "FBITools";

        public static CultureID Language = CultureID.Brazil_Portuguese;
        public static CultureID LanguageNumbers = CultureID.Brazil_Portuguese;

        public static void Start()
        {
            LanguageManager.SetLanguage(Language);
            LanguageManager.SetLanguageNumbers(LanguageNumbers);
            AppManager.Start();

            //Banco.Load();
            //Banco.ConfigLoaded = true;
        }
    }
}
