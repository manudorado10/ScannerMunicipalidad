using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

//using System.Runtime.InteropServices;
//using System.Security;

namespace ScannerMuni
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //AsignarConsola();
            Application.Run(new Scanner());
            //LiberarConsola();
        }
        /*
        public static int AsignarConsola()
        {
            return AllocConsole() ? 0 : Marshal.GetLastWin32Error();
        }

        public static int LiberarConsola()
        {
            return FreeConsole() ? 0 : Marshal.GetLastWin32Error();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage(
          "Microsoft.Security",
          "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage"),
          SuppressUnmanagedCodeSecurity]
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        [System.Diagnostics.CodeAnalysis.SuppressMessage(
          "Microsoft.Security",
          "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage"),
          SuppressUnmanagedCodeSecurity]
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool FreeConsole();
        */

    }
}
