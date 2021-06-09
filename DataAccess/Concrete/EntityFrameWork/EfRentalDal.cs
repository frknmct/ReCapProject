using Core.DataAccess.EntityFramework;
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
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapRentCarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapRentCarContext context = new ReCapRentCarContext())
            {
                var result = from r in context.Rentals
                             join ca in context.Cars
                             on r.CarId equals ca.Id
                             join cu in context.Customers
                             on r.CustomerId equals cu.CustomerId
                             select new RentalDetailDto { CarName = ca.CarName, CustomerName = cu.CustomerName, DailyPrice = ca.DailyPrice, RentDate = r.RentDate, ReturnDate = r.ReturnDate };
                return result.ToList();
                             
            }
        }
    }
}
