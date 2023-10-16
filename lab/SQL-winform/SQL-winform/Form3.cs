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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            txtClassIDRes.Text = "";
            txtClassName.Text = "";
            txtYear.Text = "";
            if (Connect.Instance.State == ConnectionState.Closed)
                Connect.Instance.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT * from class where ClassID='{txtClassID.Text}'", Connect.Instance);
            var result = cmd.ExecuteReader();
            if (result.Read())
            {
                txtClassIDRes.Text = result.GetString(0);
                txtClassName.Text = result.GetString(1);
                txtYear.Text = result.GetUInt32(2).ToString();
            }
            Connect.Instance.Close();
        }

        private void btnViewListStudent_Click(object sender, EventArgs e)
        {
            lvStudent.Items.Clear();
            if (Connect.Instance.State == ConnectionState.Closed)
                Connect.Instance.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT * from student where ClassID='{txtClassID.Text}'", Connect.Instance);
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
