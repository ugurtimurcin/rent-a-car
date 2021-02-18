using RentACar.Core.DataAccess.EntityFramework;
using RentACar.DataAccess.Abstract;
using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, DataContext>, IBrandDal
    {
    }
}
