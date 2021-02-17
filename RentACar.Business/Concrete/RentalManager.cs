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
    public class RentalManager : GenericManager<Rental>, IRentalService
    {
        private readonly IRentalDal _rentalDal;
        public RentalManager(IEntityRepository<Rental> entityRepository, IRentalDal rentalDal) : base(entityRepository)
        {
            _rentalDal = rentalDal;
        }

        public async Task<IDataResult<RentalDetailDto>> GetRentalDetailByIdAsync(int id)
        {
            return new SuccessDataResult<RentalDetailDto>(await _rentalDal.GetRentalDetailByIdAsync(id));
        }

        public async Task<IDataResult<List<RentalDetailDto>>> GetRentalsDetailAsync()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(await _rentalDal.GetRentalsDetailAsync());
        }
    }
}
