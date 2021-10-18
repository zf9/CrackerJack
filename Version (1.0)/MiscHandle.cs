using System;
using System.IO;
using System.Security.Principal;
using System.Threading;

namespace ConsoleApp8
{
    class MiscHandle
    {
        public static void Administrator()
        {
            bool isElevated;
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
            {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                isElevated = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }

            if (isElevated)
            {
                Console.Title = $"CrackerJack    |    Winrar    |    Adobe    |    [ Administrator Permissions ]";
                TempFolder();
                MenuHandle.ToolHeader();
            }
            else
            {
                Console.Title = $"CrackerJack    |    Winrar    |    Adobe";
                MenuHandle.MenuHeader();
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n\n            Please restart the application with administrator permissions.");
                Thread.Sleep(5000);
                Environment.Exit(69);
            }
        }

        public static void TempFolder()
        {
            if (!Directory.Exists(@"C:\CrackerJackTemp"))
            {
                Directory.CreateDirectory(@"C:\CrackerJackTemp");
            }
        }
    }
}
