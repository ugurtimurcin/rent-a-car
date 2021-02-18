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
    public interface IRentalService
    {
        Task<IDataResult<Rental>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<Rental>>> GetAllAsync();
        Task<IResult> AddAsync(Rental entity);
        Task<IResult> DeleteAsync(Rental entity);
        Task<IResult> UpdateAsync(Rental entity);
        Task<IDataResult<RentalDetailDto>> GetRentalDetailByIdAsync(int id);
        Task<IDataResult<List<RentalDetailDto>>> GetRentalsDetailAsync();
    }
}
