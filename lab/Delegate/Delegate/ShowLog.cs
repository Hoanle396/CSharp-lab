using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class ShowLogs
    {
        public delegate void ShowLog(string message);
        static public void Info(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"[INFO]: {msg}");
            Console.ResetColor();
        }

        static public void Warning(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[WARNING]: {msg}");
            Console.ResetColor();

        }
        public static void TestShowLog()
        {
            ShowLog showLog;

            showLog = Info;
            showLog("Application started");

            showLog = Warning;
            showLog("System.Linq defined but not use");
        }

        public static void TestShowLogMulti()
        {
            ShowLog showLog = null;
            showLog += Warning;
            showLog += Info;
            showLog += Warning;
            showLog("Application log");

        }

        public static void TestShowLogPlus()
        {
            ShowLog showLog1 = (x) => { Console.WriteLine($"-----{x}-----"); };
            ShowLog showLog2 = Warning;
            ShowLog showLog3 = Info;

            var all = showLog1 + showLog2 + showLog3 + showLog1;

            all("Hi!");
        }
    }
}
