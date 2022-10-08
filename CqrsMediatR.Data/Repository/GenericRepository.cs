using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CqrsMediatR.Data.ORM.EntityFramework;
using CqrsMediatR.Domain;

namespace CqrsMediatR.Data.Repository
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity, new()
    {

        private readonly DataContext _dataContext;
        public GenericRepository(DataContext dataContext) => _dataContext = dataContext;
        public IEnumerable<TEntity> GetAll() => _dataContext.Set<TEntity>();
        public async Task<TEntity?> GetByIdAsync(long id) => await _dataContext.Set<TEntity>().FindAsync(id);
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            ArgumentNullException.ThrowIfNull(entity);
            await _dataContext.AddAsync(entity);
            await _dataContext.SaveChangesAsync();
            return entity;
        }
        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            ArgumentNullException.ThrowIfNull(entity);
            _dataContext.Update(entity);
            await _dataContext.SaveChangesAsync();
            return entity;
        }
    }
}
