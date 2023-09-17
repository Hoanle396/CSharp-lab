using System;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingletonPerson single1 = SingletonPerson.Instance;
            SingletonPerson single2 = SingletonPerson.Instance;
            single1.BirthDay();
            single2.MyAge();

            if (single1 == single2)
            {
                Console.WriteLine("Unique Instance");
            }

        }
    }
}
