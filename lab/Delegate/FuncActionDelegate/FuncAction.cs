using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncActionDelegate
{
    internal class FuncAction
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }

        public static void TestFunc(int x, int y)
        {
            Func<int, int, int> calc;    
            
            calc = Sum;                   

            int res = calc(x, y);
            Console.WriteLine(res);
        }

        public static void TestAction(string s)
        {
            Action<string> showLog = null;

            showLog += (msg)=> Console.WriteLine($"[INFO]: {msg}");         
            showLog += (msg) => Console.WriteLine($"[WARING]: {msg}");

            showLog(s);
        }
    }
}
