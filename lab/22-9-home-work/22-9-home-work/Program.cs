


using System;

namespace _22_9_home_work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookList bl = new BookList();
            bl.InputList();
            bl.ShowList();

            // bl.SortByTitle();
            // Console.WriteLine("After sort by title:");
            // bl.ShowList();

            bl.SortByYear();
            Console.WriteLine("After sort by year:");
            bl.ShowList();
        }
    }
}
