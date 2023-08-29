using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02_02
{
    class Dog : Animal
    {
        public string Name { get; }
        public string Breed { get; }

        public Dog(string name, string breed) : base("Mammal")
        {
            Name = name;
            Breed = breed;
        }

        public override string MakeSound()
        {
            return "Woof!";
        }

        public override string GetInfo()
        {
            return $"Type: {Type}, Name: {Name}, Breed: {Breed}";
        }
    }
}
