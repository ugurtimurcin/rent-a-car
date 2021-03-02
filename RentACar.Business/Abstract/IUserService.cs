using RentACar.Core.Entities.Concrete;
using RentACar.Core.Utilities.Results.Abstract;
using RentACar.Entities.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RentACar.Business.Abstract
{
    public interface IUserService
    {
        Task<IDataResult<User>> GetByIdAsync(int id);
        Task<IDataResult<User>> GetByEmailAsync(string email);
        Task<IDataResult<IEnumerable<User>>> GetAllAsync();
        Task<List<OperationClaim>> GetClaimsAsync(User user);
        Task<IResult> AddAsync(User entity);
        Task<IResult> DeleteAsync(User entity);
        Task<IResult> UpdateAsync(User entity);
    }
}
