using System;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();
            context.SetContext(new HalfDiscount());
            Console.WriteLine($"Price = {context.GetPrice(50000)}");

            context.SetContext(new NoDiscount());
            Console.WriteLine($"Price = {context.GetPrice(50000)}");
        }
    }
}
