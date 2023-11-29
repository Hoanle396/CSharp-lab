using AutomobileLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository {
    public class CarRepository : ICarRepository {
        public void DeleteCarById(Car car) => CarManagement.Instance.Remove(car);

        public Car GetCarById(int carId) => CarManagement.Instance.GetById(carId);

        public IEnumerable<Car> GetCars() => CarManagement.Instance.GetCarList();

        public void Insert(Car car) => CarManagement.Instance.AddNew(car);

        public void Update(Car car) => CarManagement.Instance.Update(car);
    }
}
