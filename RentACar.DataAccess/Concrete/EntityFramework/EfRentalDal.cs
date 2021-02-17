﻿using Microsoft.EntityFrameworkCore;
using RentACar.Core.DataAccess.EntityFramework;
using RentACar.DataAccess.Abstract;
using RentACar.Entities;
using RentACar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, DataContext>, IRentalDal
    {
        public async Task<RentalDetailDto> GetRentalDetailByIdAsync(int id)
        {
            using var context = new DataContext();
            var result = from r in context.Rentals.Where(x=>x.Id == id)
                         join a in context.AppUsers
                         on r.AppUserId equals a.Id
                         join c in context.Cars
                         on r.CarId equals c.Id
                         join col in context.Colors
                         on c.ColorId equals col.Id
                         join b in context.Brands
                         on c.BrandId equals b.Id
                         select new RentalDetailDto
                         {
                             Id = r.Id,
                             CarBrand = b.Name,
                             CarColor = col.Name,
                             CarDailyPrice = c.DailyPrice,
                             CarDescription = c.Description,
                             CarImage = c.CarImage,
                             CarModelYear = c.ModelYear,
                             Email = a.Email,
                             FirstName = a.FirstName,
                             LastName = a.LastName,
                             RentDate = r.RentDate,
                             ReturnDate = r.ReturnDate,
                             UserName = a.UserName
                         };

            return await result.FirstOrDefaultAsync();
        }

        public async Task<List<RentalDetailDto>> GetRentalsDetailAsync()
        {
            using var context = new DataContext();
            var result = from r in context.Rentals
                         join a in context.AppUsers
                         on r.AppUserId equals a.Id
                         join c in context.Cars
                         on r.CarId equals c.Id
                         join col in context.Colors
                         on c.ColorId equals col.Id
                         join b in context.Brands
                         on c.BrandId equals b.Id
                         select new RentalDetailDto
                         {
                             Id = r.Id,
                             CarBrand = b.Name,
                             CarColor = col.Name,
                             CarDailyPrice = c.DailyPrice,
                             CarDescription = c.Description,
                             CarImage = c.CarImage,
                             CarModelYear = c.ModelYear,
                             Email = a.Email,
                             FirstName = a.FirstName,
                             LastName = a.LastName,
                             RentDate = r.RentDate,
                             ReturnDate = r.ReturnDate,
                             UserName = a.UserName
                         };

            return await result.ToListAsync();
        }
    }
}
