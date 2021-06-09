using Business.Concrete;
using DataAccess.Concrete.EntityFrameWork;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
           
            //BrandTest();
            //ColorTest();

        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            var result = colorManager.GetAll();
            if (result.Success==true)
            {
                foreach (var color in result.Data)
                {
                    Console.WriteLine(color.ColorName);
                }
            }
            
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();

            if (result.Success == true)
            {
                foreach (var brand in result.Data)
                {
                    Console.WriteLine(brand.BrandName);
                }
            }
            
            Console.WriteLine("---------------------------------");
        }

        private static void CarTest()
        {
            //carManager.Update(new Car { Id=1006,BrandId = "WGN", ColorId = "WHT", CarName = "Jetta Full", Description = "İdare eder", ModelYear = 2018, DailyPrice = 205 });
            //carManager.Delete(new Car { Id=1006});
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.BrandName + " " + car.CarName + " ----> " + car.ColorName);
                    //Console.WriteLine(car.Description);

                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
            Console.WriteLine("---------------------------------");
        }
    }
}
