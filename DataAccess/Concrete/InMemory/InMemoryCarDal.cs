using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                /*new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2005,DailyPrice=50,Description="Günlük kiralık"},
                new Car{Id=2,BrandId=1,ColorId=3,ModelYear=2009,DailyPrice=75,Description="Günlük kiralık-keyfe keder boyalı"},
                new Car{Id=3,BrandId=1,ColorId=2,ModelYear=2002,DailyPrice=20,Description="Günlük kiralık-çıtır hasarlı"},
                new Car{Id=4,BrandId=2,ColorId=1,ModelYear=2010,DailyPrice=150,Description="Günlük kiralık"},
                new Car{Id=5,BrandId=2,ColorId=4,ModelYear=2015,DailyPrice=300,Description="Günlük kiralık-temiz"}*/
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
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

        public List<Car> GetByBrand(int brandId)
        {
            throw new NotImplementedException();
            //return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public CarDetailDto GetCarDetailsByCarId(int carId)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = carToUpdate.ModelYear;
            
        }
    }
}
