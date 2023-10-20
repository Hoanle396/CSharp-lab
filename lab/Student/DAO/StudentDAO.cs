using DTO;
using MySqlConnector;
using System;
using System.Collections.Generic;

namespace DAO {
    public class StudentDAO : Connect {

        public List<Student> listViewStudent() {
            List<Student> list = new List<Student>();
            try {
                // Create List Sql Parameter
                MySqlCommand cmd = new MySqlCommand($"select * from student", this.Instance);
                var result = cmd.ExecuteReader();
                while (result.Read()) {
                    string studentID = result.GetString(0);
                    string name = result.GetString(1);
                    string classID = result.GetString(2);
                    list.Add(new Student(studentID, name, classID));
                }
                this.Instance.Close();
                return list;

            } catch (Exception ex) {
                throw ex;
            }
        }

        public bool InsertOneRecord(Student student) {
            try {
                string sql = $"INSERT INTO `student` (`StudentID`, `StudentName`, `ClassID`) VALUES ('{student.StudentID}', '{student.StudentName}', '{student.ClassID}')";
                MySqlCommand cmd = new MySqlCommand(sql, this.Instance);
                int result = cmd.ExecuteNonQuery();
                if (result == 1) {
                    return true;
                } else {
                    return false;
                }
            } catch (Exception ex) {
                return false;
            }
        }

        public bool UpdateOneRecord(Student student) {
            string sql = $"UPDATE `student` SET `StudentName` = '{student.StudentName}', `ClassID` = '{student.ClassID}' WHERE `student`.`StudentID` = '{student.StudentID}'";
            MySqlCommand cmd = new MySqlCommand(sql,this.Instance);
            try {
                int res = cmd.ExecuteNonQuery();
                if (res <= 0) {
                    return false;
                }
                return true;
            } catch (Exception ex) {
                return false;
            }
        }
        public bool DeleteOneRecord(Student student) {
            MySqlCommand cmd = new MySqlCommand($"DELETE FROM `student` WHERE `student`.`StudentID` = '{student.StudentID}';", this.Instance);
            try {
                int res = cmd.ExecuteNonQuery();
                if (res <= 0) {
                    return false;
                }
                return true;

            } catch (Exception ex) {
                return false;
            }
        }


    }
}
