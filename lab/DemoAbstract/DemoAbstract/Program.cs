using System;

namespace DemoAbstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.name = "Duck";
            animal.PrintInformation();
        }
    }
}
