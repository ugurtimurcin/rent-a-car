using RentACar.Business.Abstract;
using RentACar.Business.Constants;
using RentACar.Core.Utilities.Business;
using RentACar.Core.Utilities.Results.Abstract;
using RentACar.Core.Utilities.Results.Concrete;
using RentACar.DataAccess.Abstract;
using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        private readonly ICarImageDal _carImageDal;
        private readonly ICarService _carService;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        public async Task<IResult> AddAsync(CarImage entity)
        {
            await _carImageDal.AddAsync(entity);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(CarImage entity)
        {
            BusinessRules.Run(IfCarHasMoreThanFiveImages(entity.CarId).Result);
            await _carImageDal.DeleteAsync(entity);
            return new SuccessResult();
        }

        public async Task<IDataResult<IEnumerable<CarImage>>> GetAllAsync()
        {
            return new SuccessDataResult<IEnumerable<CarImage>>(await _carImageDal.GetAllAsync());
        }

        public async Task<IDataResult<CarImage>> GetByIdAsync(int id)
        {
            return new SuccessDataResult<CarImage>(await _carImageDal.GetByIdAsync(id));
        }

        public async Task<IResult> UpdateAsync(CarImage entity)
        {
            await _carImageDal.DeleteAsync(entity);
            return new SuccessResult();
        }


        private async Task<IResult> IfCarHasMoreThanFiveImages(int id)
        {
            var car = await _carService.GetByIdAsync(id);
            if (car.Data.CarImages.Count>5)
            {
                return new ErrorResult(Messages.CarHasMoreThan5ImagesError);
            }
            return new SuccessResult();
        }
    }
}
