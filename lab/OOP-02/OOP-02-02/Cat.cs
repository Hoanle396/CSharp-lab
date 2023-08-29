using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02_02
{
    class Cat : Animal
    {
        public string Name { get; }

        public Cat(string name) : base("Mammal")
        {
            Name = name;
        }

        public override string MakeSound()
        {
            return "Meow!";
        }

        public override string GetInfo()
        {
            return $"Type: {Type}, Name: {Name}";
        }

        public void Climb(string objectToClimb)
        {
            Console.WriteLine($"The cat named {Name} is climbing {objectToClimb}.");
        }
    }
}
