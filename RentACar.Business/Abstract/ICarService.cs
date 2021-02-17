using RentACar.Core.Business;
using RentACar.Core.Utilities.Results.Abstract;
using RentACar.Entities;
using RentACar.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.Abstract
{
    public interface ICarService : IGenericService<Car>
    {
        Task<IDataResult<List<CarDetailDto>>> GetCarDetailAsync();
    }
}
