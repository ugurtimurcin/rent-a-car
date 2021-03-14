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
    public interface ICarService
    {
        Task<IDataResult<Car>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<Car>>> GetAllAsync();
        Task<IDataResult<IEnumerable<CarDetailDto>>> GetByBrandAsync(int id);
        Task<IResult> AddAsync(Car entity);
        Task<IResult> DeleteAsync(Car entity);
        Task<IResult> UpdateAsync(Car entity);
        Task<IDataResult<List<CarDetailDto>>> GetCarDetailAsync();
    }
}
