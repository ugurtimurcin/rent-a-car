using RentACar.Business.Constants;
using RentACar.Core.Business;
using RentACar.Core.DataAccess;
using RentACar.Core.Entities;
using RentACar.Core.Utilities.Results.Abstract;
using RentACar.Core.Utilities.Results.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Business.Concrete
{
    public class GenericManager<T> : IGenericService<T> where T : class, IEntity, new()
    {
        private readonly IEntityRepository<T> _entityRepository;
        public GenericManager(IEntityRepository<T> entityRepository)
        {
            _entityRepository = entityRepository;
        }
        public async Task<IResult> AddAsync(T entity)
        {
            await _entityRepository.AddAsync(entity);
            return new SuccessResult(Messages.Added);
        }

        public async Task<IResult> DeleteAsync(T entity)
        {
            await _entityRepository.DeleteAsync(entity);
            return new SuccessResult(Messages.Removed);
        }

        public async Task<IDataResult<IEnumerable<T>>> GetAllAsync()
        {
            return new SuccessDataResult<IEnumerable<T>>(await _entityRepository.GetAllAsync());
        }

        public async Task<IDataResult<T>> GetByIdAsync(int id)
        {
            return new SuccessDataResult<T>(await _entityRepository.GetByIdAsync(id));
        }

        public async Task<IResult> UpdateAsync(T entity)
        {
            await _entityRepository.UpdateAsync(entity);
            return new SuccessResult(Messages.Updated);
        }
    }
}
