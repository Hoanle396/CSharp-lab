using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchFrom {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        DataTable ds = null;
        MySqlDataAdapter adapter = null;
        private void Form1_Load(object sender, EventArgs e) {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            adapter = Connect.Adapter($"SELECT * from student where StudentName like '%{txtSearch.Text}%'");
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

            ds = new DataTable();

            adapter.Fill(ds);
            dtgStudent.DataSource = ds;
        }
    }
}
