using System;

namespace DTO
{
    public class Student
    {
        public string StudentID { get; set; }
        public string StudentName { get; set; }
        public string ClassID { get; set; }

        public Student(string StudentID,string StudentName, string ClassID)
        {
            this.StudentID = StudentID;
            this.StudentName = StudentName;
            this.ClassID = ClassID;
        }

    }
}
