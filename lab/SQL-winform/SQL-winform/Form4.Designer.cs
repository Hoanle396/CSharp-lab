using System.Windows.Forms;

namespace SQL_winform
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvStudent = new ListView();
            lbListStudent = new Label();
            lbListOfClass = new Label();
            lsbClass = new ListBox();
            SuspendLayout();
            // 
            // lvStudent
            // 
            lvStudent.FullRowSelect = true;
            lvStudent.GridLines = true;
            lvStudent.HideSelection = false;
            lvStudent.Location = new System.Drawing.Point(438, 167);
            lvStudent.Name = "lvStudent";
            lvStudent.Size = new System.Drawing.Size(324, 147);
            lvStudent.TabIndex = 11;
            lvStudent.UseCompatibleStateImageBehavior = false;
            lvStudent.View = View.Details;
            lvStudent.Columns.Add("Student ID", 108);
            lvStudent.Columns.Add("Name", 108);
            lvStudent.Columns.Add("Class ID", 108);
            // 
            // lbListStudent
            // 
            lbListStudent.AutoSize = true;
            lbListStudent.Location = new System.Drawing.Point(550, 121);
            lbListStudent.Name = "lbListStudent";
            lbListStudent.Size = new System.Drawing.Size(82, 15);
            lbListStudent.TabIndex = 12;
            lbListStudent.Text = "List of student";
            // 
            // lbListOfClass
            // 
            lbListOfClass.AutoSize = true;
            lbListOfClass.Location = new System.Drawing.Point(159, 121);
            lbListOfClass.Name = "lbListOfClass";
            lbListOfClass.Size = new System.Drawing.Size(80, 15);
            lbListOfClass.TabIndex = 13;
            lbListOfClass.Text = "List of Classes";
            // 
            // lsbClass
            // 
            lsbClass.FormattingEnabled = true;
            lsbClass.ItemHeight = 15;
            lsbClass.Location = new System.Drawing.Point(54, 167);
            lsbClass.Name = "lsbClass";
            lsbClass.Size = new System.Drawing.Size(274, 139);
            lsbClass.TabIndex = 14;
            lsbClass.SelectedIndexChanged += lsbClass_SelectedIndexChanged;
            // 
            // Form4
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lsbClass);
            Controls.Add(lbListOfClass);
            Controls.Add(lbListStudent);
            Controls.Add(lvStudent);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvStudent;
        private Label lbListStudent;
        private Label lbListOfClass;
        private ListBox lsbClass;
    }
}