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
            //BrandTest();
            //ColorTest();
            CarTest();
            //ModelTest();


            static void CarTest()
            {
                CarManager carManager = new CarManager(new EfCarDal());
                //carManager.Add(new Car
                //{
                //    BrandId = 1,
                //    ColorId = 1,
                //    ModelId = 1,
                //    ModelYear = "2018",
                //    Description = "130 beygir temiz",
                //    DailyPrice = 200
                //});
                //carManager.Add(new Car
                //{
                //    BrandId = 1,
                //    ColorId = 2,
                //    ModelId = 2,
                //    ModelYear = "2019",
                //    Description = "150 beygir temiz bakımlı",
                //    DailyPrice = 400
                //});
                //carManager.Add(new Car
                //{
                //    BrandId = 1,
                //    ColorId = 1,
                //    ModelId = 3,
                //    ModelYear = "2020",
                //    Description = "250 beygir temiz canavar",
                //    DailyPrice = 800
                //});
                //carManager.Add(new Car
                //{
                //    BrandId = 2,
                //    ColorId = 2,
                //    ModelId = 4,
                //    ModelYear = "2016",
                //    Description = "110 beygir bakımı yapılmış",
                //    DailyPrice = 350
                //});
                //carManager.Add(new Car
                //{
                //    BrandId = 2,
                //    ColorId = 1,
                //    ModelId = 5,
                //    ModelYear = "2017",
                //    Description = "150 beygir az kullanılmış",
                //    DailyPrice = 500
                //});
                //carManager.Add(new Car
                //{
                //    BrandId = 3,
                //    ColorId = 1,
                //    ModelId = 6,
                //    ModelYear = "2010",
                //    Description = "100 beygir güzel",
                //    DailyPrice = 150
                //});
                //carManager.Add(new Car
                //{
                //    BrandId = 3,
                //    ColorId = 2,
                //    ModelId = 7,
                //    ModelYear = "2016",
                //    Description = "130 beygir temiz ve bakımlı",
                //    DailyPrice = 300
                //});

                foreach (var car in carManager.GetCarDetails())
                {
                    Console.WriteLine(car.CarId+" - "+car.BrandName+" - "+car.ModelName+" - "+car.ModelYear+" - "+car.DailyPrice+" - "+car.Descripton);
                }
            }

            static void ColorTest()
            {
                ColorManager colorManager = new ColorManager(new EfColorDal());
                colorManager.Add(new Color { ColorName = "Beyaz" });
                colorManager.Add(new Color { ColorName = "Kırmızı" });
            }

            static void BrandTest()
            {
                BrandManager brandManager = new BrandManager(new EfBrandDal());
                brandManager.Add(new Brand { BrandName = "BMW" });
                brandManager.Add(new Brand { BrandName = "AUDİ" });
            }

            static void ModelTest()
            {
                ModelManager modelManager = new ModelManager(new EfModelDal());
                modelManager.Add(new Model { BrandId = 1, ModelName = "C180" });
                modelManager.Add(new Model { BrandId = 1, ModelName = "E250" });
                modelManager.Add(new Model { BrandId = 1, ModelName = "GLA200" });
                modelManager.Add(new Model { BrandId = 2, ModelName = "520D" });
                modelManager.Add(new Model { BrandId = 2, ModelName = "X5" });
                modelManager.Add(new Model { BrandId = 3, ModelName = "A5" });
                modelManager.Add(new Model { BrandId = 3, ModelName = "A6" });
            }
        }
    }
}
