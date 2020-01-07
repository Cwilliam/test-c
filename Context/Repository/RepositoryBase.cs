using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions; 

namespace Context.Repository
{
    public class RepositoryBase<TEntity> where TEntity : class
    {

        public RepositoryBase()
        {

        }

        public void Add(TEntity entity, List<TEntity> list)
        {
            list.Add(entity);
        }

        public TEntity GetById(int id)
        {
            return null; 
        }

        public IQueryable<TEntity> GetAll()
        {
            return null; 
        }

        public virtual IQueryable<Object> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null)
        {
            return Context.Product.AsQueryable();
        }

        public void Update(TEntity entity)
        {
        }

        public void Delete(Int64 id)
        {

        }
    }
}
