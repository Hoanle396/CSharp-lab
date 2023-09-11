using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesign
{
    class DuckFactory
    {
        public static IDuck GetDuck(string duckType)
        {
            switch (duckType)
            {
                case "Assassin":
                    return new Assassin();
                case "Mechanic":
                    return new MechanicGoose();
                case "Medium":
                    return new MediumGoose();
                default:
                    throw new Exception("This duck type is unsupported");
            }
        }
    }
}
