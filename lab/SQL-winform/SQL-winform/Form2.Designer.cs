namespace SQL_winform
{
    partial class Form2
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
            lbNumberOfStudent = new System.Windows.Forms.Label();
            txtClassID = new System.Windows.Forms.TextBox();
            txtNumberOfStudent = new System.Windows.Forms.TextBox();
            btnCaculate = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbClassID
            // 
            lbClassID.AutoSize = true;
            lbClassID.Location = new System.Drawing.Point(160, 89);
            lbClassID.Name = "lbClassID";
            lbClassID.Size = new System.Drawing.Size(75, 15);
            lbClassID.TabIndex = 0;
            lbClassID.Text = "Enter ClassID";
            // 
            // lbNumberOfStudent
            // 
            lbNumberOfStudent.AutoSize = true;
            lbNumberOfStudent.Location = new System.Drawing.Point(160, 151);
            lbNumberOfStudent.Name = "lbNumberOfStudent";
            lbNumberOfStudent.Size = new System.Drawing.Size(109, 15);
            lbNumberOfStudent.TabIndex = 1;
            lbNumberOfStudent.Text = "Number of Student";
            // 
            // txtClassID
            // 
            txtClassID.Location = new System.Drawing.Point(305, 85);
            txtClassID.Name = "txtClassID";
            txtClassID.Size = new System.Drawing.Size(215, 23);
            txtClassID.TabIndex = 2;
            // 
            // txtNumberOfStudent
            // 
            txtNumberOfStudent.Location = new System.Drawing.Point(305, 147);
            txtNumberOfStudent.Name = "txtNumberOfStudent";
            txtNumberOfStudent.ReadOnly = true;
            txtNumberOfStudent.Size = new System.Drawing.Size(215, 23);
            txtNumberOfStudent.TabIndex = 3;
            // 
            // btnCaculate
            // 
            btnCaculate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnCaculate.Location = new System.Drawing.Point(225, 224);
            btnCaculate.Name = "btnCaculate";
            btnCaculate.Size = new System.Drawing.Size(316, 45);
            btnCaculate.TabIndex = 4;
            btnCaculate.Text = "Caculate Number Of Student";
            btnCaculate.UseVisualStyleBackColor = true;
            btnCaculate.Click += btnCaculate_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnCaculate);
            Controls.Add(txtNumberOfStudent);
            Controls.Add(txtClassID);
            Controls.Add(lbNumberOfStudent);
            Controls.Add(lbClassID);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbClassID;
        private System.Windows.Forms.Label lbNumberOfStudent;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.TextBox txtNumberOfStudent;
        private System.Windows.Forms.Button btnCaculate;
    }
}