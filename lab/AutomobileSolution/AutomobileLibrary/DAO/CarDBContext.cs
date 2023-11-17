using AutomobileLibrary.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.DAO {
    public class CarDBContext {
        private static List<Car> listCar = new List<Car> {
            new Car {
                CarID = 1,
                CarName = "CRV",
                Manufacturer ="Honda",
                Price = 30000,
                ReleaseYear = 2021
            },
            new Car {
                CarID = 2,
                CarName ="Ford fucus",
                Manufacturer ="Ford",
                Price = 15000,
                ReleaseYear=2020
            }
        };
        private static CarDBContext instance = null;
        private static readonly object instanceLock = new object();
        private CarDBContext() { }

        public static CarDBContext GetInstance {
            get {
                lock (instanceLock) {
                    if (instance == null) {
                        instance = new CarDBContext();
                    }
                    return instance;
                }
            }
        }
        public List<Car> list => listCar;
        public Car? GetCarById(int carID) {
            return listCar.SingleOrDefault(s => s.CarID == carID);
        }

        public void AddNew(Car car) {
            var extis = GetCarById(car.CarID);
            if (extis == null) {
                listCar.Add(car);
            } else {
                throw new Exception("Car already exits");
            }
        }

        public void Update(Car car) {
            var extis = GetCarById(car.CarID);
            if (extis != null) {
                var index = listCar.IndexOf(extis);
                listCar[index] = car;
            } else {
                throw new Exception("Car not already exits");
            }
        }

        public void Delete(int carID) {
            var extis = GetCarById(carID);
            if (extis != null) {
                listCar.Remove(extis);
            } else {
                throw new Exception("Car not already exits");
            }
        }
    }
}
