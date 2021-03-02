using RentACar.Core.Entities.Concrete;
using System.Collections.Generic;

namespace RentACar.Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
