using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            carManager.Add(new Car { BrandId = 1, ColorId = 1, DailyPrice = 12, Description = "araba", Id = 4, ModelYear = 2012 });

            foreach (var c in carManager.GetAll())
            {
                Console.WriteLine(c.Description);
            }

            //BrandManager brandManager = new BrandManager(new EfBrandDal());
            //foreach (var b in brandManager.GetCarsByBrandId(1))
            //{
            //    Console.WriteLine(b.Name);
            //}
            
        }
    }
}
