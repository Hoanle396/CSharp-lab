using System;
using System.Reflection;

namespace EX4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICars seat = new Seat("Leon","Grey");
            ICars tesla = new Tesla("Model 3","Tesla",2);
            Console.WriteLine(seat.ToString());
            Console.WriteLine(tesla.ToString());
        }
    }
}
