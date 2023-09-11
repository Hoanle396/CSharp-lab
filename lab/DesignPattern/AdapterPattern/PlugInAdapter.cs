using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal class PlugInAdapter
    {
       private PowerSocket powerSocket ;

        public PlugInAdapter(PowerSocket powerSocket)
        {
            this.powerSocket = powerSocket;
        }

        public void Charging(int x,int y)
        {
            int z = (int) Math.Sqrt(x*x + y*y);
            powerSocket.Charging(x, y, z);
        }
    }
}
