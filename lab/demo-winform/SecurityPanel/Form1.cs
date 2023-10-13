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

namespace SecurityPanel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn1_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text += "0";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                string msg;
                int code = int.Parse(txtSecurityCode.Text);
                switch (code)
                {
                    case 1645:
                    case 1689:
                        msg = $"{DateTime.Now.ToString()}                                 Technicians";
                        break;

                    case 8345:
                        msg = $"{DateTime.Now.ToString()}                                 Custodians";
                        break;

                    case 9998:
                    case 1006:
                    case 1008:
                        msg = $"{DateTime.Now.ToString()}                                 Scientist";
                        break;

                    default:
                        msg = $"{DateTime.Now.ToString()}                                 Restricted Access!";
                        break;
                }
                listBox.Items.Add(msg);
                string filepath = "D:\\LEARN\\C#\\lab\\demo-winform\\SecurityPanel\\log.txt";
                using (var stream = File.AppendText(path: filepath))
                {
                    stream.WriteLine(msg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Errors");
            }
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text = "";
        }
    }
}
