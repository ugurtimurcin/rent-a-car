using RentACar.Core.DataAccess;
using RentACar.Core.Entities.Concrete;
using RentACar.Entities.DTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RentACar.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        Task<List<OperationClaim>> GetClaimsAsync(User user);
    }
}
