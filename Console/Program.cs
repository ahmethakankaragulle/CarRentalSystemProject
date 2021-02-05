using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ////CarManager nesnesi oluşturuyorum InMemory kullanıcak
            //CarManager carManager = new CarManager(new InMemoryCarDal());

            ////InMemory de hazır olan listedeki dataları yazdırıyorum
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("Id:" + car.CarId + " - " + car.Description + " " + car.ModelYear + "   -->Daily Price:" + car.DailyPrice + "TL");
            //}

            //Console.WriteLine("-----------------------------------------------------");
            ////Yeni data ekleyip listeyi tekrar yazdırıyorum
            //carManager.Add(new Entities.Concrete.Car { CarId = 7, BrandId = 4, ColorId = 5, Description = "Peugeot 508 131 beygir", ModelYear = "2020", DailyPrice = 600 });

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("Id:" + car.CarId + " - " + car.Description + " " + car.ModelYear + "   -->Daily Price:" + car.DailyPrice + "TL");
            //}
            //Console.WriteLine("-----------------------------------------------------");

            ////ID si 1 olan datayı güncelleyip listeyi tekrar yazdırıyorum
            //carManager.Update(new Entities.Concrete.Car { CarId = 1, BrandId=1,Description= "Porche Taycan 600 beygir", ColorId=1, ModelYear="2015", DailyPrice = 2500 });
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("Id:" + car.CarId + " - " + car.Description + " " + car.ModelYear + "   -->Daily Price:" + car.DailyPrice + "TL");
            //}
            //Console.WriteLine("-----------------------------------------------------");

            ////ID si 2 olan datayı siliyorum ve listeyi tekrar yazdırıyorum
            //carManager.Delete(new Entities.Concrete.Car { CarId = 2 });
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine("Id:" + car.CarId + " - " + car.Description + " " + car.ModelYear + "   -->Daily Price:" + car.DailyPrice + "TL");
            //}
            //Console.WriteLine("-----------------------------------------------------");

            ////ID ye göre veri getirtiyorum
            //foreach (var car in carManager.GetById(3))
            //{
            //    Console.WriteLine("Id:" + car.CarId + " - " + car.Description + " " + car.ModelYear + "   -->Daily Price:" + car.DailyPrice + "TL");
            //}

           
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand{BrandId = 1, BrandName = "Mercedes"});

            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorId = 1, ColorName = "Siyah" });

            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car
            {
                CarId = 1,
                BrandId = 1,
                ColorId = 1,
                ModelYear = "2020",
                Description = "Mercedes E250 150 beygir Canavar",
                DailyPrice = 500

            });

            carManager.GetAll();
        

        }
    }
}
