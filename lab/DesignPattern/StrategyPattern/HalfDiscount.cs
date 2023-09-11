using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class HalfDiscount : Strategy
    {
        float Strategy.DoDiscount(float price)
        {
            return (float)(price * 0.8);
        }
    }
}
