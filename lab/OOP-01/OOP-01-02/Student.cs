using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOP_01_02
{
    internal class Student:Person
    {
        private float gpa;

        public Student(float gpa,string name, int age) : base(name,age)
        {
            Age = age;
            Name = name;
            this.gpa = gpa;
        }

        public float Gpa
        {
            get { return gpa; }
            set {
                if (value < 0 || value > 4) gpa = 0;
                else gpa = value;
            }
        }

        public void DisplayStudent()
        {
            Console.WriteLine($"gpa : {gpa}");
        }
        
        public void Input()
        {
            Console.WriteLine("GPA: ");
            gpa = float.Parse( Console.ReadLine() );
        }
    }
}
