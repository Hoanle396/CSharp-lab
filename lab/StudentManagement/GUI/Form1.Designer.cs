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
            btnView = new System.Windows.Forms.Button();
            lvStudent = new System.Windows.Forms.ListView();
            SuspendLayout();
            // 
            // btnView
            // 
            btnView.Location = new System.Drawing.Point(223, 38);
            btnView.Name = "btnView";
            btnView.Size = new System.Drawing.Size(323, 59);
            btnView.TabIndex = 0;
            btnView.Text = "View Student Table";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // lvStudent
            // 
            lvStudent.HideSelection = false;
            lvStudent.Location = new System.Drawing.Point(76, 134);
            lvStudent.Name = "lvStudent";
            lvStudent.Size = new System.Drawing.Size(677, 282);
            lvStudent.TabIndex = 1;
            lvStudent.UseCompatibleStateImageBehavior = false;
            lvStudent.View = View.Details;
            lvStudent.FullRowSelect = true;
            lvStudent.GridLines = true;
            lvStudent.Columns.Add("Student ID", 228);
            lvStudent.Columns.Add("Name", 228);
            lvStudent.Columns.Add("Class ID", 228);
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(lvStudent);
            Controls.Add(btnView);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ListView lvStudent;
    }
}
