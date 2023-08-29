using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_01_02
{
    internal class Person
    {
        private int age;
        private string name;


        public Person(string name,int age) {
            this.name = name;
            this.age = age;
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0 || value > 100) age = 0;
                else age = value;
            }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void DisplayPerson()
        {
            Console.WriteLine($"name: {name}");
            Console.WriteLine($"age: {age}");
        }

        public override string ToString()
        {
            return $"[ name:{name},age:{age}]";
        }

        public void Input()
        {
            Console.WriteLine("name:");
            name = Console.ReadLine();
            Console.WriteLine();
            age = int.Parse( Console.ReadLine() );
        }
    }
}
