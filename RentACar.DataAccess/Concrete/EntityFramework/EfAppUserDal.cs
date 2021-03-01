using RentACar.Core.DataAccess.EntityFramework;
using RentACar.Core.Entities.Concrete;
using RentACar.DataAccess.Abstract;
using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccess.Concrete.EntityFramework
{
    public class EfAppUserDal : EfEntityRepositoryBase<User, DataContext>, IAppUserDal
    {
    }
}
