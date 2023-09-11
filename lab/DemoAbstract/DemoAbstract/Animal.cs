using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAbstract
{
    internal class Animal
    {
        public String name;

        public void PrintInformation()
        {
            Console.WriteLine($"Hello :{name}");
        }
    }
}
