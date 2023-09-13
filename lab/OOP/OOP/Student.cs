using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Student
    {
      

        public int SID { get; set; }
        public String TenSV { get; set; }
        public String Khoa { get; set; }
        public float DiemTB { get; set; }

        public Student()
        {
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
    }
}
