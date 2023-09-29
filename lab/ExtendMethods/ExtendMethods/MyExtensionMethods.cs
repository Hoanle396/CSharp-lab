using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtendMethods
{
    internal static class MyExtensionMethods
    {
        public static void Print(this string s, ConsoleColor color = ConsoleColor.Yellow)
        {
            ConsoleColor lastColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(s);
            Console.ForegroundColor = lastColor;
        }
    }
}
