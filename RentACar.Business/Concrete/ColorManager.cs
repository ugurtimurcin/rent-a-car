using RentACar.Business.Abstract;
using RentACar.Core.Business;
using RentACar.Core.DataAccess;
using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.Concrete
{
    public class ColorManager : GenericManager<Color>, IColorService
    {
        //private readonly IEntityRepository<Color> _entityRepository;
        public ColorManager(IEntityRepository<Color> entityRepository) : base(entityRepository)
        {
            
        }
    }
}
