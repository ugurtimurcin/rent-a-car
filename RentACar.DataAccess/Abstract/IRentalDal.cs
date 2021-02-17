using RentACar.Core.DataAccess;
using RentACar.Core.Utilities.Results.Abstract;
using RentACar.Entities;
using RentACar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccess.Abstract
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
        Task<RentalDetailDto> GetRentalDetailByIdAsync(int id);
        Task<List<RentalDetailDto>> GetRentalsDetailAsync();
    }
}
