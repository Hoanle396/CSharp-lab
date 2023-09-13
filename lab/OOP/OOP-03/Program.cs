using OOP_03.OOP;
using System;
using System.Collections;
using System.Collections.Generic;

namespace OOP_03
{
    internal class Program
    {
        static public List<Student> NhapDS()
        {
            Console.WriteLine("Nhap so luong sv");
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            Console.WriteLine("Hello World!");
            Console.WriteLine("\n ====NHAP DS SINH VIEN====");
            for (int i = 0; i < n; i++)
            {
                Student std = new Student();
                std.NhapSV();
                students.Add(std);
            }
            return students;
        }

        static public void XuatDS(List<Student> students)
        {
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            foreach (Student sv in students)
                sv.PrintInformation();
            Console.ReadLine();
        }

        static public ArrayList ANhapDS()
        {
            Console.WriteLine("Nhap so luong sv");
            int n = int.Parse(Console.ReadLine());
            ArrayList students = new ArrayList();
            Console.WriteLine("Hello World!");
            Console.WriteLine("\n ====NHAP DS SINH VIEN====");
            for (int i = 0; i < n; i++)
            {
                Student std = new Student();
                std.NhapSV();
                students.Add(std);
            }
            return students;
        }

        static public void AXuatDS(ArrayList students)
        {
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            foreach (Student sv in students)
                sv.PrintInformation();
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            List<Student> student = NhapDS();
            XuatDS(student);

            ArrayList std2 = ANhapDS();

            AXuatDS(std2);

        }
    }
}
