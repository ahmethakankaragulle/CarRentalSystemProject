using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarProjectDbContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarProjectDbContext context = new CarProjectDbContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join m in context.Models
                             on c.ModelId equals m.ModelId
                             select new CarDetailDto { CarId = c.CarId, BrandName = b.BrandName, ModelName = m.ModelName, 
                                 ModelYear = c.ModelYear,  DailyPrice = c.DailyPrice, Descripton = c.Description };
                
                return result.ToList();
            }
        }
    }
}
