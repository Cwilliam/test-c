using System;
using System.Linq;
using System.Linq.Expressions;

namespace Context.Repository
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity entity);
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null);
        void Update(TEntity entity);
        void Delete(Int64 id);
        void Delete(TEntity entity);
    }
}
