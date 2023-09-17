using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class SingletonPerson
    {
        private int Age { get; set; }
        private SingletonPerson()
        {
            Age = 1;
        }

        public void BirthDay()
        {
            Age += 1;
        }

        public void MyAge()
        {
            Console.WriteLine($"{Age}");
        }

        public static SingletonPerson instance;


        public static SingletonPerson Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SingletonPerson();
                }
                return instance;
            }
        }
    }
}
