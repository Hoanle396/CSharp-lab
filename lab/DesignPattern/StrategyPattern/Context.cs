using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Context
    {
        private Strategy strategy;

        public Context(){}
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }
        public void SetContext(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public float GetPrice(float price)
        {
            return strategy.DoDiscount(price);
        }
    }
}
