using RentACar.Core.Entities.Concrete;
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
        Task<IDataResult<User>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<User>>> GetAllAsync();
        Task<IResult> AddAsync(User entity);
        Task<IResult> DeleteAsync(User entity);
        Task<IResult> UpdateAsync(User entity);
    }
}
