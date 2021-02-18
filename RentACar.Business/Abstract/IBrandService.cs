using RentACar.Core.Utilities.Results.Abstract;
using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.Abstract
{
    public interface IBrandService
    {
        Task<IDataResult<Brand>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<Brand>>> GetAllAsync();
        Task<IResult> AddAsync(Brand entity);
        Task<IResult> DeleteAsync(Brand entity);
        Task<IResult> UpdateAsync(Brand entity);
    }
}
