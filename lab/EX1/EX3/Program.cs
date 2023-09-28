using System;
using System.Collections.Generic;

namespace EX3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student { ID = 1, Name = "John", Age = 20 },
                new Student { ID = 2, Name = "Alice", Age = 22 },
                new Student { ID = 3, Name = "Bob", Age = 21 },
                new Student { ID = 4, Name = "Emma", Age = 19 }
            };

            // Sort the list by Name
            students.Sort((student1, student2) => student1.Name.CompareTo(student2.Name));

            // Print the sorted list
            foreach (Student student in students)
            {
                Console.WriteLine($"ID: {student.ID}, Name: {student.Name}, Age: {student.Age}");
            }
        }
    }
}
