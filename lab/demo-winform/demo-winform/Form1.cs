using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = (double.Parse(number1.Text) + double.Parse(number2.Text)).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errors");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            result.Text = "";
            number1.Text = "";
            number2.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = (double.Parse(number1.Text) - double.Parse(number2.Text)).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errors");
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = (double.Parse(number1.Text) * double.Parse(number2.Text)).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errors");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                result.Text = (double.Parse(number1.Text) / double.Parse(number2.Text)).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errors");
            }
        }

    }
}
