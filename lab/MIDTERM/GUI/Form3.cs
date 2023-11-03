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

namespace GUI {
    public partial class Form3 : Form {
        public Form3() {
            InitializeComponent();
        }

        private void txtBookName_TextChanged(object sender, EventArgs e) {
            loads();
        }

        private async void loads() {
            listView1.Items.Clear();
            List<Book> books = await BookBLL.Find(txtBookName.Text);
            foreach (Book book in books) {
                ListViewItem item = new ListViewItem(book.BookId);
                item.SubItems.Add(book.BookName);
                item.SubItems.Add(book.Author);
                item.SubItems.Add(book.PublicationYear.ToString());
                listView1.Items.Add(item);
            }
        }

    }
}
