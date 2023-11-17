using AutomobileLibrary.BLL;
using AutomobileLibrary.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomobileWinApp {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        public CarRepository carRepository = null;
        public bool InsertOrupdate { get; set; }
        public Car car { get; set; }

        private void btnSave_Click(object sender, EventArgs e) {
            try {
                var car = new Car {
                    CarID = int.Parse(txtCarId.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = comboBox1.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleaseYear = int.Parse(txtReleaseYear.Text)
                };
                if (InsertOrupdate == false) {
                    carRepository.InsertCar(car);
                } else {
                    carRepository.UpdateCar(car);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void Form2_Load(object sender, EventArgs e) {
            comboBox1.SelectedIndex = 0;
            txtCarId.Enabled = !InsertOrupdate;
            if(InsertOrupdate == true) {
                txtCarId.Text = car.CarID.ToString();
                txtCarName.Text = car.CarName.ToString();
                txtPrice.Text = car.Price.ToString();
                txtReleaseYear.Text = car.ReleaseYear.ToString();
                comboBox1.Text = car.Manufacturer.Trim();
            }

        }
    }
}
