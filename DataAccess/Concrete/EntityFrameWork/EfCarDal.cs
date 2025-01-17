﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapRentCarContext>, ICarDal
    {
        

        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapRentCarContext context = new ReCapRentCarContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.Id
                             join co in context.Colors
                             on c.ColorId equals co.Id
                             select new CarDetailDto { CarId = c.Id,CarName = c.CarName, BrandName = b.BrandName, ColorName = co.ColorName, DailyPrice = c.DailyPrice };
                return result.ToList();
            }
        }

        public CarDetailDto GetCarDetailsByCarId(int carId)
        {
            var details = GetCarDetails();
            return details.Where(x => x.CarId == carId).FirstOrDefault();
        }
    }
}
