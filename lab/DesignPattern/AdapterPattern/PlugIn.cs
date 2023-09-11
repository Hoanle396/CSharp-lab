using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class PlugIn : PowerSocket
    {
        public void Charging(int x,int y,int z)
        {
            Console.WriteLine($"Charging computer {x} {y} {z}");
        }
    }
}
