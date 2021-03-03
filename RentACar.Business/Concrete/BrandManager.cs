using RentACar.Business.Abstract;
using RentACar.Business.BusinessAspects.Autofac;
using RentACar.Business.ValidationRules.FluentValidation;
using RentACar.Core.Aspects.Autofac.Validation;
using RentACar.Core.DataAccess;
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
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        [SecuredOperation("Admin")]
        [ValidationAspect(typeof(BrandValidator))]
        public async Task<IResult> AddAsync(Brand entity)
        {
            await _brandDal.AddAsync(entity);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(Brand entity)
        {
            await _brandDal.DeleteAsync(entity);
            return new SuccessResult();
        }
        [SecuredOperation("Admin")]
        public async Task<IDataResult<IEnumerable<Brand>>> GetAllAsync()
        {
            return new SuccessDataResult<IEnumerable<Brand>>(await _brandDal.GetAllAsync());
        }

        public async Task<IDataResult<Brand>> GetByIdAsync(int id)
        {
            return new SuccessDataResult<Brand>(await _brandDal.GetAsync(x=>x.Id == id));
        }

        [ValidationAspect(typeof(BrandValidator))]
        public async Task<IResult> UpdateAsync(Brand entity)
        {
            await _brandDal.UpdateAsync(entity);
            return new SuccessResult();
        }
    }
}
