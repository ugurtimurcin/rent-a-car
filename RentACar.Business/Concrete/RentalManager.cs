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
    public class RentalManager : IRentalService
    {
        private readonly IRentalDal _rentalDal;
        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public async Task<IResult> AddAsync(Rental entity)
        {
            await _rentalDal.AddAsync(entity);
            return new SuccessResult();
        }

        public async Task<IResult> DeleteAsync(Rental entity)
        {
            await _rentalDal.DeleteAsync(entity);
            return new SuccessResult();
        }

        public async Task<IDataResult<IEnumerable<Rental>>> GetAllAsync()
        {
            return new SuccessDataResult<IEnumerable<Rental>>(await _rentalDal.GetAllAsync());
        }

        public async Task<IDataResult<Rental>> GetByIdAsync(int id)
        {
            return new SuccessDataResult<Rental>(await _rentalDal.GetByIdAsync(id));
        }

        public async Task<IDataResult<RentalDetailDto>> GetRentalDetailByIdAsync(int id)
        {
            return new SuccessDataResult<RentalDetailDto>(await _rentalDal.GetRentalDetailByIdAsync(id));
        }

        public async Task<IDataResult<List<RentalDetailDto>>> GetRentalsDetailAsync()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(await _rentalDal.GetRentalsDetailAsync());
        }

        public async Task<IResult> UpdateAsync(Rental entity)
        {
            await _rentalDal.UpdateAsync(entity);
            return new SuccessResult();
        }
    }
}
