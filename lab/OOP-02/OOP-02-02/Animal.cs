using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02_02
{
    abstract class Animal
    {
        public string Type { get; }

        public Animal(string type)
        {
            Type = type;
        }

        public abstract string MakeSound();

        public abstract string GetInfo();
    }

}
