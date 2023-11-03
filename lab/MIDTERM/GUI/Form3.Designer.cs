namespace GUI {
    partial class Form3 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            label1 = new Label();
            txtBookName = new TextBox();
            listView1 = new ListView();
            label2 = new Label();
            bookId = new ColumnHeader();
            bookName = new ColumnHeader();
            Author = new ColumnHeader();
            publishCationYear = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(169, 83);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 0;
            label1.Text = "Enter Book Name";
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(315, 78);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(223, 23);
            txtBookName.TabIndex = 1;
            txtBookName.TextChanged += txtBookName_TextChanged;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { bookId, bookName, Author, publishCationYear });
            listView1.Location = new Point(114, 178);
            listView1.Name = "listView1";
            listView1.Size = new Size(593, 208);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 160);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 3;
            label2.Text = "Results: ";
            // 
            // bookId
            // 
            bookId.Text = "Book Id";
            bookId.Width = 128;
            // 
            // bookName
            // 
            bookName.Text = "Book Name";
            bookName.Width = 128;
            // 
            // Author
            // 
            Author.Text = "Author";
            Author.Width = 128;
            // 
            // publishCationYear
            // 
            publishCationYear.Text = "Publishcation Year";
            publishCationYear.Width = 128;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(listView1);
            Controls.Add(txtBookName);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBookName;
        private ListView listView1;
        private ColumnHeader bookId;
        private ColumnHeader bookName;
        private ColumnHeader Author;
        private ColumnHeader publishCationYear;
        private Label label2;
    }
}