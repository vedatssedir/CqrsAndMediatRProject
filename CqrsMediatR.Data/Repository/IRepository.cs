using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CqrsMediatR.Domain;

namespace CqrsMediatR.Data.Repository
{
    public interface IRepository<TEntity> where TEntity : class,IEntity, new()
    {
        IEnumerable<TEntity> GetAll();
        Task<TEntity?> GetByIdAsync(long id);
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
    }
}
