using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winform_sqldata_adapter
{
    public partial class Form1 : Form
    {
        DataTable ds = null;
        MySqlDataAdapter adapter = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             adapter = Connect.Adapter("SELECT * from student");
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);

            ds = new DataTable();

            adapter.Fill(ds);
        }

        int position = -1;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = e.RowIndex;

            if (position == -1)
            {
                MessageBox.Show("No row selected");
                return;
            }

            DataRow row = ds.Rows[position];

            txtStudentID.Text = row[0].ToString();
            txtFullName.Text = row[1].ToString();
            txtClassID.Text = row[2].ToString();

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            DataRow row = ds.NewRow();
            row[0]=txtStudentID.Text;
            row[1]=txtFullName.Text;
            row[2]=txtClassID.Text;

            ds.Rows.Add(row);
            try
            {
                adapter.Update(ds);
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (position == -1)
            {
                MessageBox.Show("No row selected");
                return;
            }
            DataRow row = ds.Rows[position];
            row.BeginEdit();
            row[0] = txtStudentID.Text;
            row[1] = txtFullName.Text;
            row[2] = txtClassID.Text;
            row.EndEdit();
            int res= adapter.Update(ds);

            if(res>0)
            {
                MessageBox.Show("Updated successfully");
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (position == -1)
                return;
            DataRow row = ds.Rows[position];
            row.Delete();
            int res = adapter.Update(ds);

            if (res > 0)
            {
                MessageBox.Show("Delete successfully");
            }
            else
            {
                MessageBox.Show("Delete Failed");
            }
        }

        private void btnLoadStudent_Click(object sender, EventArgs e)
        {
            dtgStudent.DataSource = ds;
            using (StreamWriter writer = new StreamWriter("D:\\log.txt"))
            {
                foreach (DataRow row in ds.Rows)
                {
                    foreach (DataColumn column in ds.Columns)
                    {
                        writer.WriteLine($"{column.ColumnName}: {row[column]}");
                    }
                    writer.WriteLine("--------------------");
                }
            }

        }
    }
}
