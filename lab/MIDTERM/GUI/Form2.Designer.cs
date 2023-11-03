namespace GUI {
    partial class Form2 {
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBookId = new TextBox();
            txtBookName = new TextBox();
            txtAuthor = new TextBox();
            txtYear = new TextBox();
            btnInsert = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            exit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(297, 41);
            label1.Name = "label1";
            label1.Size = new Size(180, 32);
            label1.TabIndex = 0;
            label1.Text = "UPDATE BOOK";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 142);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Book ID";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 212);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Book Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(158, 262);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 3;
            label4.Text = "Author";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(158, 314);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 4;
            label5.Text = "Publishcation Year";
            // 
            // txtBookId
            // 
            txtBookId.Location = new Point(297, 139);
            txtBookId.Name = "txtBookId";
            txtBookId.Size = new Size(222, 23);
            txtBookId.TabIndex = 5;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(297, 204);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(222, 23);
            txtBookName.TabIndex = 6;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(297, 259);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(222, 23);
            txtAuthor.TabIndex = 7;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(297, 306);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(222, 23);
            txtYear.TabIndex = 8;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(173, 373);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 9;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(273, 373);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(377, 373);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // exit
            // 
            exit.Location = new Point(488, 373);
            exit.Name = "exit";
            exit.Size = new Size(75, 23);
            exit.TabIndex = 12;
            exit.Text = "Exit";
            exit.UseVisualStyleBackColor = true;
            exit.Click += exit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exit);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnInsert);
            Controls.Add(txtYear);
            Controls.Add(txtAuthor);
            Controls.Add(txtBookName);
            Controls.Add(txtBookId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBookId;
        private TextBox txtBookName;
        private TextBox txtAuthor;
        private TextBox txtYear;
        private Button btnInsert;
        private Button btnDelete;
        private Button btnUpdate;
        private Button exit;
    }
}