using System;
using System.Windows.Forms;

namespace FBITools
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            BIND.SetIcon();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}