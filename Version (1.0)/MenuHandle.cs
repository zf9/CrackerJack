using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class MenuHandle
    {
        public static void MenuHeader()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine();
            Console.WriteLine("            ▄████▄   ██▀███   ▄▄▄       ▄████▄   ██ ▄█▀▓█████  ██▀███  ▄▄▄██▀▀▀▄▄▄       ▄████▄   ██ ▄█▀");
            Console.WriteLine("            ▒██▀ ▀█  ▓██ ▒ ██▒▒████▄    ▒██▀ ▀█   ██▄█▒ ▓█   ▀ ▓██ ▒ ██▒  ▒██  ▒████▄    ▒██▀ ▀█   ██▄█▒ ");
            Console.WriteLine("            ▒▓█    ▄ ▓██ ░▄█ ▒▒██  ▀█▄  ▒▓█    ▄ ▓███▄░ ▒███   ▓██ ░▄█ ▒  ░██  ▒██  ▀█▄  ▒▓█    ▄ ▓███▄░ ");
            Console.WriteLine("            ▒▓▓▄ ▄██▒▒██▀▀█▄  ░██▄▄▄▄██ ▒▓▓▄ ▄██▒▓██ █▄ ▒▓█  ▄ ▒██▀▀█▄ ▓██▄██▓ ░██▄▄▄▄██ ▒▓▓▄ ▄██▒▓██ █▄ ");
            Console.WriteLine("            ▒ ▓███▀ ░░██▓ ▒██▒ ▓█   ▓██▒▒ ▓███▀ ░▒██▒ █▄░▒████▒░██▓ ▒██▒▓███▒   ▓█   ▓██▒▒ ▓███▀ ░▒██▒ █▄");
            Console.WriteLine("            ░ ░▒ ▒  ░░ ▒▓ ░▒▓░ ▒▒   ▓▒█░░ ░▒ ▒  ░▒ ▒▒ ▓▒░░ ▒░ ░░ ▒▓ ░▒▓░▒▓▒▒░   ▒▒   ▓▒█░░ ░▒ ▒  ░▒ ▒▒ ▓▒");
            Console.WriteLine("              ░  ▒     ░▒ ░ ▒░  ▒   ▒▒ ░  ░  ▒   ░ ░▒ ▒░ ░ ░  ░  ░▒ ░ ▒░▒ ░▒░    ▒   ▒▒ ░  ░  ▒   ░ ░▒ ▒░");
            Console.WriteLine("            ░          ░░   ░   ░   ▒   ░        ░ ░░ ░    ░     ░░   ░ ░ ░ ░    ░   ▒   ░        ░ ░░ ░ ");
            Console.WriteLine("            ░ ░         ░           ░  ░░ ░      ░  ░      ░  ░   ░     ░   ░        ░  ░░ ░      ░  ░   ");
            Console.WriteLine("            ░                           ░                                                ░               ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void ToolHeader()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine();
            Console.WriteLine("            ╦ ╦ ╦ ╔╗╔ ╦═╗ ╔═╗ ╦═╗                    ╔═╗ ╔╦╗ ╔═╗ ╔╗  ╔═╗       ");
            Console.WriteLine("     ╔═══   ║║║ ║ ║║║ ╠╦╝ ╠═╣ ╠╦╝   ═══╗     ╔═══    ╠═╣  ║║ ║ ║ ╠╩╗ ║╣     ═══╗");
            Console.WriteLine("     ║      ╚╩╝ ╩ ╝╚╝ ╩╚═ ╩ ╩ ╩╚═      ║     ║       ╩ ╩ ═╩╝ ╚═╝ ╚═╝ ╚═╝       ║");
            Console.WriteLine("     ║                                 ║     ║                                 ║");
            Console.WriteLine("     ║         [1] Winrar x64          ║     ║        [3] Premier Pro          ║");
            Console.WriteLine("     ║         [2] Winrar x86          ║     ║        [4] Photoshop            ║");
            Console.WriteLine("     ║                                 ║     ║                                 ║");
            Console.WriteLine("     ╚═════════════════════════════════╝     ╚═════════════════════════════════╝");
            Console.WriteLine("     ╔═════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("     ║                                             Adobe In Development        ║");
            Console.WriteLine("     ╚═════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine();
            Console.Write("     Your option : ");
            Console.ForegroundColor = ConsoleColor.White;
            string module = Console.ReadLine();
            if (module == "1")
            {
                Thread Download = new Thread(DownloadHandle.DownloadWinrarx64);
                Download.Start();

                Console.SetCursorPosition(7, 10);
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < 71; i++)
                {

                    Console.Write("■");
                    Thread.Sleep(10);
                }
                Thread.Sleep(1000);
                Console.Clear();
                MenuHandle.ToolHeader();

            }
            if (module == "2")
            {
                Thread Download = new Thread(DownloadHandle.DownloadWinrarx86);
                Download.Start();

                Console.SetCursorPosition(7, 10);
                Console.ForegroundColor = ConsoleColor.Green;
                for (int i = 0; i < 71; i++)
                {

                    Console.Write("■");
                    Thread.Sleep(10);
                }
                Thread.Sleep(1000);
                Console.Clear();
                MenuHandle.ToolHeader();
            }
        }
    }
}
