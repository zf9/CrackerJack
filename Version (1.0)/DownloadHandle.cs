using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class DownloadHandle
    {
        public static void DownloadWinrarx64()
        {
            using (var client = new WebClient())
            {
                try
                {
                    client.DownloadFile("https://www.rarlab.com/rar/winrar-x64-602.exe", $@"C:\CrackerJackTemp\winrar-x64-602.exe");
                    Thread.Sleep(100);
                    Process.Start(@"C:\CrackerJackTemp\winrar-x64-602.exe", "/s");
                    Thread.Sleep(1000);
                    client.DownloadFile("https://cdn.discordapp.com/attachments/882952460572975134/899788002107215872/rarreg.key", $@"C:\Program Files\WinRAR\rarreg.key");
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.WriteLine("\n   Error Downloading");
                    Thread.Sleep(5000);
                    Environment.Exit(69);
                }
            }
        }

        public static void DownloadWinrarx86()
        {
            using (var client = new WebClient())
            {
                try
                {
                    client.DownloadFile("https://www.rarlab.com/rar/wrar602.exe", $@"C:\CrackerJackTemp\wrar602.exe");
                    Thread.Sleep(100);
                    Process.Start(@"C:\CrackerJackTemp\wrar602.exe", "/s");
                    Thread.Sleep(1000);
                    client.DownloadFile("https://cdn.discordapp.com/attachments/882952460572975134/899788002107215872/rarreg.key", $@"C:\Program Files\WinRAR\rarreg.key");

                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    Console.WriteLine("\n   Error Downloading");
                    Thread.Sleep(5000);
                    Environment.Exit(69);
                }
            }
        }
    }
}
