using System;

namespace DesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person single1 = Singleton.GetInstance();
            Person single2 = Singleton.GetInstance();
            single1.BirthDay();
            single2.MyAge();

            if (single1 == single2)
            {
                Console.WriteLine("Unique Instance");
            }

        }
    }
}
