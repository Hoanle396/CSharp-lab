namespace frmUocboi
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
            grInput = new System.Windows.Forms.GroupBox();
            txtB = new System.Windows.Forms.TextBox();
            txtA = new System.Windows.Forms.TextBox();
            lbB = new System.Windows.Forms.Label();
            lbA = new System.Windows.Forms.Label();
            grChoose = new System.Windows.Forms.GroupBox();
            bscnn = new System.Windows.Forms.RadioButton();
            uscln = new System.Windows.Forms.RadioButton();
            grResult = new System.Windows.Forms.GroupBox();
            txtResult = new System.Windows.Forms.TextBox();
            find = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            btnSkip = new System.Windows.Forms.Button();
            grInput.SuspendLayout();
            grChoose.SuspendLayout();
            grResult.SuspendLayout();
            SuspendLayout();
            // 
            // grInput
            // 
            grInput.Controls.Add(txtB);
            grInput.Controls.Add(txtA);
            grInput.Controls.Add(lbB);
            grInput.Controls.Add(lbA);
            grInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            grInput.Location = new System.Drawing.Point(6, 6);
            grInput.Name = "grInput";
            grInput.Size = new System.Drawing.Size(577, 246);
            grInput.TabIndex = 0;
            grInput.TabStop = false;
            grInput.Text = "Nhập ";
            // 
            // txtB
            // 
            txtB.Location = new System.Drawing.Point(117, 109);
            txtB.Name = "txtB";
            txtB.Size = new System.Drawing.Size(343, 29);
            txtB.TabIndex = 3;
            // 
            // txtA
            // 
            txtA.Location = new System.Drawing.Point(117, 57);
            txtA.Name = "txtA";
            txtA.Size = new System.Drawing.Size(343, 29);
            txtA.TabIndex = 2;
            // 
            // lbB
            // 
            lbB.AutoSize = true;
            lbB.Location = new System.Drawing.Point(26, 106);
            lbB.Name = "lbB";
            lbB.Size = new System.Drawing.Size(19, 21);
            lbB.TabIndex = 1;
            lbB.Text = "B";
            // 
            // lbA
            // 
            lbA.AutoSize = true;
            lbA.Location = new System.Drawing.Point(25, 61);
            lbA.Name = "lbA";
            lbA.Size = new System.Drawing.Size(20, 21);
            lbA.TabIndex = 0;
            lbA.Text = "A";
            // 
            // grChoose
            // 
            grChoose.Controls.Add(bscnn);
            grChoose.Controls.Add(uscln);
            grChoose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            grChoose.Location = new System.Drawing.Point(589, 6);
            grChoose.Name = "grChoose";
            grChoose.Size = new System.Drawing.Size(201, 246);
            grChoose.TabIndex = 1;
            grChoose.TabStop = false;
            grChoose.Text = "Chọn Tìm";
            // 
            // bscnn
            // 
            bscnn.AutoSize = true;
            bscnn.Location = new System.Drawing.Point(61, 111);
            bscnn.Name = "bscnn";
            bscnn.Size = new System.Drawing.Size(80, 25);
            bscnn.TabIndex = 1;
            bscnn.TabStop = true;
            bscnn.Text = "BSCNN";
            bscnn.UseVisualStyleBackColor = true;
            // 
            // uscln
            // 
            uscln.AutoSize = true;
            uscln.Location = new System.Drawing.Point(61, 56);
            uscln.Name = "uscln";
            uscln.Size = new System.Drawing.Size(78, 25);
            uscln.TabIndex = 0;
            uscln.TabStop = true;
            uscln.Text = "USCLN";
            uscln.UseVisualStyleBackColor = true;
            // 
            // grResult
            // 
            grResult.Controls.Add(btnSkip);
            grResult.Controls.Add(btnExit);
            grResult.Controls.Add(find);
            grResult.Controls.Add(txtResult);
            grResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            grResult.Location = new System.Drawing.Point(6, 260);
            grResult.Name = "grResult";
            grResult.Size = new System.Drawing.Size(784, 178);
            grResult.TabIndex = 2;
            grResult.TabStop = false;
            grResult.Text = "Kết quả";
            // 
            // txtResult
            // 
            txtResult.Location = new System.Drawing.Point(110, 45);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new System.Drawing.Size(355, 29);
            txtResult.TabIndex = 0;
            // 
            // find
            // 
            find.Location = new System.Drawing.Point(110, 113);
            find.Name = "find";
            find.Size = new System.Drawing.Size(78, 25);
            find.TabIndex = 1;
            find.Text = "Tìm";
            find.UseVisualStyleBackColor = true;
            find.Click += find_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(390, 113);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(75, 25);
            btnExit.TabIndex = 2;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSkip
            // 
            btnSkip.Location = new System.Drawing.Point(256, 113);
            btnSkip.Name = "btnSkip";
            btnSkip.Size = new System.Drawing.Size(75, 25);
            btnSkip.TabIndex = 3;
            btnSkip.Text = "Bỏ qua";
            btnSkip.UseVisualStyleBackColor = true;
            btnSkip.Click += btnSkip_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(grResult);
            Controls.Add(grChoose);
            Controls.Add(grInput);
            Name = "Form1";
            Text = "Form1";
            grInput.ResumeLayout(false);
            grInput.PerformLayout();
            grChoose.ResumeLayout(false);
            grChoose.PerformLayout();
            grResult.ResumeLayout(false);
            grResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grInput;
        private System.Windows.Forms.GroupBox grChoose;
        private System.Windows.Forms.GroupBox grResult;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.RadioButton bscnn;
        private System.Windows.Forms.RadioButton uscln;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnSkip;
    }
}
