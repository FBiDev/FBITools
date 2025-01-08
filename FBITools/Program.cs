using System;
using System.Windows.Forms;

namespace FBITools
{
    internal static class Program
    {
        [STAThread]
        internal static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            using (App.Core.Desktop.AppManager.SingleProcess(Session.SystemLock, Session.SystemName))
            {
                Session.Load();
                Application.Run(new MainForm());
            }
        }
    }
}