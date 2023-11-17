using AutomobileLibrary.BLL;
using AutomobileLibrary.Repository;

namespace AutomobileWinApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        CarRepository carRepository = new CarRepository();
        BindingSource source = null;
        private void Form1_Load(object sender, EventArgs e) {
            btnDelete.Enabled = false;
            dataGridView1.CellDoubleClick += cell_doubleClick;
        }

        public void cell_doubleClick(object sender, DataGridViewCellEventArgs e) {
            Form2 form2 = new Form2 {
                Text = "Update Car",
                carRepository = carRepository,
                InsertOrupdate = true,
                car = GetCarObject()
            };
            if (form2.ShowDialog() == DialogResult.OK) {
                LoadListCars();
                source.Position = source.Count - 1;
            }
        }
        private void btnLoad_Click(object sender, EventArgs e) {
            LoadListCars();
        }
        public Car GetCarObject() {
            try {
                return new Car {
                    CarID = int.Parse(txtCarId.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = txtManuFacturer.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleaseYear = int.Parse(txtReleaseYear.Text),
                };
            } catch (Exception e) {
                MessageBox.Show(e.Message);
                return null;
            }
        }
        public void LoadListCars() {
            var cars = carRepository.GetCars();
            try {
                source = new BindingSource();
                source.DataSource = cars;
                txtCarId.DataBindings.Clear();
                txtCarName.DataBindings.Clear();
                txtManuFacturer.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtReleaseYear.DataBindings.Clear();

                txtCarId.DataBindings.Add("Text", source, "CarId");
                txtCarName.DataBindings.Add("Text", source, "CarName");
                txtManuFacturer.DataBindings.Add("Text", source, "Manufacturer");
                txtPrice.DataBindings.Add("Text", source, "Price");
                txtReleaseYear.DataBindings.Add("Text", source, "ReleaseYear");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = source;
                if (cars.Count() == 0) {
                    ClearText();
                    btnDelete.Enabled = false;
                } else {
                    btnDelete.Enabled = true;
                }
            } catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }
        public void ClearText() {
            txtCarId.Text = string.Empty;
            txtCarName.Text = string.Empty;
            txtManuFacturer.Text = string.Empty;
            txtPrice.Text = string.Empty;
            txtReleaseYear.Text = string.Empty;
        }

        private void btnClose_Click(object sender, EventArgs e) => Close();

        private void btnNew_Click(object sender, EventArgs e) {
            Form2 form2 = new Form2 {
                Text = "Insert Car",
                carRepository = carRepository,
                InsertOrupdate = false,
            };
            if (form2.ShowDialog() == DialogResult.OK) {
                LoadListCars();
                source.Position = source.Count - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e) {
            try {
                var car = GetCarObject();
                carRepository.DeleteCar(car.CarID);
                LoadListCars();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}