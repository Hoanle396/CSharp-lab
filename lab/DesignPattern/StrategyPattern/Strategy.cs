﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal  interface Strategy
    {
        float DoDiscount(float price);
    }
}
