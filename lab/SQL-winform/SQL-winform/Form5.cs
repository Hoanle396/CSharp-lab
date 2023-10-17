using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_winform
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            loadStudents();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if(Connect.Instance.State==ConnectionState.Closed) 
                Connect.Instance.Open();
            MySqlCommand cmd = new MySqlCommand($"INSERT INTO `student` (`StudentID`, `StudentName`, `ClassID`) VALUES ('{txtStudentID.Text}', '{txtFullName.Text}', '{txtClassID.Text}')", Connect.Instance); 
            try
            {
                int res = cmd.ExecuteNonQuery();
                if (res <= 0)
                {
                    return;
                }
                loadStudents();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error insert new student");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Connect.Instance.State == ConnectionState.Closed)
                Connect.Instance.Open();
            MySqlCommand cmd = new MySqlCommand($"UPDATE `student` SET `StudentName` = '{txtFullName.Text}', `ClassID` = '{txtClassID.Text}' WHERE `student`.`StudentID` = '{txtStudentID.Text}'", Connect.Instance);
            try
            {
                int res = cmd.ExecuteNonQuery();
                if (res <= 0)
                {
                    return;
                }
                loadStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error update student");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Connect.Instance.State == ConnectionState.Closed)
                Connect.Instance.Open();
            MySqlCommand cmd = new MySqlCommand($"DELETE FROM `student` WHERE `student`.`StudentID` = '{txtStudentID.Text}';", Connect.Instance);
            try
            {
                int res = cmd.ExecuteNonQuery();
                if (res <= 0)
                {
                    return;
                }
                loadStudents();
                txtStudentID.Text = "";
                txtFullName.Text = "";
                txtClassID.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error delete student");
            }
        }

        private void lvStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvStudent.SelectedIndices.Count > 0)
            {
                txtStudentID.Text = lvStudent.SelectedItems[0].SubItems[0].Text;
                txtFullName.Text = lvStudent.SelectedItems[0].SubItems[1].Text;
                txtClassID.Text = lvStudent.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void loadStudents()
        {
            lvStudent.Items.Clear();
            if (Connect.Instance.State == ConnectionState.Closed)
                Connect.Instance.Open();
            MySqlCommand cmd = new MySqlCommand($"select * from student", Connect.Instance);
            var result = cmd.ExecuteReader();
            while (result.Read())
            {
                string studentID = result.GetString(0);
                string name = result.GetString(1);
                string classID = result.GetString(2);
                ListViewItem item = new ListViewItem(studentID);
                item.SubItems.Add(name);
                item.SubItems.Add(classID);
                lvStudent.Items.Add(item);
            }
            Connect.Instance.Close();
        }
    }
}
