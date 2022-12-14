using System;
using System.Windows.Forms;
using Themerror.EmptyFolderRemover.Core;

namespace Themerror.EmptyFolderRemover
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            // Get initial directory
            var initialDirectory = args.Length > 0
                ? args[0]
                : "";

            // Create cleaner
            var cleaner = new Cleaner();
            
            // Start application
            Application.EnableVisualStyles();
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main(initialDirectory, cleaner));
        }
    }
}
