namespace AutomobileWinApp {
    partial class Form2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            txtCarName = new TextBox();
            txtCarId = new TextBox();
            lbReleaseYear = new Label();
            lbPrice = new Label();
            lbManufacturer = new Label();
            lbCarName = new Label();
            lbCarId = new Label();
            comboBox1 = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            txtPrice = new MaskedTextBox();
            txtReleaseYear = new MaskedTextBox();
            SuspendLayout();
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(223, 106);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(169, 23);
            txtCarName.TabIndex = 21;
            // 
            // txtCarId
            // 
            txtCarId.Location = new Point(223, 57);
            txtCarId.Name = "txtCarId";
            txtCarId.Size = new Size(169, 23);
            txtCarId.TabIndex = 20;
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(98, 255);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(71, 15);
            lbReleaseYear.TabIndex = 19;
            lbReleaseYear.Text = "Release Year";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(98, 207);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 18;
            lbPrice.Text = "Price";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(98, 153);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(79, 15);
            lbManufacturer.TabIndex = 17;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(98, 109);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(60, 15);
            lbCarName.TabIndex = 16;
            lbCarName.Text = "Car Name";
            // 
            // lbCarId
            // 
            lbCarId.AutoSize = true;
            lbCarId.Location = new Point(98, 60);
            lbCarId.Name = "lbCarId";
            lbCarId.Size = new Size(36, 15);
            lbCarId.TabIndex = 15;
            lbCarId.Text = "CarID";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Audi", "BMV", "Ford", "Honda", "HuynDai", "Suzuki", "Kia", "Toyota" });
            comboBox1.Location = new Point(223, 153);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(169, 23);
            comboBox1.TabIndex = 25;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(167, 365);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(308, 365);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(223, 199);
            txtPrice.Mask = "000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(169, 23);
            txtPrice.TabIndex = 28;
            txtPrice.Text = "0";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(223, 247);
            txtReleaseYear.Mask = "0000";
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(169, 23);
            txtReleaseYear.TabIndex = 29;
            txtReleaseYear.Text = "0";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 450);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(comboBox1);
            Controls.Add(txtCarName);
            Controls.Add(txtCarId);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarId);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtCarName;
        private TextBox txtCarId;
        private Label lbReleaseYear;
        private Label lbPrice;
        private Label lbManufacturer;
        private Label lbCarName;
        private Label lbCarId;
        private ComboBox comboBox1;
        private Button btnSave;
        private Button btnCancel;
        private MaskedTextBox txtPrice;
        private MaskedTextBox txtReleaseYear;
    }
}