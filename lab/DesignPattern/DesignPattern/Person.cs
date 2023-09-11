using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    internal class Person
    {
        private int Age { get; set; }
        public Person()
        {
            Age = 1;
        }

        public void BirthDay()
        {
            Age += 1;
        }

        public void MyAge()
        {
            Console.WriteLine($"{Age}");
        }
    }
}
