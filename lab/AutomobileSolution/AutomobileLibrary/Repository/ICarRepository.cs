using AutomobileLibrary.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository {
    internal interface ICarRepository {
        IEnumerable<Car> GetCars();
        Car GetCarByid(int id);
        void InsertCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(int id);
    }
}
