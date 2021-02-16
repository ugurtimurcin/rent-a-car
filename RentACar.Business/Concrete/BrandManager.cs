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
    public class BrandManager : GenericManager<Brand>, IBrandService
    {
        public BrandManager(IEntityRepository<Brand> entityRepository) : base(entityRepository)
        {

        }
    }
}
