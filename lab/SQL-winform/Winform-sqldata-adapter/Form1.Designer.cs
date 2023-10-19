using System.Drawing;
using System.Windows.Forms;

namespace Winform_sqldata_adapter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnLoadStudent = new Button();
            dtgStudent = new DataGridView();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            groupbox = new GroupBox();
            txtClassID = new TextBox();
            lbClassID = new Label();
            txtFullName = new TextBox();
            lbName = new Label();
            txtStudentID = new TextBox();
            lblStudentId = new Label();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            ClassID = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgStudent).BeginInit();
            groupbox.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoadStudent
            // 
            btnLoadStudent.Location = new Point(79, 50);
            btnLoadStudent.Name = "btnLoadStudent";
            btnLoadStudent.Size = new Size(161, 40);
            btnLoadStudent.TabIndex = 0;
            btnLoadStudent.Text = "Load table student on data grid view";
            btnLoadStudent.UseVisualStyleBackColor = true;
            btnLoadStudent.Click += btnLoadStudent_Click;
            // 
            // dtgStudent
            // 
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dtgStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dtgStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgStudent.Columns.AddRange(new DataGridViewColumn[] { StudentID, StudentName, ClassID });
            dtgStudent.Location = new Point(12, 111);
            dtgStudent.MultiSelect = false;
            dtgStudent.Name = "dtgStudent";
            dataGridViewCellStyle2.BackColor = Color.White;
            dtgStudent.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dtgStudent.RowTemplate.Height = 25;
            dtgStudent.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgStudent.Size = new Size(339, 327);
            dtgStudent.TabIndex = 1;
            dtgStudent.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(662, 412);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(552, 412);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(442, 412);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 23);
            btnInsert.TabIndex = 18;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // groupbox
            // 
            groupbox.Controls.Add(txtClassID);
            groupbox.Controls.Add(lbClassID);
            groupbox.Controls.Add(txtFullName);
            groupbox.Controls.Add(lbName);
            groupbox.Controls.Add(txtStudentID);
            groupbox.Controls.Add(lblStudentId);
            groupbox.Location = new Point(402, 111);
            groupbox.Name = "groupbox";
            groupbox.Size = new Size(361, 244);
            groupbox.TabIndex = 17;
            groupbox.TabStop = false;
            groupbox.Text = "Student Information";
            // 
            // txtClassID
            // 
            txtClassID.Location = new Point(117, 149);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new Size(227, 23);
            txtClassID.TabIndex = 14;
            // 
            // lbClassID
            // 
            lbClassID.AutoSize = true;
            lbClassID.Location = new Point(17, 152);
            lbClassID.Name = "lbClassID";
            lbClassID.Size = new Size(45, 15);
            lbClassID.TabIndex = 13;
            lbClassID.Text = "ClassID";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(117, 103);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(227, 23);
            txtFullName.TabIndex = 12;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(17, 106);
            lbName.Name = "lbName";
            lbName.Size = new Size(61, 15);
            lbName.TabIndex = 11;
            lbName.Text = "Full Name";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(117, 63);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(227, 23);
            txtStudentID.TabIndex = 10;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new Point(17, 66);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(59, 15);
            lblStudentId.TabIndex = 9;
            lblStudentId.Text = "StudentID";
            // 
            // StudentID
            // 
            StudentID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            StudentID.DataPropertyName = "StudentID";
            StudentID.HeaderText = "StudentID";
            StudentID.Name = "StudentID";
            StudentID.Width = 105;
            // 
            // StudentName
            // 
            StudentName.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            StudentName.DataPropertyName = "StudentName";
            StudentName.HeaderText = "StudentName";
            StudentName.Name = "StudentName";
            StudentName.Width = 105;
            // 
            // ClassID
            // 
            ClassID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ClassID.DataPropertyName = "ClassID";
            ClassID.HeaderText = "ClassID";
            ClassID.Name = "ClassID";
            ClassID.Width = 105;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(groupbox);
            Controls.Add(dtgStudent);
            Controls.Add(btnLoadStudent);
            Name = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgStudent).EndInit();
            groupbox.ResumeLayout(false);
            groupbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoadStudent;
        private DataGridView dtgStudent;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private GroupBox groupbox;
        private TextBox txtClassID;
        private Label lbClassID;
        private TextBox txtFullName;
        private Label lbName;
        private TextBox txtStudentID;
        private Label lblStudentId;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn ClassID;
    }
}
