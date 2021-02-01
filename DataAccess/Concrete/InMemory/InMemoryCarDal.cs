using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{BrandId="BMW",ColorId="Black",DailyPrice=350,Description="İyi",Id=1,ModelYear=2020},
                new Car{BrandId="Audi",ColorId="White",DailyPrice=200,Description="İyi",Id=2,ModelYear=2021},
                new Car{BrandId="Fiat",ColorId="Blue",DailyPrice=150,Description="İyi",Id=3,ModelYear=2018},
                new Car{BrandId="Hyundai",ColorId="Red",DailyPrice=250,Description="İyi",Id=4,ModelYear=2016}

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);

        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.Id = car.Id;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
