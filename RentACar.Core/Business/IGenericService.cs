using RentACar.Core.Entities;
using RentACar.Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Core.Business
{
    public interface IGenericService<T> where T : class, IEntity, new()
    {
        Task<IDataResult<T>> GetByIdAsync(int id);
        Task<IDataResult<IEnumerable<T>>> GetAllAsync();
        Task<IResult> AddAsync(T entity);
        Task<IResult> DeleteAsync(T entity);
        Task<IResult> UpdateAsync(T entity);
    }
}
