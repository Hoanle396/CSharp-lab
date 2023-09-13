using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student[] student;
            int n;
            Console.WriteLine("Nhap so luong sv");

            n = int.Parse(Console.ReadLine());
            student = new Student[n]; //tao mang n phan tu
            Console.WriteLine("\n ====NHAP DS SINH VIEN====");
            for (int i = 0; i < n; i++) //Lap n lan nhap thong tin sv
            {
                student[i] = new Student();
                Console.Write("Nhap MaSV {0}:", i + 1);
                student[i].SID = int.Parse(Console.ReadLine());
                Console.Write("Ho ten SV:");
                student[i].TenSV = Console.ReadLine();
                Console.Write("Nhap khoa:");
                student[i].Khoa = Console.ReadLine();
                Console.Write("Nhap Diem TB:");
                student[i].DiemTB = float.Parse(Console.ReadLine());
            }
            //Xuat DS Sinh vien
            Console.WriteLine("\n ====XUAT DS SINH VIEN====");
            foreach (Student sv in student)
                sv.PrintInformation();
            Console.ReadLine();
        }
    }
}
