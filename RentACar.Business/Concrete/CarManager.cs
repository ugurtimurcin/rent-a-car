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
    public class CarManager : GenericManager<Car>, ICarService
    {
        public CarManager(IEntityRepository<Car> entityRepository) : base(entityRepository)
        {

        }
    }
}
