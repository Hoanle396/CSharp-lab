using BLL;
using DAO;
using DTO;
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

namespace GUI {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e) {
            Student student = new Student(txtStudentID.Text, txtFullName.Text, txtClassID.Text);
            bool res = new StudentBUS().InsertNewRecord(student);
            if (res) {
                MessageBox.Show("Insert student success");
                loadStudents();
            } else {
                MessageBox.Show("Insert Student failed!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            Student student = new Student(txtStudentID.Text, txtFullName.Text, txtClassID.Text);
            bool res = new StudentBUS().UpdateRecord(student);
            if (res) {
                MessageBox.Show("Update student success");
                loadStudents();
            } else {
                MessageBox.Show("Update Student failed!");
            }
        }

        private void lvStudent_SelectedIndexChanged(object sender, EventArgs e) {
            if (lvStudent.SelectedIndices.Count > 0) {
                txtStudentID.Text = lvStudent.SelectedItems[0].SubItems[0].Text;
                txtFullName.Text = lvStudent.SelectedItems[0].SubItems[1].Text;
                txtClassID.Text = lvStudent.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            Student student = new Student(txtStudentID.Text, txtFullName.Text, txtClassID.Text);
            bool res = new StudentBUS().DeleteRecord(student);
            if (res) {
                MessageBox.Show("Delete student success");
                txtStudentID.Text = "";
                txtFullName.Text = "";
                txtClassID.Text = "";
                loadStudents();
            } else {
                MessageBox.Show("Delete Student failed!");
            }
        }
        private void loadStudents() {
            lvStudent.Items.Clear();
            List<Student> students = StudentBUS.GetStudents();
            foreach (Student student in students) {
                ListViewItem item = new ListViewItem(student.StudentID);
                item.SubItems.Add(student.StudentName);
                item.SubItems.Add(student.ClassID);
                lvStudent.Items.Add(item);
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            loadStudents();
        }
    }
}
