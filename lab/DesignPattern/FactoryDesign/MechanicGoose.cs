using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    internal class MechanicGoose : IDuck
    {
        public void Action()
        {
            Console.WriteLine("I can do repair duty");
        }
    }
}
