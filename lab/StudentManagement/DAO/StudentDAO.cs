using DTO;
using MySqlConnector;
using System;
using System.Collections.Generic;

namespace DAO
{
    public class StudentDAO:Connect
    {
        public List<Student> listViewStudent() {
            List<Student> list = new List<Student>();
            try
            {
                // Create List Sql Parameter
                MySqlCommand cmd = new MySqlCommand($"select * from student", this.Instance);
                var result = cmd.ExecuteReader();
                while (result.Read())
                {
                    string studentID = result.GetString(0);
                    string name = result.GetString(1);
                    string classID = result.GetString(2);
                    list.Add(new Student(studentID, name, classID));
                }
                this.Instance.Close();
                return list;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
