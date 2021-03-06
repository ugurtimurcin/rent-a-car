﻿using RentACar.Business.Abstract;
using RentACar.Business.ValidationRules.FluentValidation;
using RentACar.Core.Aspects.Autofac.Validation;
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

        [ValidationAspect(typeof(CarValidator))]
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

        public async Task<IDataResult<IEnumerable<CarDetailDto>>> GetByBrandAsync(int id)
        {
            return new SuccessDataResult<IEnumerable<CarDetailDto>>(await _carDal.GetCarDetailAsync(x => x.BrandId == id));
        }

        public async Task<IDataResult<Car>> GetByIdAsync(int id)
        {
            return new SuccessDataResult<Car>(await _carDal.GetAsync(x=>x.Id == id));
        }

        public async Task<IDataResult<List<CarDetailDto>>> GetCarDetailAsync()
        {
            return new SuccessDataResult<List<CarDetailDto>>(await _carDal.GetCarDetailAsync());
        }

        public async Task<IDataResult<CarDetailDto>> GetCarDetailByIdAsync(int id)
        {
            return new SuccessDataResult<CarDetailDto>(await _carDal.GetCarDetailByIdAsync(id));
        }

        [ValidationAspect(typeof(CarValidator))]
        public async Task<IResult> UpdateAsync(Car entity)
        {
            await _carDal.UpdateAsync(entity);
            return new SuccessResult();
        }
    }
}
