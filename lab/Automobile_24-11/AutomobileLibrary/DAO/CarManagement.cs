using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.DAO
{
    public class CarManagement
    {
        public static CarManagement instance = null;
        private static readonly object instanceLock = new object();
        private CarManagement() { }

        public static CarManagement Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new CarManagement();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Car> GetCarList() {
            List<Car> list;
            try {
                var db = new MyStockContext();
                list = db.Cars.ToList();
            }catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            return list;
        }

        public Car GetById(int id) {
            Car car = null;
            try {
                var db = new MyStockContext();
                car = db.Cars.SingleOrDefault(car=>car.CarId==id);
            } catch (Exception ex) {
                throw new Exception(ex.Message);
            }
            return car;
        }
        public void AddNew(Car car) {
            try {
                Car c = GetById(car.CarId);
                if (c != null) {
                    throw new Exception("Car exit");
                } else {
                    var db = new MyStockContext();
                    db.Cars.Add(car);
                    db.SaveChanges();
                }
            } catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }
        public void Update(Car car) {
            try {
                Car c = GetById(car.CarId);
                if (c == null) {
                    throw new Exception("Car doesn't exit");
                } else {
                    var db = new MyStockContext();
                    db.Entry(car).State=Microsoft.EntityFrameworkCore.EntityState.Modified;
                    db.SaveChanges();
                }
            } catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }
        public void Remove(Car car) {
            try {
                Car c = GetById(car.CarId);
                if (c == null) {
                    throw new Exception("Car doesn't exit");
                } else {
                    var db = new MyStockContext();
                    db.Cars.Remove(car);
                    db.SaveChanges();
                }
            } catch (Exception ex) {
                throw new Exception(ex.Message);
            }
        }
    }
}
