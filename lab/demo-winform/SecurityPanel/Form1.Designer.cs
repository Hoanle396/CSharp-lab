namespace SecurityPanel
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
            lbSecurityCode = new System.Windows.Forms.Label();
            txtSecurityCode = new System.Windows.Forms.TextBox();
            btn1 = new System.Windows.Forms.Button();
            btn2 = new System.Windows.Forms.Button();
            btn3 = new System.Windows.Forms.Button();
            btn4 = new System.Windows.Forms.Button();
            btn5 = new System.Windows.Forms.Button();
            btn6 = new System.Windows.Forms.Button();
            btn7 = new System.Windows.Forms.Button();
            btn8 = new System.Windows.Forms.Button();
            btn9 = new System.Windows.Forms.Button();
            btn0 = new System.Windows.Forms.Button();
            btnc = new System.Windows.Forms.Button();
            btnEnter = new System.Windows.Forms.Button();
            listBox = new System.Windows.Forms.ListBox();
            SuspendLayout();
            // 
            // lbSecurityCode
            // 
            lbSecurityCode.AutoSize = true;
            lbSecurityCode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbSecurityCode.Location = new System.Drawing.Point(32, 23);
            lbSecurityCode.Name = "lbSecurityCode";
            lbSecurityCode.Size = new System.Drawing.Size(112, 21);
            lbSecurityCode.TabIndex = 0;
            lbSecurityCode.Text = "Security Code";
            // 
            // txtSecurityCode
            // 
            txtSecurityCode.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            txtSecurityCode.Location = new System.Drawing.Point(166, 22);
            txtSecurityCode.Name = "txtSecurityCode";
            txtSecurityCode.PasswordChar = '*';
            txtSecurityCode.Size = new System.Drawing.Size(198, 29);
            txtSecurityCode.TabIndex = 1;
            // 
            // btn1
            // 
            btn1.Location = new System.Drawing.Point(85, 104);
            btn1.Name = "btn1";
            btn1.Size = new System.Drawing.Size(40, 40);
            btn1.TabIndex = 2;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Location = new System.Drawing.Point(145, 104);
            btn2.Name = "btn2";
            btn2.Size = new System.Drawing.Size(40, 40);
            btn2.TabIndex = 3;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Location = new System.Drawing.Point(206, 104);
            btn3.Name = "btn3";
            btn3.Size = new System.Drawing.Size(40, 40);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Location = new System.Drawing.Point(85, 160);
            btn4.Name = "btn4";
            btn4.Size = new System.Drawing.Size(40, 40);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Location = new System.Drawing.Point(145, 160);
            btn5.Name = "btn5";
            btn5.Size = new System.Drawing.Size(40, 40);
            btn5.TabIndex = 9;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Location = new System.Drawing.Point(206, 160);
            btn6.Name = "btn6";
            btn6.Size = new System.Drawing.Size(40, 40);
            btn6.TabIndex = 8;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Location = new System.Drawing.Point(85, 215);
            btn7.Name = "btn7";
            btn7.Size = new System.Drawing.Size(40, 40);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new System.Drawing.Point(145, 215);
            btn8.Name = "btn8";
            btn8.Size = new System.Drawing.Size(40, 40);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Location = new System.Drawing.Point(206, 215);
            btn9.Name = "btn9";
            btn9.Size = new System.Drawing.Size(40, 40);
            btn9.TabIndex = 13;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.Location = new System.Drawing.Point(267, 215);
            btn0.Name = "btn0";
            btn0.Size = new System.Drawing.Size(40, 40);
            btn0.TabIndex = 12;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnc
            // 
            btnc.Location = new System.Drawing.Point(267, 104);
            btnc.Name = "btnc";
            btnc.Size = new System.Drawing.Size(40, 40);
            btnc.TabIndex = 11;
            btnc.Text = "C";
            btnc.UseVisualStyleBackColor = true;
            btnc.Click += btnc_Click;
            // 
            // btnEnter
            // 
            btnEnter.Location = new System.Drawing.Point(267, 160);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new System.Drawing.Size(40, 40);
            btnEnter.TabIndex = 10;
            btnEnter.Text = "#";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new System.Drawing.Point(12, 291);
            listBox.Name = "listBox";
            listBox.Size = new System.Drawing.Size(394, 139);
            listBox.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(418, 450);
            Controls.Add(listBox);
            Controls.Add(btn9);
            Controls.Add(btn0);
            Controls.Add(btnc);
            Controls.Add(btnEnter);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtSecurityCode);
            Controls.Add(lbSecurityCode);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbSecurityCode;
        private System.Windows.Forms.TextBox txtSecurityCode;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnc;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.ListBox listBox;
    }
}
