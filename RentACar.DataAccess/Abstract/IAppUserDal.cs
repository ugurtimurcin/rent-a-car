using RentACar.Core.DataAccess;
using RentACar.Core.Entities.Concrete;
using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccess.Abstract
{
    public interface IAppUserDal : IEntityRepository<User>
    {
    }
}
