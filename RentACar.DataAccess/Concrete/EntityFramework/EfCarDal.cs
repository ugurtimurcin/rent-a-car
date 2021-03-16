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
        public async Task<List<CarDetailDto>> GetCarDetailAsync(Expression<Func<CarDetailDto, bool>> predicate = null)
        {
            using var context = new DataContext();
            var result = from car in context.Cars
                         join brand in context.Brands
                         on car.BrandId equals brand.Id
                         join color in context.Colors
                         on car.ColorId equals color.Id
                         join carImage in context.CarImages
                         on car.Id equals carImage.CarId
                         select new CarDetailDto
                         {
                             Brand = brand.Name,
                             BrandId = brand.Id,
                             Color = color.Name,
                             DailyPrice = car.DailyPrice,
                             Description = car.Description,
                             Id = car.Id,
                             ModelYear = car.ModelYear,
                             ImagePath = carImage.ImagePath
                         };
            return predicate != null ? await result.Where(predicate).ToListAsync() : await result.ToListAsync();
        }

        public async Task<CarDetailDto> GetCarDetailByIdAsync(int id)
        {
            using var context = new DataContext();
            var result = from car in context.Cars
                         join brand in context.Brands
                         on car.BrandId equals brand.Id
                         join color in context.Colors
                         on car.ColorId equals color.Id
                         join carImage in context.CarImages
                         on car.Id equals carImage.CarId
                         select new CarDetailDto
                         {
                             Brand = brand.Name,
                             BrandId = brand.Id,
                             Color = color.Name,
                             DailyPrice = car.DailyPrice,
                             Description = car.Description,
                             Id = car.Id,
                             ModelYear = car.ModelYear,
                             ImagePath = carImage.ImagePath
                         };
            return await result.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
    }
}
