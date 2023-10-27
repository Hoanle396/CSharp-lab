namespace SearchFrom {
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
            lbSearch = new System.Windows.Forms.Label();
            txtSearch = new System.Windows.Forms.TextBox();
            dtgStudent = new System.Windows.Forms.DataGridView();
            StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ClassID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgStudent).BeginInit();
            SuspendLayout();
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbSearch.Location = new System.Drawing.Point(51, 35);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new System.Drawing.Size(223, 25);
            lbSearch.TabIndex = 0;
            lbSearch.Text = "Search By Student Name";
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(307, 36);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(406, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dtgStudent
            // 
            dtgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { StudentID, StudentName, ClassID });
            dtgStudent.Location = new System.Drawing.Point(61, 130);
            dtgStudent.Name = "dtgStudent";
            dtgStudent.RowTemplate.Height = 25;
            dtgStudent.Size = new System.Drawing.Size(662, 269);
            dtgStudent.TabIndex = 2;
            // 
            // StudentID
            // 
            StudentID.DataPropertyName = "StudentID";
            StudentID.HeaderText = "StudentID";
            StudentID.Name = "StudentID";
            // 
            // StudentName
            // 
            StudentName.DataPropertyName = "StudentName";
            StudentName.HeaderText = "StudentName";
            StudentName.Name = "StudentName";
            // 
            // ClassID
            // 
            ClassID.DataPropertyName = "ClassID";
            ClassID.HeaderText = "ClassID";
            ClassID.Name = "ClassID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(dtgStudent);
            Controls.Add(txtSearch);
            Controls.Add(lbSearch);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgStudent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dtgStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassID;
    }
}
