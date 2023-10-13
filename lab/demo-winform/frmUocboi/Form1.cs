using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmUocboi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           DialogResult res= MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                base.Close();
            }

        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            txtA.Text = string.Empty;
            txtB.Text = string.Empty;
            txtResult.Text = string.Empty;
            uscln.Checked = false;
            bscnn.Checked = false;
        }

        private void find_Click(object sender, EventArgs e)
        {
            try
            {
                if (bscnn.Checked == true)
                {
                    txtResult.Text = BSCNN(double.Parse(txtA.Text), double.Parse(txtB.Text)).ToString();

                }
                else
                        if (uscln.Checked == true)
                {
                    txtResult.Text = USCLN(double.Parse(txtA.Text), double.Parse(txtB.Text)).ToString();
                }
                    

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errors");
            }
           
        }

        private double USCLN(double a, double b)
        {
            if (b == 0) return a;
            return USCLN(b, a % b);
        }
        private double BSCNN(double a, double b)
        {
            return (a * b) / USCLN(a, b);
        }
    }
}
