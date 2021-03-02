using RentACar.Business.Abstract;
using RentACar.Business.ValidationRules.FluentValidation;
using RentACar.Core.Aspects.Autofac.Validation;
using RentACar.Core.DataAccess;
using RentACar.Core.Entities.Concrete;
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
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        [ValidationAspect(typeof(AppUserValidator))]
        public async Task<IResult> AddAsync(User entity)
        {
            await _userDal.AddAsync(entity);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(User entity)
        {
            await _userDal.DeleteAsync(entity);
            return new SuccessResult();
        }

        public async Task<IDataResult<IEnumerable<User>>> GetAllAsync()
        {
            return new SuccessDataResult<IEnumerable<User>>(await _userDal.GetAllAsync());
        }

        public async Task<IDataResult<User>> GetByEmailAsync(string email)
        {
            return new SuccessDataResult<User>(await _userDal.GetAsync(x=>x.Email == email));
        }

        public async Task<IDataResult<User>> GetByIdAsync(int id)
        {
            return new SuccessDataResult<User>(await _userDal.GetAsync(x=>x.Id == id));
        }

        public async Task<List<OperationClaim>> GetClaimsAsync(User user)
        {
            return await _userDal.GetClaimsAsync(user);
        }

        [ValidationAspect(typeof(AppUserValidator))]
        public async Task<IResult> UpdateAsync(User entity)
        {
            await _userDal.UpdateAsync(entity);
            return new SuccessResult();
        }
    }
}
