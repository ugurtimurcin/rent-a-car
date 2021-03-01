using RentACar.Business.Abstract;
using RentACar.Business.ValidationRules.FluentValidation;
using RentACar.Core.Aspects.Autofac.Validation;
using RentACar.Core.DataAccess;
using RentACar.Core.Entities.Concrete;
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
    public class AppUserManager : IAppUserService
    {
        private readonly IAppUserDal _appUserDal;
        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        [ValidationAspect(typeof(AppUserValidator))]
        public async Task<IResult> AddAsync(User entity)
        {
            await _appUserDal.AddAsync(entity);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(User entity)
        {
            await _appUserDal.DeleteAsync(entity);
            return new SuccessResult();
        }

        public async Task<IDataResult<IEnumerable<User>>> GetAllAsync()
        {
            return new SuccessDataResult<IEnumerable<User>>(await _appUserDal.GetAllAsync());
        }

        public async Task<IDataResult<User>> GetByIdAsync(int id)
        {
            return new SuccessDataResult<User>(await _appUserDal.GetByIdAsync(id));
        }

        [ValidationAspect(typeof(AppUserValidator))]
        public async Task<IResult> UpdateAsync(User entity)
        {
            await _appUserDal.UpdateAsync(entity);
            return new SuccessResult();
        }
    }
}
