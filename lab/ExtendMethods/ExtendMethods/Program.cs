using System.Linq;
using System.Collections.Generic;
using System;

namespace ExtendMethods
{
    internal class Program
    {
        public static void Print(string s, ConsoleColor color = ConsoleColor.Yellow)
        {
            ConsoleColor lastColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(s);
            Console.ForegroundColor = lastColor;
        }

        static void Main(string[] args)
        {
            List<int> ls = new List<int>() { 1, 2, 3, 4 };
            var ps = ls.Where(i => i >= 3);

            string s = "test string";
            s.Print();
            "Hello world".Print(ConsoleColor.Red);

        }
    }
}
