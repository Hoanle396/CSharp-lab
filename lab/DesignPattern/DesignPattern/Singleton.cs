using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Singleton
    {
        private static Person instance;

        public Singleton(){}

        public static Person GetInstance()
        {
            if (instance == null)
            {
                instance = new Person();
            }
            return instance;
        }
    }
}
