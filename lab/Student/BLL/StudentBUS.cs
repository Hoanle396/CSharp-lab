using DTO;
using System;
using System.Collections.Generic;

namespace BLL {
    public class StudentBUS {
        public static List<DTO.Student> GetStudents() {
            return new DAO.StudentDAO().listViewStudent();
        }

        public bool InsertNewRecord(Student student) {
            return new DAO.StudentDAO().InsertOneRecord(student);
        }

        public bool DeleteRecord(Student student) {
            return new DAO.StudentDAO().DeleteOneRecord(student);
        }

        public bool UpdateRecord(Student student) {
            return new DAO.StudentDAO().UpdateOneRecord(student);
        }
    }
}
