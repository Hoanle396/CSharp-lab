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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            if(Connect.Instance.State==ConnectionState.Closed)
                Connect.Instance.Open();
            MySqlCommand cmd = new MySqlCommand($"SELECT count(*) from student where ClassID='{txtClassID.Text}'", Connect.Instance);
            var result =  cmd.ExecuteScalar();
            txtNumberOfStudent.Text = result.ToString();
            Connect.Instance.Close();
        }
    }
}
