using Microsoft.Data.SqlClient;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void lsbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvStudent.Items.Clear();
            if (lsbClass.SelectedIndex == -1) return;
            string classId = lsbClass.SelectedItem.ToString()
                .Split("-")[0];

            if (Connect.Instance.State == ConnectionState.Closed)
                Connect.Instance.Open();
            MySqlCommand cmd = new MySqlCommand($"select * from student where ClassID='{classId}'", Connect.Instance);
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

        private void Form4_Load(object sender, EventArgs e)
        {
            if(Connect.Instance.State==ConnectionState.Closed)
                Connect.Instance.Open();
            MySqlCommand cmd = new MySqlCommand("select * from class", Connect.Instance);
            lsbClass.ClearSelected();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string classID= reader.GetString(0);
                string className= reader.GetString(1);
                int Year= reader.GetInt32(2);

                string line = classID+"-"+ className+"  -"+Year.ToString();
                lsbClass.Items.Add(line);
            }
            Connect.Instance.Close();
        }
    }
}
