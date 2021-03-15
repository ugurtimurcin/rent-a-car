using Microsoft.AspNetCore.Http;
using RentACar.Core.Utilities.Results.Abstract;
using RentACar.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.Abstract
{
    public interface ICarImageService 
    {
        Task<IDataResult<CarImage>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<CarImage>>> GetAllAsync();
        Task<IResult> AddAsync(CarImage entity, List<IFormFile> files);
        Task<IResult> DeleteAsync(CarImage entity);
        Task<IResult> UpdateAsync(CarImage entity, IFormFile file);
    }
}
