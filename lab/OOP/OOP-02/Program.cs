using System;

namespace OOP_02
{
    internal class Program
    {
        static public Student[] NhapDS()
        {
            Console.WriteLine("Nhap so luong sv");
            int n = int.Parse(Console.ReadLine());
            Student[] students = new Student[n];
            Console.WriteLine("Hello World!");
            Console.WriteLine("\n ====NHAP DS SINH VIEN====");
            for (int i = 0; i < n; i++)
            {
                students[i] = new Student();
                students[i].NhapSV();
            }
            return students;
        }

        static public void XuatDS(Student[] students)
        {
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            foreach (Student sv in students)
                sv.PrintInformation();
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Student[] student = NhapDS();
            XuatDS(student);
        }
    }
}
