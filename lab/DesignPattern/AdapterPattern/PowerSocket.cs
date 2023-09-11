using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    internal interface PowerSocket
    {
          void Charging(int x,int y,int z);
    }
}
