using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_02
{
    internal class Student
    {
        private int SID;
        private string TenSV;
        private string Khoa;
        private float DiemTB;

        public Student()
        {
        }

        public void setID(int id)
        {
            SID = id;
        }
        public int getID()
        {
            return SID;
        }

        public void setName(string name)
        {
            TenSV = name;
        }

        public string getName()
        {
            return TenSV;
        }

        public void setDepartment(string department)
        {
            Khoa = department;
        }

        public string getDepartMent()
        {
            return Khoa;
        }

        public void setPoint(float point)
        {
            DiemTB = point;
        }

        public float getPoint()
        {
            return DiemTB;
        }

        public Student(Student student)
        {
            SID = student.SID;
            TenSV = student.TenSV;
            Khoa = student.Khoa;
            DiemTB = student.DiemTB;
        }

        public Student(int id, String name, String khoa, float diem)
        {
            SID = id;
            TenSV = name;
            Khoa = khoa;
            DiemTB = diem;
        }
        public void PrintInformation()
        {
            Console.WriteLine($"- MSSV:{SID} - Ten SV:{TenSV} - Khoa:{Khoa} - Diem TB:{DiemTB}");
        }

        public void NhapSV()
        {
            Console.Write("Nhap MaSV :");
            SID = int.Parse(Console.ReadLine());
            Console.Write("Ho ten SV:");
            TenSV = Console.ReadLine();
            Console.Write("Nhap khoa:");
            Khoa = Console.ReadLine();
            Console.Write("Nhap Diem TB:");
            DiemTB = float.Parse(Console.ReadLine());
        }
    }
}
