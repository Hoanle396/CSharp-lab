using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    internal class People
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public People()
        {
            
        }

        public People(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
