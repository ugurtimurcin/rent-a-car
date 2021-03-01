using Microsoft.EntityFrameworkCore;
using RentACar.Core.DataAccess.EntityFramework;
using RentACar.Core.Entities.Concrete;
using RentACar.DataAccess.Abstract;
using RentACar.Entities;
using RentACar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, DataContext>, IUserDal
    {
        public async Task<List<OperationClaimDto>> GetClaimsAsync(User  user)
        {
            using DataContext context = new DataContext();
            var result = from operationClaim in context.OperationClaims
                         join userOperationClaim in context.UserOperationClaims
                         on operationClaim.Id equals userOperationClaim.OperationClaimId
                         where userOperationClaim.UserId == user.Id
                         select new OperationClaimDto
                         {
                             Id = operationClaim.Id,
                             Name = operationClaim.Name
                         };
            return await result.ToListAsync();
        }
    }
}
