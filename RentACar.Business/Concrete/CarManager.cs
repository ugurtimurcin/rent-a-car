using RentACar.Business.Abstract;
using RentACar.Core.DataAccess;
using RentACar.Core.Utilities.Results.Abstract;
using RentACar.Core.Utilities.Results.Concrete;
using RentACar.DataAccess.Abstract;
using RentACar.Entities;
using RentACar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.Concrete
{
    public class CarManager : GenericManager<Car>, ICarService
    {
        private readonly ICarDal _carDal;
        public CarManager(IEntityRepository<Car> entityRepository, ICarDal carDal) : base(entityRepository)
        {
            _carDal = carDal;
        }

        public async Task<IDataResult<List<CarDetailDto>>> GetCarDetailAsync()
        {
            return new SuccessDataResult<List<CarDetailDto>>(await _carDal.GetCarDetailAsync());
        }
    }
}
