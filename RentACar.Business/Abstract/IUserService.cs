using RentACar.Core.Entities.Concrete;
using RentACar.Core.Utilities.Results.Abstract;
using RentACar.DataAccess.Abstract;
using RentACar.Entities;
using RentACar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.Abstract
{
    public interface IUserService
    {
        Task<IDataResult<User>> GetByIdAsync(int id);
        Task<IDataResult<User>> GetByEmailAsync(string email);
        Task<IDataResult<IEnumerable<User>>> GetAllAsync();
        Task<IDataResult<List<OperationClaimDto>>> GetClaimsAsync(User user);
        Task<IResult> AddAsync(User entity);
        Task<IResult> DeleteAsync(User entity);
        Task<IResult> UpdateAsync(User entity);
    }
}
