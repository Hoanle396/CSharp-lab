using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    class Assassin : IDuck
    {
        public void Action() {
            Console.WriteLine("I can take down other duck");
        }
    }
}
