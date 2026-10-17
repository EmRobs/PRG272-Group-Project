using System;
using System.Windows.Forms;

namespace Rehabilitation_Records_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new RehabilitationForm());
        }
    }
}
