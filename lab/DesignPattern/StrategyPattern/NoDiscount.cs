using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class NoDiscount:Strategy
    {
        public float DoDiscount(float price)
        {
            return price;
        }
    }
}
