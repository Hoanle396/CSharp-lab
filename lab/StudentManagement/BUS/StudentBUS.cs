using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS {
    public class StudentBUS {
        public static List<Student> GetStudents() {
            return new StudentDAO().listViewStudent();
        }
    }
}
