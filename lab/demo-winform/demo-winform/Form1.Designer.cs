namespace demo_winform
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
            base.Dispose(disposing, base.GetV());
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTitle = new System.Windows.Forms.Label();
            txtNumber1 = new System.Windows.Forms.Label();
            txtNumber2 = new System.Windows.Forms.Label();
            number1 = new System.Windows.Forms.TextBox();
            number2 = new System.Windows.Forms.TextBox();
            result = new System.Windows.Forms.TextBox();
            lbResult = new System.Windows.Forms.Label();
            btnCaculate = new System.Windows.Forms.Button();
            btnClear = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            btnSub = new System.Windows.Forms.Button();
            btnDiv = new System.Windows.Forms.Button();
            btnMul = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.AutoSize = true;
            lbTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbTitle.Location = new System.Drawing.Point(232, 34);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new System.Drawing.Size(287, 32);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Thực Hiện Các Phép Tính";
            // 
            // txtNumber1
            // 
            txtNumber1.AutoSize = true;
            txtNumber1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtNumber1.Location = new System.Drawing.Point(202, 122);
            txtNumber1.Name = "txtNumber1";
            txtNumber1.Size = new System.Drawing.Size(80, 21);
            txtNumber1.TabIndex = 1;
            txtNumber1.Text = "Number 1";
            txtNumber1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumber2
            // 
            txtNumber2.AutoSize = true;
            txtNumber2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtNumber2.Location = new System.Drawing.Point(202, 172);
            txtNumber2.Name = "txtNumber2";
            txtNumber2.Size = new System.Drawing.Size(83, 21);
            txtNumber2.TabIndex = 2;
            txtNumber2.Text = "Number 2";
            txtNumber2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // number1
            // 
            number1.Location = new System.Drawing.Point(318, 121);
            number1.Name = "number1";
            number1.Size = new System.Drawing.Size(218, 23);
            number1.TabIndex = 3;
            // 
            // number2
            // 
            number2.Location = new System.Drawing.Point(318, 171);
            number2.Name = "number2";
            number2.Size = new System.Drawing.Size(218, 23);
            number2.TabIndex = 4;
            // 
            // result
            // 
            result.Location = new System.Drawing.Point(318, 225);
            result.Name = "result";
            result.ReadOnly = true;
            result.Size = new System.Drawing.Size(218, 23);
            result.TabIndex = 6;
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbResult.Location = new System.Drawing.Point(202, 226);
            lbResult.Name = "lbResult";
            lbResult.Size = new System.Drawing.Size(55, 21);
            lbResult.TabIndex = 5;
            lbResult.Text = "Result";
            lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnCaculate
            // 
            btnCaculate.Location = new System.Drawing.Point(138, 293);
            btnCaculate.Name = "btnCaculate";
            btnCaculate.Size = new System.Drawing.Size(75, 23);
            btnCaculate.TabIndex = 7;
            btnCaculate.Text = "+";
            btnCaculate.UseVisualStyleBackColor = true;
            btnCaculate.Click += btnCaculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new System.Drawing.Point(461, 293);
            btnClear.Name = "btnClear";
            btnClear.Size = new System.Drawing.Size(75, 23);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(541, 293);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(75, 23);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnSub
            // 
            btnSub.Location = new System.Drawing.Point(219, 293);
            btnSub.Name = "btnSub";
            btnSub.RightToLeft = System.Windows.Forms.RightToLeft.No;
            btnSub.Size = new System.Drawing.Size(75, 23);
            btnSub.TabIndex = 10;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click;
            // 
            // btnDiv
            // 
            btnDiv.Location = new System.Drawing.Point(381, 293);
            btnDiv.Name = "btnDiv";
            btnDiv.RightToLeft = System.Windows.Forms.RightToLeft.No;
            btnDiv.Size = new System.Drawing.Size(75, 23);
            btnDiv.TabIndex = 12;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnMul
            // 
            btnMul.Location = new System.Drawing.Point(300, 293);
            btnMul.Name = "btnMul";
            btnMul.Size = new System.Drawing.Size(75, 23);
            btnMul.TabIndex = 11;
            btnMul.Text = "*";
            btnMul.UseVisualStyleBackColor = true;
            btnMul.Click += btnMul_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(745, 396);
            Controls.Add(btnDiv);
            Controls.Add(btnMul);
            Controls.Add(btnSub);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCaculate);
            Controls.Add(result);
            Controls.Add(lbResult);
            Controls.Add(number2);
            Controls.Add(number1);
            Controls.Add(txtNumber2);
            Controls.Add(txtNumber1);
            Controls.Add(lbTitle);
            Name = "Form1";
            Text = "Add two number";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label txtNumber1;
        private System.Windows.Forms.Label txtNumber2;
        private System.Windows.Forms.TextBox number1;
        private System.Windows.Forms.TextBox number2;
        private System.Windows.Forms.TextBox result;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btnCaculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMul;
    }
}
