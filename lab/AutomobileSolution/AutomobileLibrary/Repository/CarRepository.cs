using AutomobileLibrary.BLL;
using AutomobileLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository {
    public class CarRepository : ICarRepository {
        public void DeleteCar(int id) => CarDBContext.GetInstance.Delete(id);

        public Car GetCarByid(int id) => CarDBContext.GetInstance.GetCarById(id);

        public IEnumerable<Car> GetCars() => CarDBContext.GetInstance.list;

        public void InsertCar(Car car) => CarDBContext.GetInstance.AddNew(car);

        public void UpdateCar(Car car) => CarDBContext.GetInstance.Update(car);
    }
}
