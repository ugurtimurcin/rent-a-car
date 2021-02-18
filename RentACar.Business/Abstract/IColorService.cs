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
    public interface IColorService
    {
        Task<IDataResult<Color>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<Color>>> GetAllAsync();
        Task<IResult> AddAsync(Color entity);
        Task<IResult> DeleteAsync(Color entity);
        Task<IResult> UpdateAsync(Color entity);
    }
}
