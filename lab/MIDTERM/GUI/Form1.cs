namespace GUI {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e) {
            Form2 f = new Form2();
            f.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            DialogResult res = MessageBox.Show("Bạn thật sự muốn thoát?", "Thông báo", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes) {
                base.Close();
            }
        }

        private void byNameToolStripMenuItem_Click(object sender, EventArgs e) {
            Form3 f = new Form3();
            f.Visible = true;
        }
    }
}