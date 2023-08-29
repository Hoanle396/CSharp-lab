using System;

namespace OOP_01_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(3.2f, "Le Huu Hoan", 21);
            student.DisplayPerson();
            student.DisplayStudent();
            student.ToString();
        }
    }
}
