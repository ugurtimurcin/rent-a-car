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
    public class RentalManager : GenericManager<Rental>, IRentAlService
    {
        public RentalManager(IEntityRepository<Rental> entityRepository) : base(entityRepository)
        {

        }
    }
}
