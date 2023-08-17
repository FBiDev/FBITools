using System;
using System.Threading;
using System.Windows.Forms;

namespace FBITools
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            GNX.Desktop.AppManager.SingleProcess(Config.Singleton, new Mutex(true, Config.SystemName), Config.SystemName);
            Config.Start();

            Application.Run(new MainForm());
        }
    }
}