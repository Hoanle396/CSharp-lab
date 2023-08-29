using System;

namespace OOP_02_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Max", "Spaniel");
            Console.WriteLine(dog.MakeSound());
            Console.WriteLine(dog.GetInfo());
            Console.WriteLine();

            Cat cat = new Cat("Whiskers");
            Console.WriteLine(cat.MakeSound());
            Console.WriteLine(cat.GetInfo());
            cat.Climb("a tree");
            Console.WriteLine();

            Duck duck = new Duck("Donald");
            Console.WriteLine(duck.MakeSound());
            Console.WriteLine(duck.GetInfo());
            duck.Swim("a pond");
        }
    }
}
