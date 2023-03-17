using GreatSportEventApp.BasicForms;
using System;
using System.Windows.Forms;

namespace GreatSportEventApp
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            _ = Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);

            MainForm mainForm = new();
            Application.Run(mainForm);
            return;
        }
    }
}
