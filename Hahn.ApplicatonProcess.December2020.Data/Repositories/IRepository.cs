using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Hahn.ApplicatonProcess.December2020.Data.Repositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task Delete(object id);
        Task Delete(TEntity entityToDelete);
        Task<List<TEntity>> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
        Task<TEntity> GetByID(object id);
        Task Insert(TEntity entity);
        Task Update(TEntity entityToUpdate);
    }
}