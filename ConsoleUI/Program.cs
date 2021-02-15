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
            ColorManager colorManager = new ColorManager(new EfColorDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //carManager.Delete(new Car { Id = 8 });
            colorManager.Delete(new Color { Id = 8 });
            brandManager.Delete(new Brand { Id = 8 });

            //foreach (var cars in carManager.GetAll())
            //{
            //    Console.WriteLine(cars.Description);
            //}
            
            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.Name);
            //}
            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.Name);
            //}







        }
    }
}
