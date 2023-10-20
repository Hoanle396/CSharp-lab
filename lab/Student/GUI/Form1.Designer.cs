using System.Windows.Forms;

namespace GUI {
    partial class Form1 {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
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
            lvStudent = new ListView();
            groupbox.SuspendLayout();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(645, 139);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(75, 29);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(645, 83);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(75, 30);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new System.Drawing.Point(645, 29);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new System.Drawing.Size(75, 28);
            btnInsert.TabIndex = 19;
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
            groupbox.Location = new System.Drawing.Point(68, 12);
            groupbox.Name = "groupbox";
            groupbox.Size = new System.Drawing.Size(525, 190);
            groupbox.TabIndex = 18;
            groupbox.TabStop = false;
            groupbox.Text = "Student Information";
            // 
            // txtClassID
            // 
            txtClassID.Location = new System.Drawing.Point(117, 149);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new System.Drawing.Size(227, 23);
            txtClassID.TabIndex = 14;
            // 
            // lbClassID
            // 
            lbClassID.AutoSize = true;
            lbClassID.Location = new System.Drawing.Point(17, 152);
            lbClassID.Name = "lbClassID";
            lbClassID.Size = new System.Drawing.Size(45, 15);
            lbClassID.TabIndex = 13;
            lbClassID.Text = "ClassID";
            // 
            // txtFullName
            // 
            txtFullName.Location = new System.Drawing.Point(117, 103);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new System.Drawing.Size(227, 23);
            txtFullName.TabIndex = 12;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new System.Drawing.Point(17, 106);
            lbName.Name = "lbName";
            lbName.Size = new System.Drawing.Size(61, 15);
            lbName.TabIndex = 11;
            lbName.Text = "Full Name";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new System.Drawing.Point(117, 63);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new System.Drawing.Size(227, 23);
            txtStudentID.TabIndex = 10;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.Location = new System.Drawing.Point(17, 66);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new System.Drawing.Size(59, 15);
            lblStudentId.TabIndex = 9;
            lblStudentId.Text = "StudentID";
            // 
            // lvStudent
            // 
            lvStudent.FullRowSelect = true;
            lvStudent.GridLines = true;
            lvStudent.HideSelection = false;
            lvStudent.Location = new System.Drawing.Point(47, 208);
            lvStudent.Name = "lvStudent";
            lvStudent.Size = new System.Drawing.Size(693, 236);
            lvStudent.TabIndex = 17;
            lvStudent.UseCompatibleStateImageBehavior = false;
            lvStudent.View = View.Details;
            lvStudent.FullRowSelect = true;
            lvStudent.GridLines = true;
            lvStudent.Columns.Add("Student ID", 231);
            lvStudent.Columns.Add("Name", 231);
            lvStudent.Columns.Add("Class ID", 231);
            lvStudent.SelectedIndexChanged += lvStudent_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(groupbox);
            Controls.Add(lvStudent);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupbox.ResumeLayout(false);
            groupbox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

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
        private ListView lvStudent;
    }
}
