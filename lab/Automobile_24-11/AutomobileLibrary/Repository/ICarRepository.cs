using AutomobileLibrary.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository {
    public interface ICarRepository {
        public IEnumerable<Car> GetCars();
        Car GetCarById(int carId);
        void DeleteCarById(Car car);
        void Update(Car car);
        void Insert(Car car);
    }
}
