using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02_02
{
    class Duck : Animal
    {
        public string Name { get; }

        public Duck(string name) : base("Bird")
        {
            Name = name;
        }

        public override string MakeSound()
        {
            return "Quack!";
        }

        public override string GetInfo()
        {
            return $"Type: {Type}, Name: {Name}";
        }

        public void Swim(string placeToSwim)
        {
            Console.WriteLine($"The duck named {Name} is swimming in {placeToSwim}.");
        }
    }
}
