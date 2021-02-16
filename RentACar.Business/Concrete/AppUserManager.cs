using RentACar.Business.Abstract;
using RentACar.Core.DataAccess;
using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.Concrete
{
    public class AppUserManager : GenericManager<AppUser>, IAppUserService
    {
        //private readonly IEntityRepository<AppUser> _entityRepository;
        public AppUserManager(IEntityRepository<AppUser> entityRepository):base(entityRepository)
        {
            //_entityRepository = entityRepository;
        }
    }
}
