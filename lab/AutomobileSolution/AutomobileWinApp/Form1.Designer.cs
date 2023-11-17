namespace AutomobileWinApp {
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
            lbCarId = new Label();
            lbCarName = new Label();
            lbManufacturer = new Label();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            dataGridView1 = new DataGridView();
            txtCarId = new TextBox();
            txtCarName = new TextBox();
            txtManuFacturer = new TextBox();
            txtPrice = new TextBox();
            txtReleaseYear = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbCarId
            // 
            lbCarId.AutoSize = true;
            lbCarId.Location = new Point(66, 56);
            lbCarId.Name = "lbCarId";
            lbCarId.Size = new Size(36, 15);
            lbCarId.TabIndex = 0;
            lbCarId.Text = "CarID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Location = new Point(66, 105);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(60, 15);
            lbCarName.TabIndex = 1;
            lbCarName.Text = "Car Name";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Location = new Point(66, 149);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(79, 15);
            lbManufacturer.TabIndex = 2;
            lbManufacturer.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Location = new Point(414, 53);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(33, 15);
            lbPrice.TabIndex = 3;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Location = new Point(414, 110);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(71, 15);
            lbReleaseYear.TabIndex = 4;
            lbReleaseYear.Text = "Release Year";
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(155, 205);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(75, 23);
            btnLoad.TabIndex = 5;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(345, 205);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(75, 23);
            btnNew.TabIndex = 6;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(511, 205);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(372, 416);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 251);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(729, 150);
            dataGridView1.TabIndex = 9;
            // 
            // txtCarId
            // 
            txtCarId.Location = new Point(191, 53);
            txtCarId.Name = "txtCarId";
            txtCarId.Size = new Size(169, 23);
            txtCarId.TabIndex = 10;
            // 
            // txtCarName
            // 
            txtCarName.Location = new Point(191, 102);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(169, 23);
            txtCarName.TabIndex = 11;
            // 
            // txtManuFacturer
            // 
            txtManuFacturer.Location = new Point(191, 146);
            txtManuFacturer.Name = "txtManuFacturer";
            txtManuFacturer.Size = new Size(169, 23);
            txtManuFacturer.TabIndex = 12;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(534, 53);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(160, 23);
            txtPrice.TabIndex = 13;
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.Location = new Point(534, 107);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(160, 23);
            txtReleaseYear.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtReleaseYear);
            Controls.Add(txtPrice);
            Controls.Add(txtManuFacturer);
            Controls.Add(txtCarName);
            Controls.Add(txtCarId);
            Controls.Add(dataGridView1);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarName);
            Controls.Add(lbCarId);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarId;
        private Label lbCarName;
        private Label lbManufacturer;
        private Label lbPrice;
        private Label lbReleaseYear;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private Button btnClose;
        private DataGridView dataGridView1;
        private TextBox txtCarId;
        private TextBox txtCarName;
        private TextBox txtManuFacturer;
        private TextBox txtPrice;
        private TextBox txtReleaseYear;
    }
}