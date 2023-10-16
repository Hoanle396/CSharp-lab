using System.Windows.Forms;

namespace SQL_winform
{
    partial class Form3
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
            lbClassID = new System.Windows.Forms.Label();
            txtClassID = new System.Windows.Forms.TextBox();
            btnViewDetail = new System.Windows.Forms.Button();
            txtClassIDRes = new System.Windows.Forms.TextBox();
            lblClassIdRes = new System.Windows.Forms.Label();
            txtClassName = new System.Windows.Forms.TextBox();
            lbClassName = new System.Windows.Forms.Label();
            txtYear = new System.Windows.Forms.TextBox();
            lbYear = new System.Windows.Forms.Label();
            lvStudent = new System.Windows.Forms.ListView();
            btnViewListStudent = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbClassID
            // 
            lbClassID.AutoSize = true;
            lbClassID.Location = new System.Drawing.Point(67, 62);
            lbClassID.Name = "lbClassID";
            lbClassID.Size = new System.Drawing.Size(75, 15);
            lbClassID.TabIndex = 0;
            lbClassID.Text = "Enter ClassID";
            // 
            // txtClassID
            // 
            txtClassID.Location = new System.Drawing.Point(167, 59);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new System.Drawing.Size(227, 23);
            txtClassID.TabIndex = 1;
            // 
            // btnViewDetail
            // 
            btnViewDetail.Location = new System.Drawing.Point(67, 100);
            btnViewDetail.Name = "btnViewDetail";
            btnViewDetail.Size = new System.Drawing.Size(327, 31);
            btnViewDetail.TabIndex = 2;
            btnViewDetail.Text = "View in Detail";
            btnViewDetail.UseVisualStyleBackColor = true;
            btnViewDetail.Click += btnViewDetail_Click;
            // 
            // txtClassIDRes
            // 
            txtClassIDRes.Location = new System.Drawing.Point(167, 169);
            txtClassIDRes.Name = "txtClassIDRes";
            txtClassIDRes.Size = new System.Drawing.Size(227, 23);
            txtClassIDRes.TabIndex = 4;
            // 
            // lblClassIdRes
            // 
            lblClassIdRes.AutoSize = true;
            lblClassIdRes.Location = new System.Drawing.Point(67, 172);
            lblClassIdRes.Name = "lblClassIdRes";
            lblClassIdRes.Size = new System.Drawing.Size(45, 15);
            lblClassIdRes.TabIndex = 3;
            lblClassIdRes.Text = "ClassID";
            // 
            // txtClassName
            // 
            txtClassName.Location = new System.Drawing.Point(167, 209);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new System.Drawing.Size(227, 23);
            txtClassName.TabIndex = 6;
            // 
            // lbClassName
            // 
            lbClassName.AutoSize = true;
            lbClassName.Location = new System.Drawing.Point(67, 212);
            lbClassName.Name = "lbClassName";
            lbClassName.Size = new System.Drawing.Size(69, 15);
            lbClassName.TabIndex = 5;
            lbClassName.Text = "Class Name";
            // 
            // txtYear
            // 
            txtYear.Location = new System.Drawing.Point(167, 255);
            txtYear.Name = "txtYear";
            txtYear.Size = new System.Drawing.Size(227, 23);
            txtYear.TabIndex = 8;
            // 
            // lbYear
            // 
            lbYear.AutoSize = true;
            lbYear.Location = new System.Drawing.Point(67, 258);
            lbYear.Name = "lbYear";
            lbYear.Size = new System.Drawing.Size(29, 15);
            lbYear.TabIndex = 7;
            lbYear.Text = "Year";
            // 
            // lvStudent
            // 
            lvStudent.Location = new System.Drawing.Point(447, 131);
            lvStudent.Name = "lvStudent";
            lvStudent.Size = new System.Drawing.Size(324, 147);
            lvStudent.TabIndex = 9;
            lvStudent.UseCompatibleStateImageBehavior = false;
            lvStudent.FullRowSelect = true;
            lvStudent.GridLines = true;
            lvStudent.View=View.Details;
            lvStudent.Columns.Add("Student ID",108);
            lvStudent.Columns.Add("Name", 108);
            lvStudent.Columns.Add("Class ID",108);
            // 
            // btnViewListStudent
            // 
            btnViewListStudent.Location = new System.Drawing.Point(447, 75);
            btnViewListStudent.Name = "btnViewListStudent";
            btnViewListStudent.Size = new System.Drawing.Size(327, 31);
            btnViewListStudent.TabIndex = 10;
            btnViewListStudent.Text = "View List Of Student";
            btnViewListStudent.UseVisualStyleBackColor = true;
            btnViewListStudent.Click += btnViewListStudent_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnViewListStudent);
            Controls.Add(lvStudent);
            Controls.Add(txtYear);
            Controls.Add(lbYear);
            Controls.Add(txtClassName);
            Controls.Add(lbClassName);
            Controls.Add(txtClassIDRes);
            Controls.Add(lblClassIdRes);
            Controls.Add(btnViewDetail);
            Controls.Add(txtClassID);
            Controls.Add(lbClassID);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbClassID;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Button btnViewDetail;
        private System.Windows.Forms.TextBox txtClassIDRes;
        private System.Windows.Forms.Label lblClassIdRes;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label lbClassName;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lbYear;
        private System.Windows.Forms.ListView lvStudent;
        private System.Windows.Forms.Button btnViewListStudent;
    }
}