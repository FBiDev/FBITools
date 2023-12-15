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

            GNX.Desktop.AppManager.SingleProcess(Session.Singleton, new Mutex(true, Session.SystemName), Session.SystemName);
            Session.Start();

            Application.Run(new MainForm());
        }
    }
}