using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=1, DailyPrice=1500, Description="Porche Taycan 600 beygir", ModelYear="2015"},
                new Car{CarId=2, BrandId=1, ColorId=2, DailyPrice=1000, Description="Porche Cayenne 300 beygir", ModelYear="2014"},
                new Car{CarId=3, BrandId=2, ColorId=2, DailyPrice=800, Description="Wosvagen Passat 150 beygir", ModelYear="2017"},
                new Car{CarId=4, BrandId=2, ColorId=3, DailyPrice=1500, Description="Wosvagen Polo 95 beygir ", ModelYear="2018"},
                new Car{CarId=5, BrandId=3, ColorId=4, DailyPrice=1500, Description="Mercedes C180 100 beygir", ModelYear="2016"},
                new Car{CarId=6, BrandId=3, ColorId=4, DailyPrice=1500, Description="Mercede CLA200 156 beygir", ModelYear="2019"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car CarToDelete = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            _cars.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.CarId == Id).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);

            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
            CarToUpdate.ModelYear = car.ModelYear;

        }
    }
}
