using RentACar.Core.DataAccess;
using RentACar.DataAccess.Concrete;
using RentACar.Entities;
using RentACar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        Task<List<CarDetailDto>> GetCarDetailAsync(Expression<Func<CarDetailDto, bool>> predicate = null);
    }
}
