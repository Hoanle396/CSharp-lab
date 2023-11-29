using AutomobileLibrary.DAO;
using AutomobileLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutomobileWPFApp {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class WindowCarManagement : Window {
        ICarRepository repository;
        public WindowCarManagement(ICarRepository carRepository)
        {
                InitializeComponent();
                repository = carRepository;
        }

        private Car GetCarObject() {
            Car car = null;
            try {
                car = new Car {
                    CarId = int.Parse(txtCarId.Text),
                    CarName = txtCarName.Text,
                    Manufacturer = txtManufacturer.Text,
                    Price = decimal.Parse(txtPrice.Text),
                    ReleasedYear = int.Parse(txtReleasedYear.Text),
                };
            }
            catch (Exception ex){
                MessageBox.Show(ex.Message);
            }
            return car;
        }

        public void LoadCarList() {
            lvCars.ItemsSource = repository.GetCars();
        }

        private void btnLoad_Click(object sender,RoutedEventArgs e) {
            try {
                LoadCarList();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e) {
            try {
                Car car = GetCarObject();
                repository.Insert(car);
                LoadCarList();
                MessageBox.Show("Insert successfully");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e) {
            try {
                Car car = GetCarObject();
                repository.Update(car);
                LoadCarList();
                MessageBox.Show("Update successfully");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e) {
            try {
                Car car = GetCarObject();
                repository.DeleteCarById(car);
                LoadCarList();
                MessageBox.Show("delete successfully");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, RoutedEventArgs e) => Close();
    }
}
