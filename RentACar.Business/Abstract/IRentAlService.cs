using RentACar.Core.Business;
using RentACar.Core.Utilities.Results.Abstract;
using RentACar.Entities;
using RentACar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.Abstract
{
    public interface IRentalService : IGenericService<Rental>
    {
        Task<IDataResult<RentalDetailDto>> GetRentalDetailByIdAsync(int id);
        Task<IDataResult<List<RentalDetailDto>>> GetRentalsDetailAsync();
    }
}
