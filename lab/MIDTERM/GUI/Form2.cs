using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace GUI {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private async void btnInsert_Click(object sender, EventArgs e) {

            try {
                Book book = new Book {
                    BookId = txtBookId.Text,
                    BookName = txtBookName.Text,
                    Author = txtAuthor.Text,
                    PublicationYear = int.Parse(txtYear.Text)
                };
                bool res = await new BookBLL().InsertNewRecord(book);
                if (res) {
                    MessageBox.Show("Insert Book success");
                } else {
                    MessageBox.Show("Insert Book failed!");
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Errors");
            }

        }

        private async void btnDelete_Click(object sender, EventArgs e) {
            try {

                bool res = await new BookBLL().DeleteRecord(txtBookId.Text);
                if (res) {
                    MessageBox.Show("Delete Book success");
                } else {
                    MessageBox.Show("Delete Book failed!");
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Errors");
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e) {
            try {
                Book book = new Book {
                    BookId = txtBookId.Text,
                    BookName = txtBookName.Text,
                    Author = txtAuthor.Text,
                    PublicationYear = int.Parse(txtYear.Text)
                };
                bool res = await new BookBLL().UpdateRecord(book);
                if (res) {
                    MessageBox.Show("Update Book success");
                } else {
                    MessageBox.Show("Update Book failed!");
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Errors");
            }
        }

        private void exit_Click(object sender, EventArgs e) {
            DialogResult res = MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes) {
                base.Close();
            }
        }
    }
}
