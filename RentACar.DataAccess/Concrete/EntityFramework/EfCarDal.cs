using Microsoft.EntityFrameworkCore;
using RentACar.Core.DataAccess.EntityFramework;
using RentACar.DataAccess.Abstract;
using RentACar.Entities;
using RentACar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, DataContext>, ICarDal
    {
        public async Task<List<CarDetailDto>> GetCarDetailAsync()
        {
            using var context = new DataContext();
            var result = from c in context.Cars
                         join b in context.Brands
                         on c.BrandId equals b.Id
                         join col in context.Colors
                         on c.ColorId equals col.Id
                         select new CarDetailDto
                         {
                             Id = c.Id,
                             Brand = b.Name,
                             Color = col.Name,
                             CarImage = c.CarImage,
                             DailyPrice = c.DailyPrice,
                             Description = c.Description,
                             ModelYear = c.ModelYear
                         };
            return await result.OrderByDescending(x=>x.Id).ToListAsync();
        }
    }
}
