using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;
using DTO;
using BUS;

namespace GUI {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e) {
            lvStudent.Items.Clear();
            List<Student> students = StudentBUS.GetStudents();
            foreach (Student student in students) {
                ListViewItem item = new ListViewItem(student.StudentID);
                item.SubItems.Add(student.StudentName);
                item.SubItems.Add(student.ClassID);
                lvStudent.Items.Add(item);
            }
        }
    }
}
