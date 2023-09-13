using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_03
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace OOP
    {
        internal class Student: People
        {


            public int SID { get; set; }
            public String Khoa { get; set; }
            public float DiemTB { get; set; }

            public Student()
            {
            }
            public Student(int id, String name,int age, String khoa, float diem):base(name,age)
            {
                SID = id;
                Khoa = khoa;
                DiemTB = diem;
            }
            public void PrintInformation()
            {
                Console.WriteLine($"- MSSV:{SID} - Ten:{Name} - Age:{Age} - Khoa:{Khoa} - Diem TB:{DiemTB}");
            }

            public void NhapSV()
            {
                Console.Write("Nhap MaSV :");
                SID = int.Parse(Console.ReadLine());
                Console.Write("Ho ten SV:");
                Name = Console.ReadLine();
                Console.Write("Nhap Age:");
                Age = int.Parse(Console.ReadLine());
                Console.Write("Nhap khoa:");
                Khoa = Console.ReadLine();
                Console.Write("Nhap Diem TB:");
                DiemTB = float.Parse(Console.ReadLine());
            }
        }
    }

}
