using RentACar.Core.Utilities.Results.Abstract;
using RentACar.DataAccess.Abstract;
using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.Abstract
{
    public interface IAppUserService
    {
        Task<IDataResult<AppUser>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<AppUser>>> GetAllAsync();
        Task<IResult> AddAsync(AppUser entity);
        Task<IResult> DeleteAsync(AppUser entity);
        Task<IResult> UpdateAsync(AppUser entity);
    }
}
