using System;
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

            using (App.Core.Desktop.AppManager.SingleProcess(Session.SystemLock, Session.SystemName))
            {
                Session.Start();
                Application.Run(new MainForm());
            }
        }
    }
}