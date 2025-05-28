using System;
using System.Windows.Forms;

namespace FitnessTracker
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm()); // starts the application with MainForm
        }
    }
}