using Microsoft.AspNetCore.Http;
using RentACar.Business.Abstract;
using RentACar.Business.Constants;
using RentACar.Core.Utilities.Business;
using RentACar.Core.Utilities.Helpers.FileHelper.Abstract;
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
        private readonly IImageProcess _imageProcess;
        public CarImageManager(ICarImageDal carImageDal, IImageProcess imageProcess)
        {
            _carImageDal = carImageDal;
            _imageProcess = imageProcess;
        }
        public async Task<IResult> AddAsync(CarImage entity, IFormFile file)
        {
            BusinessRules.Run(CheckCarImageLimit(entity.CarId).Result);
            await _imageProcess.UploadAsync(entity.ImagePath, file);

            await _carImageDal.AddAsync(entity);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(CarImage entity)
        {
            _imageProcess.Delete(entity.ImagePath);
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
            _imageProcess.Delete(entity.ImagePath);
            return new SuccessResult();
        }


        private async Task<IResult> CheckCarImageLimit(int id)
        {
            var car = await _carImageDal.GetAllAsync(x=>x.Id == id);
            if (car.Count()>5)
            {
                return new ErrorResult(Messages.CarHasMoreThan5ImagesError);
            }
            return new SuccessResult();
        }
    }
}
