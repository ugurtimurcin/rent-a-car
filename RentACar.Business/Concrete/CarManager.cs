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
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public async Task<IResult> AddAsync(Car entity)
        {
            await _carDal.AddAsync(entity);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(Car entity)
        {
            await _carDal.DeleteAsync(entity);
            return new SuccessResult();
        }

        public async Task<IDataResult<IEnumerable<Car>>> GetAllAsync()
        {
            return new SuccessDataResult<IEnumerable<Car>>(await _carDal.GetAllAsync());
        }

        public async Task<IDataResult<Car>> GetByIdAsync(int id)
        {
            return new SuccessDataResult<Car>(await _carDal.GetByIdAsync(id));
        }

        public async Task<IDataResult<List<CarDetailDto>>> GetCarDetailAsync()
        {
            return new SuccessDataResult<List<CarDetailDto>>(await _carDal.GetCarDetailAsync());
        }

        public async Task<IResult> UpdateAsync(Car entity)
        {
            await _carDal.UpdateAsync(entity);
            return new SuccessResult();
        }
    }
}
