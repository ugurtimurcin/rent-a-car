using RentACar.Business.Abstract;
using RentACar.Business.ValidationRules.FluentValidation;
using RentACar.Core.Aspects.Autofac.Validation;
using RentACar.Core.CrossCuttingConcerns.Validation;
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
    public class ColorManager : IColorService
    {
        private readonly IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        [ValidationAspect(typeof(ColorValidator))]
        public async Task<IResult> AddAsync(Color entity)
        {
            await _colorDal.AddAsync(entity);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(Color entity)
        {
            await _colorDal.DeleteAsync(entity);
            return new SuccessResult();
        }

        public async Task<IDataResult<IEnumerable<Color>>> GetAllAsync()
        {
            return new SuccessDataResult<IEnumerable<Color>>(await _colorDal.GetAllAsync());
        }

        public async Task<IDataResult<Color>> GetByIdAsync(int id)
        {
            return new SuccessDataResult<Color>(await _colorDal.GetAsync(x=>x.Id == id));
        }

        [ValidationAspect(typeof(ColorValidator))]
        public async Task<IResult> UpdateAsync(Color entity)
        {
            await _colorDal.UpdateAsync(entity);
            return new SuccessResult();
        }
    }
}
